/*
 * Created by SharpDevelop.
 * User: danie
 * Date: 11/9/2024
 * Time: 10:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace Ejercicio2
{
	/// <summary>
	/// Description of Grilla_materias.
	/// </summary>
	public class Grilla_materias
	{
		private ArrayList grilla_Mat=new ArrayList();
		
		public Grilla_materias(ArrayList x)
		{
			grilla_Mat=x;
			
		}
		public ArrayList Grilla_Mat{
			set{grilla_Mat=value;}
			get{return grilla_Mat;}
		}
		
		public ArrayList oferta_Materias(ArrayList m){
		Horario fundamentos=new Horario("jueves","19.00","fundamentos");
		Horario fisica=new Horario("lunes","12.00","fisica");
		Horario fisica2=new Horario("viernes","14.00","fisica2");
		Horario quimica=new Horario("martes","10.00","quimica");
		Horario mate3=new Horario("lunes","8.00","mate3");
		x.Add(fundamentos);
		x.Add(fisica);
		x.Add(fisica2);
		x.Add(quimica);
		x.Add(mate3);
		return x;
		}
		

	}
}
