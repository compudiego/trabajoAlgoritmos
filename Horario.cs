/*
 * Created by SharpDevelop.
 * User: danie
 * Date: 10/9/2024
 * Time: 10:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace Ejercicio2
{
	/// <summary>
	/// Description of Horario.
	/// </summary>
	public class Horario
	{
		private string dia,hora,materia;
		public Horario(string d,string h,string mat)
		{   
			dia = d;
			hora = h;           //constructor
			materia = mat;
					}
		public string Dia{
			set{
				dia = value;
			}
			get{
				return dia;
			}
		}                         //metodos de acceso
		public string Hora{
			set{hora=value;}
			get{return hora;}
		}
		public string Materia{
			set{materia=value;}
			get{return materia;}
		}
		public static void buscarMateria(ArrayList x_Lista){ //metodo static buscar materia
			Horario mate=new Horario("","","");
			Console.WriteLine("Materia: ");
			mate.Materia=Console.ReadLine();
			foreach(Horario a in x_Lista){
				if(a.Materia==mate.Materia){
					Console.WriteLine(mate.Materia+" se cursa los "+a.Dia+" a las "+a.Hora);
				}
			}
		}
		public override string ToString()
		{
			return string.Format("{0},{1},{2}",materia, dia, hora);
		}

		
	
	}
}
