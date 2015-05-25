﻿using UnityEngine;
using System.Collections;

public class MoveMatlab : MonoBehaviour {

	private float LongitudLadoTriangulo=3.0f;
	private float Phi = Mathf.PI / 4;
	private float CoordenadaXMotor1 = -1.5f;
	private float CoordenadaYMotor1 = -8.4f;
	private float LongitudEslabon1=5.0f;
	private float LongitudEslabon2=4.0f;

	// Use this for initialization
	void Start () {
		CalculateAngles ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CalculateAngles(){

		float CoordenadaXCentro=0.0f;
		float CoordenadaYCentro=0.0f;

		float UbicacionCentroBase  = (Mathf.Sqrt(3)/3)*LongitudLadoTriangulo;
		float Xa = CoordenadaXCentro -UbicacionCentroBase* Mathf.Cos(Phi+(Mathf.PI/6));   
		float Ya = CoordenadaYCentro -UbicacionCentroBase*Mathf.Sin(Phi+(Mathf.PI/6));   
		
		float[] Xd= new float[2];
		float[] Yd= new float[2];


	

		Xd[0]=(1.0f/2.0f)*(1.0f/(-8.0f*CoordenadaXMotor1*Xa-8.0f*Ya*CoordenadaYMotor1+4.0f*Mathf.Pow(Ya,2)+4.0f*Mathf.Pow(CoordenadaYMotor1,2)+4.0f*Mathf.Pow(Xa,2)+4.0f*Mathf.Pow(CoordenadaXMotor1,2))
		                   *(-4.0f*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)-4.0f*Mathf.Pow(Ya,2)*CoordenadaYMotor1+4.0f*Mathf.Pow(Ya,3)+4.0f*Mathf.Pow(CoordenadaXMotor1,2)
		  *CoordenadaYMotor1-4.0f*Ya*Mathf.Pow(LongitudEslabon2,2)+4.0f*Ya*Mathf.Pow(LongitudEslabon1,2)+4.0f*Ya*Mathf.Pow(CoordenadaXMotor1,2)+4.0f*Mathf.Pow(LongitudEslabon2,2)
		  *CoordenadaYMotor1-4.0f*Ya*Mathf.Pow(CoordenadaYMotor1,2)+4.0f*Mathf.Pow(Xa,2)*Ya-8.0f*CoordenadaXMotor1*Xa*CoordenadaYMotor1+4.0f*Mathf.Pow(Xa,2)*CoordenadaYMotor1-8.0f
		  *CoordenadaXMotor1*Xa*Ya+4.0f*Mathf.Pow(CoordenadaYMotor1,3)+4.0f*(Mathf.Sqrt(-2*Mathf.Pow(Xa,4)*Mathf.Pow(CoordenadaYMotor1,2)+2.0f*CoordenadaXMotor1*Xa*Mathf.Pow(LongitudEslabon2,4)
		                                                                              +2.0f*Mathf.Pow(Xa,4)*Mathf.Pow(LongitudEslabon2,2)+12.0f*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon1,2)+2.0f
		                                                                              *Mathf.Pow(Xa,4)*Mathf.Pow(LongitudEslabon1,2)-15.0f*Mathf.Pow(Xa,4)*Mathf.Pow(CoordenadaXMotor1,2)-2.0f*Mathf.Pow(Xa,4)*Mathf.Pow(Ya,2)+12.0f*Mathf.Pow(CoordenadaXMotor1,2)
		                                                                              *Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon2,2)-8.0f*CoordenadaXMotor1*Mathf.Pow(Xa,3)*Mathf.Pow(LongitudEslabon2,2)+2.0f*CoordenadaXMotor1*Xa*Mathf.Pow(LongitudEslabon1,4)
		                                                                              +2.0f*Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(LongitudEslabon1,2)+2.0f*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(LongitudEslabon1,2)
		                                                                              -16.0f*Mathf.Pow(Xa,3)*Ya*CoordenadaXMotor1*CoordenadaYMotor1-4.0f*CoordenadaXMotor1*Xa*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(LongitudEslabon1,2)+8.0f*CoordenadaYMotor1*
		                                                                              Mathf.Pow(LongitudEslabon1,2)*CoordenadaXMotor1*Xa*Ya-4.0f*Ya*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(Xa,2)*CoordenadaYMotor1+8.0f*Ya*Mathf.Pow(LongitudEslabon2,2)*CoordenadaXMotor1*
		                                                                              Xa*CoordenadaYMotor1-4.0f*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon2,2)*CoordenadaXMotor1*Xa-4.0f*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon1,2)*CoordenadaXMotor1*Xa-4.0f
		                                                                              *Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(CoordenadaYMotor1,2)*CoordenadaXMotor1*Xa-8.0f*Ya*Mathf.Pow(CoordenadaYMotor1,3)*CoordenadaXMotor1*Xa+8.0f*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaXMotor1,3)
		                                                                              *Xa-Mathf.Pow(Xa,6)-Mathf.Pow(CoordenadaXMotor1,6)-4.0f*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)*Ya*Mathf.Pow(CoordenadaXMotor1,2)-4.0f*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)
		                                                                              *Mathf.Pow(Xa,2)*Ya-4.0f*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon1,2)*CoordenadaXMotor1*Xa+12.0f*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaYMotor1,2)*
		                                                                              CoordenadaXMotor1*Xa-8.0f*Mathf.Pow(Ya,3)*CoordenadaYMotor1*CoordenadaXMotor1*Xa-4.0f*Mathf.Pow(CoordenadaXMotor1,2)*CoordenadaYMotor1*Ya*Mathf.Pow(LongitudEslabon2,2)
		                                                                              +24.0f*Mathf.Pow(CoordenadaXMotor1,2)*CoordenadaYMotor1*Mathf.Pow(Xa,2)*Ya-16.0f*Mathf.Pow(CoordenadaXMotor1,3)*CoordenadaYMotor1*Xa*Ya-Mathf.Pow(Ya,4)*Mathf.Pow(CoordenadaXMotor1,2)
		                                                                              -Mathf.Pow(Ya,4)*Mathf.Pow(Xa,2)-2.0f*Mathf.Pow(CoordenadaXMotor1,4)*Mathf.Pow(CoordenadaYMotor1,2)-Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,4)-2.0f*Mathf.Pow(Ya,2)
		                                                                              *Mathf.Pow(CoordenadaXMotor1,4)-Mathf.Pow(Xa,2)*Mathf.Pow(CoordenadaYMotor1,4)+6.0f*CoordenadaXMotor1*Mathf.Pow(Xa,5)+6.0f*Mathf.Pow(CoordenadaXMotor1,5)*Xa+20.0f*Mathf.Pow(CoordenadaXMotor1,3)
		                                                                              *Mathf.Pow(Xa,3)-15.0f*Mathf.Pow(CoordenadaXMotor1,4)*Mathf.Pow(Xa,2)-Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon2,4)-Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon1,4)-Mathf.Pow(CoordenadaXMotor1,2)
		                                                                              *Mathf.Pow(LongitudEslabon2,4)-Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(LongitudEslabon1,4)+2.0f*Mathf.Pow(CoordenadaXMotor1,4)*Mathf.Pow(LongitudEslabon2,2)+2.0f*Mathf.Pow(CoordenadaXMotor1,4)
		                                                                              *Mathf.Pow(LongitudEslabon1,2)+2.0f*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(CoordenadaXMotor1,2)+2.0f*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon1,2)
		                                                                              *Mathf.Pow(Xa,2)-6.0f*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(CoordenadaXMotor1,2)+4.0f*Mathf.Pow(Ya,3)*CoordenadaYMotor1*Mathf.Pow(CoordenadaXMotor1,2)+4.0f*Mathf.Pow(Ya,3)*
		                                                                              CoordenadaYMotor1*Mathf.Pow(Xa,2)-6.0f*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(Xa,2)+2.0f*Mathf.Pow(Ya,4)*CoordenadaXMotor1*Xa+4.0f*Mathf.Pow(CoordenadaXMotor1,4)*CoordenadaYMotor1*
		                                                                              Ya+2.0f*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon2,2)+4.0f*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,3)*Ya+8.0f
		                                                                              *Mathf.Pow(CoordenadaXMotor1,3)*Mathf.Pow(CoordenadaYMotor1,2)*Xa-12.0f*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(Xa,2)+2.0f*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon2,2)*
		                                                                              Mathf.Pow(CoordenadaXMotor1,2)+2.0f*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(Xa,2)+2.0f*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(CoordenadaXMotor1,2)+2.0f*
		                                                                              Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(Xa,2)-12.0f*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(Xa,2)+2.0f*Mathf.Pow(LongitudEslabon2,2)*
		                                                                              Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(Xa,2)+4.0f*Ya*Mathf.Pow(CoordenadaYMotor1,3)*Mathf.Pow(Xa,2)+4.0f*Mathf.Pow(Xa,4)*Ya*CoordenadaYMotor1+8.0f*Mathf.Pow(Xa,3)*Mathf.Pow(Ya,2)*
		                                                                              CoordenadaXMotor1+8.0f*CoordenadaXMotor1*Mathf.Pow(Xa,3)*Mathf.Pow(CoordenadaYMotor1,2)+2.0f*CoordenadaXMotor1*Xa*Mathf.Pow(CoordenadaYMotor1,4)-8.0f*CoordenadaXMotor1*Mathf.Pow(Xa,3)*Mathf.Pow(LongitudEslabon1,2)
		                                                                              -8.0f*Mathf.Pow(CoordenadaXMotor1,3)*Xa*Mathf.Pow(LongitudEslabon2,2)-8.0f*Mathf.Pow(CoordenadaXMotor1,3)*Xa*Mathf.Pow(LongitudEslabon1,2))))*CoordenadaYMotor1-1.0f/
(-8.0f*CoordenadaXMotor1*Xa-8.0f*Ya*CoordenadaYMotor1+4.0f*Mathf.Pow(Ya,2)+4.0f*Mathf.Pow(CoordenadaYMotor1,2)+4.0f*Mathf.Pow(Xa,2)+4.0f*Mathf.Pow(CoordenadaXMotor1,2))*
		                   (-4.0f*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)-4.0f*Mathf.Pow(Ya,2)*CoordenadaYMotor1+4.0f*Mathf.Pow(Ya,3)+4.0f*Mathf.Pow(CoordenadaXMotor1,2)*CoordenadaYMotor1-4.0f*Ya*Mathf.Pow(LongitudEslabon2,2)+
		 4.0f*Ya*Mathf.Pow(LongitudEslabon1,2)+4.0f*Ya*Mathf.Pow(CoordenadaXMotor1,2)+4.0f*Mathf.Pow(LongitudEslabon2,2)*CoordenadaYMotor1-4.0f*Ya*Mathf.Pow(CoordenadaYMotor1,2)+4.0f*Mathf.Pow(Xa,2)*
		 Ya-8.0f*CoordenadaXMotor1*Xa*CoordenadaYMotor1+4.0f*Mathf.Pow(Xa,2)*CoordenadaYMotor1-8.0f*CoordenadaXMotor1*Xa*Ya+4.0f*Mathf.Pow(CoordenadaYMotor1,3)+4.0f*(Mathf.Sqrt(-2*Mathf.Pow(Xa,4)
        *Mathf.Pow(CoordenadaYMotor1,2)+2.0f*CoordenadaXMotor1*Xa*Mathf.Pow(LongitudEslabon2,4)+2.0f*Mathf.Pow(Xa,4)*Mathf.Pow(LongitudEslabon2,2)+12.0f*Mathf.Pow(CoordenadaXMotor1,2)*
        Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon1,2)+2.0f*Mathf.Pow(Xa,4)*Mathf.Pow(LongitudEslabon1,2)-15.0f*Mathf.Pow(Xa,4)*Mathf.Pow(CoordenadaXMotor1,2)-2.0f*Mathf.Pow(Xa,4)*
        Mathf.Pow(Ya,2)+12.0f*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon2,2)-8.0f*CoordenadaXMotor1*Mathf.Pow(Xa,3)*Mathf.Pow(LongitudEslabon2,2)+
        2.0f*CoordenadaXMotor1*Xa*Mathf.Pow(LongitudEslabon1,4)+2.0f*Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(LongitudEslabon1,2)+2.0f*Mathf.Pow(CoordenadaXMotor1,2)
        *Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(LongitudEslabon1,2)-16.0f*Mathf.Pow(Xa,3)*Ya*CoordenadaXMotor1*CoordenadaYMotor1-4.0f*CoordenadaXMotor1*Xa*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(LongitudEslabon1,2)
        +8.0f*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)*CoordenadaXMotor1*Xa*Ya-4.0f*Ya*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(Xa,2)*CoordenadaYMotor1+8.0f*Ya*Mathf.Pow(LongitudEslabon2,2)
        *CoordenadaXMotor1*Xa*CoordenadaYMotor1-4.0f*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon2,2)*CoordenadaXMotor1*Xa-4.0f*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon1,2)*CoordenadaXMotor1*Xa
        -4.0f*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(CoordenadaYMotor1,2)*CoordenadaXMotor1*Xa-8.0f*Ya*Mathf.Pow(CoordenadaYMotor1,3)*CoordenadaXMotor1*Xa+8.0f*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaXMotor1,3)*
        Xa-Mathf.Pow(Xa,6)-Mathf.Pow(CoordenadaXMotor1,6)-4.0f*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)*Ya*Mathf.Pow(CoordenadaXMotor1,2)-4.0f*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)*
        Mathf.Pow(Xa,2)*Ya-4.0f*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon1,2)*CoordenadaXMotor1*Xa+12.0f*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaYMotor1,2)*CoordenadaXMotor1*Xa-8.0f*
        Mathf.Pow(Ya,3)*CoordenadaYMotor1*CoordenadaXMotor1*Xa-4.0f*Mathf.Pow(CoordenadaXMotor1,2)*CoordenadaYMotor1*Ya*Mathf.Pow(LongitudEslabon2,2)+24.0f*Mathf.Pow(CoordenadaXMotor1,2)
        *CoordenadaYMotor1*Mathf.Pow(Xa,2)*Ya-16.0f*Mathf.Pow(CoordenadaXMotor1,3)*CoordenadaYMotor1*Xa*Ya-Mathf.Pow(Ya,4)*Mathf.Pow(CoordenadaXMotor1,2)-Mathf.Pow(Ya,4)*Mathf.Pow(Xa,2)
        -2.0f*Mathf.Pow(CoordenadaXMotor1,4)*Mathf.Pow(CoordenadaYMotor1,2)-Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,4)-2.0f*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaXMotor1,4)-
        Mathf.Pow(Xa,2)*Mathf.Pow(CoordenadaYMotor1,4)+6.0f*CoordenadaXMotor1*Mathf.Pow(Xa,5)+6.0f*Mathf.Pow(CoordenadaXMotor1,5)*Xa+20.0f*Mathf.Pow(CoordenadaXMotor1,3)*Mathf.Pow(Xa,3)-15.0f*
        Mathf.Pow(CoordenadaXMotor1,4)*Mathf.Pow(Xa,2)-Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon2,4)-Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon1,4)-Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(LongitudEslabon2,4)
        -Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(LongitudEslabon1,4)+2.0f*Mathf.Pow(CoordenadaXMotor1,4)*Mathf.Pow(LongitudEslabon2,2)+2.0f*Mathf.Pow(CoordenadaXMotor1,4)*Mathf.Pow(LongitudEslabon1,2)+2.0f
        *Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(CoordenadaXMotor1,2)+2.0f*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(Xa,2)-6.0f*Mathf.Pow(Ya,2)*
        Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(CoordenadaXMotor1,2)+4*Mathf.Pow(Ya,3)*CoordenadaYMotor1*Mathf.Pow(CoordenadaXMotor1,2)+4.0f*Mathf.Pow(Ya,3)*CoordenadaYMotor1*Mathf.Pow(Xa,2)-6.0f
        *Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(Xa,2)+2.0f*Mathf.Pow(Ya,4)*CoordenadaXMotor1*Xa+4.0f*Mathf.Pow(CoordenadaXMotor1,4)*CoordenadaYMotor1*Ya+2.0f*Mathf.Pow(CoordenadaXMotor1,2)
        *Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon2,2)+4.0f*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,3)*Ya+8.0f*Mathf.Pow(CoordenadaXMotor1,3)*Mathf.Pow(CoordenadaYMotor1,2)*Xa-12.0f
        *Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(Xa,2)+2.0f*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(CoordenadaXMotor1,2)+2.0f*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon2,2)*
        Mathf.Pow(Xa,2)+2.0f*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(CoordenadaXMotor1,2)+2.0f*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(Xa,2)-12.0f*Mathf.Pow(Ya,2)*
        Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(Xa,2)+2.0f*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(Xa,2)+4.0f*Ya*Mathf.Pow(CoordenadaYMotor1,3)*Mathf.Pow(Xa,2)+4.0f
        *Mathf.Pow(Xa,4)*Ya*CoordenadaYMotor1+8.0f*Mathf.Pow(Xa,3)*Mathf.Pow(Ya,2)*CoordenadaXMotor1+8.0f*CoordenadaXMotor1*Mathf.Pow(Xa,3)*Mathf.Pow(CoordenadaYMotor1,2)+2.0f*CoordenadaXMotor1*Xa*Mathf.Pow(CoordenadaYMotor1,4)-8.0f
        *CoordenadaXMotor1*Mathf.Pow(Xa,3)*Mathf.Pow(LongitudEslabon1,2)-8.0f*Mathf.Pow(CoordenadaXMotor1,3)*Xa*Mathf.Pow(LongitudEslabon2,2)-8.0f*Mathf.Pow(CoordenadaXMotor1,3)*Xa*
        Mathf.Pow(LongitudEslabon1,2))))*Ya+Mathf.Pow(Xa,2)+Mathf.Pow(Ya,2)-Mathf.Pow(LongitudEslabon2,2)-Mathf.Pow(CoordenadaXMotor1,2)-Mathf.Pow(CoordenadaYMotor1,2)+Mathf.Pow(LongitudEslabon1,2))
			/(Xa-CoordenadaXMotor1);



		//Xd[1]=1/2*(1/(-8*CoordenadaXMotor1*Xa-8*Ya*CoordenadaYMotor1+4*Mathf.Pow(Ya,2)+4*Mathf.Pow(CoordenadaYMotor1,2)+4*Mathf.Pow(Xa,2)+4*Mathf.Pow(CoordenadaXMotor1,2))*(-4*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)-4*Mathf.Pow(Ya,2)*CoordenadaYMotor1+4*Mathf.Pow(Ya,3)+4*Mathf.Pow(CoordenadaXMotor1,2)*CoordenadaYMotor1-4*Ya*Mathf.Pow(LongitudEslabon2,2)+4*Ya*Mathf.Pow(LongitudEslabon1,2)+4*Ya*Mathf.Pow(CoordenadaXMotor1,2)+4*Mathf.Pow(LongitudEslabon2,2)*CoordenadaYMotor1-4*Ya*Mathf.Pow(CoordenadaYMotor1,2)+4*Mathf.Pow(Xa,2)*Ya-8*CoordenadaXMotor1*Xa*CoordenadaYMotor1+4*Mathf.Pow(Xa,2)*CoordenadaYMotor1-8*CoordenadaXMotor1*Xa*Ya+4*Mathf.Pow(CoordenadaYMotor1,3)-4*(-2*Mathf.Pow(Xa,4)*Mathf.Pow(CoordenadaYMotor1,2)+2*CoordenadaXMotor1*Xa*Mathf.Pow(LongitudEslabon2,4)+2*Mathf.Pow(Xa,4)*Mathf.Pow(LongitudEslabon2,2)+12*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon1,2)+2*Mathf.Pow(Xa,4)*Mathf.Pow(LongitudEslabon1,2)-15*Mathf.Pow(Xa,4)*Mathf.Pow(CoordenadaXMotor1,2)-2*Mathf.Pow(Xa,4)*Mathf.Pow(Ya,2)+12*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon2,2)-8*CoordenadaXMotor1*Mathf.Pow(Xa,3)*Mathf.Pow(LongitudEslabon2,2)+2*CoordenadaXMotor1*Xa*Mathf.Pow(LongitudEslabon1,4)+2*Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(LongitudEslabon1,2)+2*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(LongitudEslabon1,2)-16*Mathf.Pow(Xa,3)*Ya*CoordenadaXMotor1*CoordenadaYMotor1-4*CoordenadaXMotor1*Xa*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(LongitudEslabon1,2)+8*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)*CoordenadaXMotor1*Xa*Ya-4*Ya*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(Xa,2)*CoordenadaYMotor1+8*Ya*Mathf.Pow(LongitudEslabon2,2)*CoordenadaXMotor1*Xa*CoordenadaYMotor1-4*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon2,2)*CoordenadaXMotor1*Xa-4*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon1,2)*CoordenadaXMotor1*Xa-4*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(CoordenadaYMotor1,2)*CoordenadaXMotor1*Xa-8*Ya*Mathf.Pow(CoordenadaYMotor1,3)*CoordenadaXMotor1*Xa+8*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaXMotor1,3)*Xa-Mathf.Pow(Xa,6)-Mathf.Pow(CoordenadaXMotor1,6)-4*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)*Ya*Mathf.Pow(CoordenadaXMotor1,2)-4*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(Xa,2)*Ya-4*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon1,2)*CoordenadaXMotor1*Xa+12*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaYMotor1,2)*CoordenadaXMotor1*Xa-8*Mathf.Pow(Ya,3)*CoordenadaYMotor1*CoordenadaXMotor1*Xa-4*Mathf.Pow(CoordenadaXMotor1,2)*CoordenadaYMotor1*Ya*Mathf.Pow(LongitudEslabon2,2)+24*Mathf.Pow(CoordenadaXMotor1,2)*CoordenadaYMotor1*Mathf.Pow(Xa,2)*Ya-16*Mathf.Pow(CoordenadaXMotor1,3)*CoordenadaYMotor1*Xa*Ya-Mathf.Pow(Ya,4)*Mathf.Pow(CoordenadaXMotor1,2)-Mathf.Pow(Ya,4)*Mathf.Pow(Xa,2)-2*Mathf.Pow(CoordenadaXMotor1,4)*Mathf.Pow(CoordenadaYMotor1,2)-Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,4)-2*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaXMotor1,4)-Mathf.Pow(Xa,2)*Mathf.Pow(CoordenadaYMotor1,4)+6*CoordenadaXMotor1*Mathf.Pow(Xa,5)+6*CoordenadaXMotor1Mathf.Pow(CoordenadaXMotor1,6)5*Xa+20*Mathf.Pow(CoordenadaXMotor1,3)*Mathf.Pow(Xa,3)-15*Mathf.Pow(CoordenadaXMotor1,4)*Mathf.Pow(Xa,2)-Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon2,4)-Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon1,4)-Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(LongitudEslabon2,4)-Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(LongitudEslabon1,4)+2*Mathf.Pow(CoordenadaXMotor1,4)*Mathf.Pow(LongitudEslabon2,2)+2*Mathf.Pow(CoordenadaXMotor1,4)*Mathf.Pow(LongitudEslabon1,2)+2*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(CoordenadaXMotor1,2)+2*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(Xa,2)-6*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(CoordenadaXMotor1,2)+4*Mathf.Pow(Ya,3)*CoordenadaYMotor1*Mathf.Pow(CoordenadaXMotor1,2)+4*Mathf.Pow(Ya,3)*CoordenadaYMotor1*Mathf.Pow(Xa,2)-6*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(Xa,2)+2*Mathf.Pow(Ya,4)*CoordenadaXMotor1*Xa+4*Mathf.Pow(CoordenadaXMotor1,4)*CoordenadaYMotor1*Ya+2*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon2,2)+4*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,3)*Ya+8*Mathf.Pow(CoordenadaXMotor1,3)*Mathf.Pow(CoordenadaYMotor1,2)*Xa-12*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(Xa,2)+2*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(CoordenadaXMotor1,2)+2*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(Xa,2)+2*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(CoordenadaXMotor1,2)+2*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(Xa,2)-12*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(Xa,2)+2*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(Xa,2)+4*Ya*Mathf.Pow(CoordenadaYMotor1,3)*Mathf.Pow(Xa,2)+4*Mathf.Pow(Xa,4)*Ya*CoordenadaYMotor1+8*Mathf.Pow(Xa,3)*Mathf.Pow(Ya,2)*CoordenadaXMotor1+8*CoordenadaXMotor1*Mathf.Pow(Xa,3)*Mathf.Pow(CoordenadaYMotor1,2)+2*CoordenadaXMotor1*Xa*Mathf.Pow(CoordenadaYMotor1,4)-8*CoordenadaXMotor1*Mathf.Pow(Xa,3)*Mathf.Pow(LongitudEslabon1,2)-8*Mathf.Pow(CoordenadaXMotor1,3)*Xa*Mathf.Pow(LongitudEslabon2,2)-8*Mathf.Pow(CoordenadaXMotor1,3)*Xa*Mathf.Pow(LongitudEslabon1,2))^(1/2))*CoordenadaYMotor1-1/(-8*CoordenadaXMotor1*Xa-8*Ya*CoordenadaYMotor1+4*Mathf.Pow(Ya,2)+4*Mathf.Pow(CoordenadaYMotor1,2)+4*Mathf.Pow(Xa,2)+4*Mathf.Pow(CoordenadaXMotor1,2))*(-4*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)-4*Mathf.Pow(Ya,2)*CoordenadaYMotor1+4*Mathf.Pow(Ya,3)+4*Mathf.Pow(CoordenadaXMotor1,2)*CoordenadaYMotor1-4*Ya*Mathf.Pow(LongitudEslabon2,2)+4*Ya*Mathf.Pow(LongitudEslabon1,2)+4*Ya*Mathf.Pow(CoordenadaXMotor1,2)+4*Mathf.Pow(LongitudEslabon2,2)*CoordenadaYMotor1-4*Ya*Mathf.Pow(CoordenadaYMotor1,2)+4*Mathf.Pow(Xa,2)*Ya-8*CoordenadaXMotor1*Xa*CoordenadaYMotor1+4*Mathf.Pow(Xa,2)*CoordenadaYMotor1-8*CoordenadaXMotor1*Xa*Ya+4*Mathf.Pow(CoordenadaYMotor1,3)-4*(-2*Mathf.Pow(Xa,4)*Mathf.Pow(CoordenadaYMotor1,2)+2*CoordenadaXMotor1*Xa*Mathf.Pow(LongitudEslabon2,4)+2*Mathf.Pow(Xa,4)*Mathf.Pow(LongitudEslabon2,2)+12*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon1,2)+2*Mathf.Pow(Xa,4)*Mathf.Pow(LongitudEslabon1,2)-15*Mathf.Pow(Xa,4)*Mathf.Pow(CoordenadaXMotor1,2)-2*Mathf.Pow(Xa,4)*Mathf.Pow(Ya,2)+12*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon2,2)-8*CoordenadaXMotor1*Mathf.Pow(Xa,3)*Mathf.Pow(LongitudEslabon2,2)+2*CoordenadaXMotor1*Xa*Mathf.Pow(LongitudEslabon1,4)+2*Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(LongitudEslabon1,2)+2*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(LongitudEslabon1,2)-16*Mathf.Pow(Xa,3)*Ya*CoordenadaXMotor1*CoordenadaYMotor1-4*CoordenadaXMotor1*Xa*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(LongitudEslabon1,2)+8*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)*CoordenadaXMotor1*Xa*Ya-4*Ya*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(Xa,2)*CoordenadaYMotor1+8*Ya*Mathf.Pow(LongitudEslabon2,2)*CoordenadaXMotor1*Xa*CoordenadaYMotor1-4*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon2,2)*CoordenadaXMotor1*Xa-4*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon1,2)*CoordenadaXMotor1*Xa-4*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(CoordenadaYMotor1,2)*CoordenadaXMotor1*Xa-8*Ya*Mathf.Pow(CoordenadaYMotor1,3)*CoordenadaXMotor1*Xa+8*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaXMotor1,3)*Xa-Mathf.Pow(Xa,6)-Mathf.Pow(CoordenadaXMotor1,6)-4*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)*Ya*Mathf.Pow(CoordenadaXMotor1,2)-4*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(Xa,2)*Ya-4*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon1,2)*CoordenadaXMotor1*Xa+12*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaYMotor1,2)*CoordenadaXMotor1*Xa-8*Mathf.Pow(Ya,3)*CoordenadaYMotor1*CoordenadaXMotor1*Xa-4*Mathf.Pow(CoordenadaXMotor1,2)*CoordenadaYMotor1*Ya*Mathf.Pow(LongitudEslabon2,2)+24*Mathf.Pow(CoordenadaXMotor1,2)*CoordenadaYMotor1*Mathf.Pow(Xa,2)*Ya-16*Mathf.Pow(CoordenadaXMotor1,3)*CoordenadaYMotor1*Xa*Ya-Mathf.Pow(Ya,4)*Mathf.Pow(CoordenadaXMotor1,2)-Mathf.Pow(Ya,4)*Mathf.Pow(Xa,2)-2*Mathf.Pow(CoordenadaXMotor1,4)*Mathf.Pow(CoordenadaYMotor1,2)-Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,4)-2*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaXMotor1,4)-Mathf.Pow(Xa,2)*Mathf.Pow(CoordenadaYMotor1,4)+6*CoordenadaXMotor1*Mathf.Pow(Xa,5)+6*Mathf.Pow(CoordenadaXMotor1,5)*Xa+20*Mathf.Pow(CoordenadaXMotor1,3)*Mathf.Pow(Xa,3)-15*Mathf.Pow(CoordenadaXMotor1,4)*Mathf.Pow(Xa,2)-Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon2,4)-Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon1,4)-Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(LongitudEslabon2,4)-Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(LongitudEslabon1,4)+2*Mathf.Pow(CoordenadaXMotor1,4)*Mathf.Pow(LongitudEslabon2,2)+2*Mathf.Pow(CoordenadaXMotor1,4)*Mathf.Pow(LongitudEslabon1,2)+2*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(CoordenadaXMotor1,2)+2*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(Xa,2)-6*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(CoordenadaXMotor1,2)+4*Mathf.Pow(Ya,3)*CoordenadaYMotor1*Mathf.Pow(CoordenadaXMotor1,2)+4*Mathf.Pow(Ya,3)*CoordenadaYMotor1*Mathf.Pow(Xa,2)-6*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(Xa,2)+2*Mathf.Pow(Ya,4)*CoordenadaXMotor1*Xa+4*Mathf.Pow(CoordenadaXMotor1,4)*CoordenadaYMotor1*Ya+2*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon2,2)+4*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,3)*Ya+8*Mathf.Pow(CoordenadaXMotor1,3)*Mathf.Pow(CoordenadaYMotor1,2)*Xa-12*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(Xa,2)+2*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(CoordenadaXMotor1,2)+2*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(Xa,2)+2*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(CoordenadaXMotor1,2)+2*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(Xa,2)-12*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(Xa,2)+2*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(Xa,2)+4*Ya*Mathf.Pow(CoordenadaYMotor1,3)*Mathf.Pow(Xa,2)+4*Mathf.Pow(Xa,4)*Ya*CoordenadaYMotor1+8*Mathf.Pow(Xa,3)*Mathf.Pow(Ya,2)*CoordenadaXMotor1+8*CoordenadaXMotor1*Mathf.Pow(Xa,3)*Mathf.Pow(CoordenadaYMotor1,2)+2*CoordenadaXMotor1*Xa*Mathf.Pow(CoordenadaYMotor1,4)-8*CoordenadaXMotor1*Mathf.Pow(Xa,3)*Mathf.Pow(LongitudEslabon1,2)-8*Mathf.Pow(CoordenadaXMotor1,3)*Xa*Mathf.Pow(LongitudEslabon2,2)-8*Mathf.Pow(CoordenadaXMotor1,3)*Xa*Mathf.Pow(LongitudEslabon1,2))^(1/2))*Ya+Mathf.Pow(Xa,2)+Mathf.Pow(Ya,2)-Mathf.Pow(LongitudEslabon2,2)-Mathf.Pow(CoordenadaXMotor1,2)-Mathf.Pow(CoordenadaYMotor1,2)+Mathf.Pow(LongitudEslabon1,2))/(Xa-CoordenadaXMotor1);

		Yd [0] = (1.0f / 2.0f) / (-8.0f * CoordenadaXMotor1 * Xa - 8.0f * Ya * CoordenadaYMotor1 + 4.0f * Mathf.Pow (Ya, 2) + 4.0f * Mathf.Pow (CoordenadaYMotor1, 2) + 4.0f * Mathf.Pow (Xa, 2) + 4.0f * Mathf.Pow (CoordenadaXMotor1, 2)) *
			(-4*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)-4*Mathf.Pow(Ya,2)*CoordenadaYMotor1+4*Mathf.Pow(Ya,3)+4*Mathf.Pow(CoordenadaXMotor1,2)*CoordenadaYMotor1-4*Ya*
			 Mathf.Pow(LongitudEslabon2,2)+4.0f*Ya*Mathf.Pow(LongitudEslabon1,2)+4.0f*Ya*Mathf.Pow(CoordenadaXMotor1,2)+4.0f*Mathf.Pow(LongitudEslabon2,2)*CoordenadaYMotor1-4.0f*Ya*
			 Mathf.Pow(CoordenadaYMotor1,2)+4.0f*Mathf.Pow(Xa,2)*Ya-8.0f*CoordenadaXMotor1*Xa*CoordenadaYMotor1+4.0f*Mathf.Pow(Xa,2)*CoordenadaYMotor1-8.0f*CoordenadaXMotor1*Xa*Ya+4.0f*
			 Mathf.Pow(CoordenadaYMotor1,3)+4.0f*(Mathf.Sqrt(-2.0f*Mathf.Pow(Xa,4)*Mathf.Pow(CoordenadaYMotor1,2)+2.0f*CoordenadaXMotor1*Xa*Mathf.Pow(LongitudEslabon2,4)+2.0f*Mathf.Pow(Xa,4)*
			                                                Mathf.Pow(LongitudEslabon2,2)+12.0f*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon1,2)+2.0f*Mathf.Pow(Xa,4)*
			                                                Mathf.Pow(LongitudEslabon1,2)-15.0f*Mathf.Pow(Xa,4)*Mathf.Pow(CoordenadaXMotor1,2)-2.0f*Mathf.Pow(Xa,4)*Mathf.Pow(Ya,2)+12.0f*
			                                                Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon2,2)-8.0f*CoordenadaXMotor1*Mathf.Pow(Xa,3)*
			                                                Mathf.Pow(LongitudEslabon2,2)+2.0f*CoordenadaXMotor1*Xa*Mathf.Pow(LongitudEslabon1,4)+2.0f*Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon2,2)*
			                                                Mathf.Pow(LongitudEslabon1,2)+2.0f*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(LongitudEslabon1,2)-16.0f*
			                                                Mathf.Pow(Xa,3)*Ya*CoordenadaXMotor1*CoordenadaYMotor1-4.0f*CoordenadaXMotor1*Xa*Mathf.Pow(LongitudEslabon2,2)*
			                                                Mathf.Pow(LongitudEslabon1,2)+8.0f*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)*CoordenadaXMotor1*Xa*Ya-4.0f*Ya*
			                                                Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(Xa,2)*CoordenadaYMotor1+8.0f*Ya*Mathf.Pow(LongitudEslabon2,2)*CoordenadaXMotor1*Xa*
			                                                CoordenadaYMotor1-4.0f*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon2,2)*CoordenadaXMotor1*Xa-4.0f*Mathf.Pow(Ya,2)*
			                                                Mathf.Pow(LongitudEslabon1,2)*CoordenadaXMotor1*Xa-4.0f*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(CoordenadaYMotor1,2)*CoordenadaXMotor1*Xa
			                                                -8.0f*Ya*Mathf.Pow(CoordenadaYMotor1,3)*CoordenadaXMotor1*Xa+8.0f*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaXMotor1,3)*Xa-Mathf.Pow(Xa,6)-
			                                                Mathf.Pow(CoordenadaXMotor1,6)-4.0f*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)*Ya*Mathf.Pow(CoordenadaXMotor1,2)-4.0f*
			                                                CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(Xa,2)*Ya-4.0f*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon1,2)*
			                                                CoordenadaXMotor1*Xa+12.0f*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaYMotor1,2)*CoordenadaXMotor1*Xa-8.0f*Mathf.Pow(Ya,3)*CoordenadaYMotor1*
			                                                CoordenadaXMotor1*Xa-4.0f*Mathf.Pow(CoordenadaXMotor1,2)*CoordenadaYMotor1*Ya*Mathf.Pow(LongitudEslabon2,2)+24.0f*
			                                                Mathf.Pow(CoordenadaXMotor1,2)*CoordenadaYMotor1*Mathf.Pow(Xa,2)*Ya-16.0f*Mathf.Pow(CoordenadaXMotor1,3)*CoordenadaYMotor1*Xa*
			                                                Ya-Mathf.Pow(Ya,4)*Mathf.Pow(CoordenadaXMotor1,2)-Mathf.Pow(Ya,4)*Mathf.Pow(Xa,2)-2.0f*Mathf.Pow(CoordenadaXMotor1,4)*
			                                                Mathf.Pow(CoordenadaYMotor1,2)-Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,4)-2.0f*Mathf.Pow(Ya,2)*
			                                                Mathf.Pow(CoordenadaXMotor1,4)-Mathf.Pow(Xa,2)*Mathf.Pow(CoordenadaYMotor1,4)+6.0f*CoordenadaXMotor1*Mathf.Pow(Xa,5)+6.0f*
			                                                Mathf.Pow(CoordenadaXMotor1,5)*Xa+20.0f*Mathf.Pow(CoordenadaXMotor1,3)*Mathf.Pow(Xa,3)-15.0f*Mathf.Pow(CoordenadaXMotor1,4)*
			                                             Mathf.Pow(Xa,2)-Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon2,4)-Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon1,4)-
			                                                Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(LongitudEslabon2,4)-Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(LongitudEslabon1,4)+2.0f*
			                                                Mathf.Pow(CoordenadaXMotor1,4)*Mathf.Pow(LongitudEslabon2,2)+2.0f*Mathf.Pow(CoordenadaXMotor1,4)*Mathf.Pow(LongitudEslabon1,2)+2.0f*
			                                                Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(CoordenadaXMotor1,2)+2.0f*Mathf.Pow(CoordenadaYMotor1,2)*
			                                                Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(Xa,2)-6.0f*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(CoordenadaXMotor1,2)+4.0f*
			                                                Mathf.Pow(Ya,3)*CoordenadaYMotor1*Mathf.Pow(CoordenadaXMotor1,2)+4.0f*Mathf.Pow(Ya,3)*CoordenadaYMotor1*Mathf.Pow(Xa,2)-6.0f*
			                                                Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(Xa,2)+2.0f*Mathf.Pow(Ya,4)*CoordenadaXMotor1*Xa+4.0f*
			                                                Mathf.Pow(CoordenadaXMotor1,4)*CoordenadaYMotor1*Ya+2.0f*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,2)*
			                                                Mathf.Pow(LongitudEslabon2,2)+4.0f*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,3)*Ya+8.0f*Mathf.Pow(CoordenadaXMotor1,3)*
			                                                Mathf.Pow(CoordenadaYMotor1,2)*Xa-12.0f*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(Xa,2)+2.0f*
			                                                Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(CoordenadaXMotor1,2)+2.0f*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon2,2)*
			                                                Mathf.Pow(Xa,2)+2.0f*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(CoordenadaXMotor1,2)+2.0f*Mathf.Pow(Ya,2)*
			                                                Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(Xa,2)-12.0f*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(Xa,2)+2.0f*
			                                                Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(Xa,2)+4.0f*Ya*Mathf.Pow(CoordenadaYMotor1,3)*Mathf.Pow(Xa,2)+4.0f*
			                                                Mathf.Pow(Xa,4)*Ya*CoordenadaYMotor1+8.0f*Mathf.Pow(Xa,3)*Mathf.Pow(Ya,2)*CoordenadaXMotor1+8.0f*CoordenadaXMotor1*Mathf.Pow(Xa,3)*
			                                                Mathf.Pow(CoordenadaYMotor1,2)+2.0f*CoordenadaXMotor1*Xa*Mathf.Pow(CoordenadaYMotor1,4)-8.0f*CoordenadaXMotor1*Mathf.Pow(Xa,3)*
			                                                Mathf.Pow(LongitudEslabon1,2)-8.0f*Mathf.Pow(CoordenadaXMotor1,3)*Xa*Mathf.Pow(LongitudEslabon2,2)-8.0f*Mathf.Pow(CoordenadaXMotor1,3)*Xa*
			                                             Mathf.Pow(LongitudEslabon1,2))));

	


	


		Yd[1]=(1.0f/2.0f)/(-8.0f*CoordenadaXMotor1*Xa-8.0f*Ya*CoordenadaYMotor1+4.0f*Mathf.Pow(Ya,2)+4.0f*Mathf.Pow(CoordenadaYMotor1,2)+4.0f*Mathf.Pow(Xa,2)+4.0f
		                   *Mathf.Pow(CoordenadaXMotor1,2))*(-4.0f*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)-4.0f*Mathf.Pow(Ya,2)*CoordenadaYMotor1+4.0f*Mathf.Pow(Ya,3)+
		                                  4.0f*Mathf.Pow(CoordenadaXMotor1,2)*CoordenadaYMotor1-4.0f*Ya*Mathf.Pow(LongitudEslabon2,2)+4.0f*Ya*Mathf.Pow(LongitudEslabon1,2)+4.0f
		                                  *Ya*Mathf.Pow(CoordenadaXMotor1,2)+4.0f*Mathf.Pow(LongitudEslabon2,2)*CoordenadaYMotor1-4.0f*Ya*Mathf.Pow(CoordenadaYMotor1,2)+4.0f
		                                  *Mathf.Pow(Xa,2)*Ya-8.0f*CoordenadaXMotor1*Xa*CoordenadaYMotor1+4.0f*Mathf.Pow(Xa,2)*CoordenadaYMotor1-8.0f*CoordenadaXMotor1*Xa*Ya+4.0f
		                                  *Mathf.Pow(CoordenadaYMotor1,3)-4.0f*(Mathf.Sqrt(-2*Mathf.Pow(Xa,4)*Mathf.Pow(CoordenadaYMotor1,2)+2.0f*CoordenadaXMotor1*Xa*Mathf.Pow(LongitudEslabon2,4)
		                                                 +2.0f*Mathf.Pow(Xa,4)*Mathf.Pow(LongitudEslabon2,2)+12.0f*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon1,2)
		                                                 +2.0f*Mathf.Pow(Xa,4)*Mathf.Pow(LongitudEslabon1,2)-15.0f*Mathf.Pow(Xa,4)*Mathf.Pow(CoordenadaXMotor1,2)-2.0f*Mathf.Pow(Xa,4)
		                                                 *Mathf.Pow(Ya,2)+12.0f*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon2,2)-8.0f*CoordenadaXMotor1*
		                                                 Mathf.Pow(Xa,3)*Mathf.Pow(LongitudEslabon2,2)+2.0f*CoordenadaXMotor1*Xa*Mathf.Pow(LongitudEslabon1,4)+2.0f*Mathf.Pow(Xa,2)
		                                                 *Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(LongitudEslabon1,2)+2.0f*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(LongitudEslabon2,2)
		                                                 *Mathf.Pow(LongitudEslabon1,2)-16.0f*Mathf.Pow(Xa,3)*Ya*CoordenadaXMotor1*CoordenadaYMotor1-4.0f*CoordenadaXMotor1*Xa*Mathf.Pow(LongitudEslabon2,2)
		                                                 *Mathf.Pow(LongitudEslabon1,2)+8.0f*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)*CoordenadaXMotor1*Xa*Ya-4.0f*Ya*Mathf.Pow(LongitudEslabon2,2)
		                                                 *Mathf.Pow(Xa,2)*CoordenadaYMotor1+8.0f*Ya*Mathf.Pow(LongitudEslabon2,2)*CoordenadaXMotor1*Xa*CoordenadaYMotor1-4.0f*Mathf.Pow(Ya,2)
		                                                 *Mathf.Pow(LongitudEslabon2,2)*CoordenadaXMotor1*Xa-4.0f*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon1,2)*CoordenadaXMotor1*Xa-4.0f
		                                                 *Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(CoordenadaYMotor1,2)*CoordenadaXMotor1*Xa-8.0f*Ya*Mathf.Pow(CoordenadaYMotor1,3)
		                                                 *CoordenadaXMotor1*Xa+8.0f*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaXMotor1,3)*Xa-Mathf.Pow(Xa,6)-Mathf.Pow(CoordenadaXMotor1,6)-4.0f
		                                                 *CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)*Ya*Mathf.Pow(CoordenadaXMotor1,2)-4.0f*CoordenadaYMotor1*Mathf.Pow(LongitudEslabon1,2)
		                                                 *Mathf.Pow(Xa,2)*Ya-4.0f*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon1,2)*CoordenadaXMotor1*Xa+12.0f*Mathf.Pow(Ya,2)
		                                                 *Mathf.Pow(CoordenadaYMotor1,2)*CoordenadaXMotor1*Xa-8.0f*Mathf.Pow(Ya,3)*CoordenadaYMotor1*CoordenadaXMotor1*Xa-4.0f*Mathf.Pow(CoordenadaXMotor1,2)
		                                                 *CoordenadaYMotor1*Ya*Mathf.Pow(LongitudEslabon2,2)+24.0f*Mathf.Pow(CoordenadaXMotor1,2)*CoordenadaYMotor1*Mathf.Pow(Xa,2)*Ya-16.0f
		                                                 *Mathf.Pow(CoordenadaXMotor1,3)*CoordenadaYMotor1*Xa*Ya-Mathf.Pow(Ya,4)*Mathf.Pow(CoordenadaXMotor1,2)-Mathf.Pow(Ya,4)*Mathf.Pow(Xa,2)
		                                                 -2.0f*Mathf.Pow(CoordenadaXMotor1,4)*Mathf.Pow(CoordenadaYMotor1,2)-Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,4)-2.0f
		                                                 *Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaXMotor1,4)-Mathf.Pow(Xa,2)*Mathf.Pow(CoordenadaYMotor1,4)+6.0f*CoordenadaXMotor1*Mathf.Pow(Xa,5)+
		                                                 6.0f*Mathf.Pow(CoordenadaXMotor1,5)*Xa+20.0f*Mathf.Pow(CoordenadaXMotor1,3)*Mathf.Pow(Xa,3)-15.0f*Mathf.Pow(CoordenadaXMotor1,4)
		                                                 *Mathf.Pow(Xa,2)-Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon2,4)-Mathf.Pow(Xa,2)*Mathf.Pow(LongitudEslabon1,4)-Mathf.Pow(CoordenadaXMotor1,2)*
		                                                 Mathf.Pow(LongitudEslabon2,4)-Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(LongitudEslabon1,4)+2.0f*Mathf.Pow(CoordenadaXMotor1,4)
		                                                 *Mathf.Pow(LongitudEslabon2,2)+2.0f*Mathf.Pow(CoordenadaXMotor1,4)*Mathf.Pow(LongitudEslabon1,2)+2.0f*Mathf.Pow(CoordenadaYMotor1,2)*
		                                                 Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(CoordenadaXMotor1,2)+2.0f*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon1,2)
		                                                 *Mathf.Pow(Xa,2)-6.0f*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(CoordenadaXMotor1,2)+4.0f*Mathf.Pow(Ya,3)
		                                                 *CoordenadaYMotor1*Mathf.Pow(CoordenadaXMotor1,2)+4.0f*Mathf.Pow(Ya,3)*CoordenadaYMotor1*Mathf.Pow(Xa,2)-6.0f*Mathf.Pow(Ya,2)
		                                                 *Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(Xa,2)+2.0f*Mathf.Pow(Ya,4)*CoordenadaXMotor1*Xa+4.0f*Mathf.Pow(CoordenadaXMotor1,4)
		                                                 *CoordenadaYMotor1*Ya+2.0f*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(LongitudEslabon2,2)+4.0f
		                                                 *Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,3)*Ya+8.0f*Mathf.Pow(CoordenadaXMotor1,3)*Mathf.Pow(CoordenadaYMotor1,2)
		                                                 *Xa-12.0f*Mathf.Pow(CoordenadaXMotor1,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(Xa,2)+2*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon2,2)
		                                                 *Mathf.Pow(CoordenadaXMotor1,2)+2.0f*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(Xa,2)+2.0f*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon1,2)
		                                                 *Mathf.Pow(CoordenadaXMotor1,2)+2.0f*Mathf.Pow(Ya,2)*Mathf.Pow(LongitudEslabon1,2)*Mathf.Pow(Xa,2)-12.0f*Mathf.Pow(Ya,2)*Mathf.Pow(CoordenadaXMotor1,2)
		                                                 *Mathf.Pow(Xa,2)+2.0f*Mathf.Pow(LongitudEslabon2,2)*Mathf.Pow(CoordenadaYMotor1,2)*Mathf.Pow(Xa,2)+4.0f*Ya*Mathf.Pow(CoordenadaYMotor1,3)
		                                                 *Mathf.Pow(Xa,2)+4.0f*Mathf.Pow(Xa,4)*Ya*CoordenadaYMotor1+8.0f*Mathf.Pow(Xa,3)*Mathf.Pow(Ya,2)*CoordenadaXMotor1+8.0f*CoordenadaXMotor1*
		                                                 Mathf.Pow(Xa,3)*Mathf.Pow(CoordenadaYMotor1,2)+2.0f*CoordenadaXMotor1*Xa*Mathf.Pow(CoordenadaYMotor1,4)-8.0f*CoordenadaXMotor1*Mathf.Pow(Xa,3)
		                                                 *Mathf.Pow(LongitudEslabon1,2)-8.0f*Mathf.Pow(CoordenadaXMotor1,3)*Xa*Mathf.Pow(LongitudEslabon2,2)-8.0f*Mathf.Pow(CoordenadaXMotor1,3)
		                                                 *Xa*Mathf.Pow(LongitudEslabon1,2))));

		Debug.Log ("Xd[0]: "+Xd[0].ToString());

		Debug.Log ("Yd[0]: "+Yd[0].ToString());
		Debug.Log ("Yd[1]: "+Yd[1].ToString());

	}
}
