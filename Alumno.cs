
using System;
using System.Collections;
namespace Ejercicio2
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno
	{
		private string nomyapel;
		private int dni;
		private ArrayList susHorarios;
		
		public Alumno(string nya,int dni)
				{
			nomyapel=nya;
			this.dni=dni;
			susHorarios=new ArrayList();
				
		}
		public string Nomyapel{
			get{return nomyapel;}
			set{nomyapel=value;}
		}
		public int Dni{
			get{return dni;}
			set{dni=value;}
		}
		
		public ArrayList SusHorarios{
			set{susHorarios=value;}
			get{return susHorarios;}//sólo lectura
		}
		public override string ToString()
			
		{
			return string.Format("{0},{1},{2}",nomyapel,dni,susHorarios);
			
		}
		 
		

		public ArrayList cargarAlumno(ArrayList listaAlumnos){
			Alumno Pepe=new Alumno("",0);              //ALUMNO LISTA MATERIAS
			int dni;
			string nom_apel;
			Console.WriteLine("Ingrese apellido y nombre: ");
			nom_apel=Console.ReadLine();        //CARGA PRIMER ALUMNO
			Console.WriteLine("DNI: ");
			
			while(nom_apel!=""){
				dni=int.Parse(Console.ReadLine());
				Pepe=new Alumno(nom_apel,dni);
				listaAlumnos.Add(Pepe);
				Console.WriteLine("Ingrese apellido y nombre: ");
				nom_apel=Console.ReadLine(); 
				Console.WriteLine("DNI: ");
							}
			return listaAlumnos;
				}
		public ArrayList cargarMaterias(ArrayList x,ArrayList y){
			Alumno A=new Alumno("",0);
			ArrayList intermedia=new ArrayList();
			Console.WriteLine("\nCARGAR MATERIAS A ALUMNO");
			Console.WriteLine("Ingrese materia: ");
			string mat=Console.ReadLine();
			while(mat!=""){
				foreach(Horario i in x){
					if(mat==i.Materia){
						intermedia.Add(i);
				}
			}
			 	Console.WriteLine("\nIngrese materia: ");
				mat=Console.ReadLine();
				}
			Console.WriteLine("Ingrese dni alumno: ");
  			int doc=int.Parse(Console.ReadLine());
			foreach(Alumno j in y){
  				if(doc==j.Dni){
  					j.SusHorarios=intermedia;
  				}
  			}
  				
  				return y;
				
			}
		public void verAlumno(ArrayList x){
			Console.WriteLine("Materias a cursar por el alumno");
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Ingrese dni: ");
			int dni=int.Parse(Console.ReadLine());
			foreach(Alumno i in x){
				if(dni==i.Dni){
					Console.WriteLine("-------------------");
					Console.WriteLine("El alumno {0}, dni: {1}",i.Nomyapel,i.dni+" está inscripto en las siguientes materias:\n");
					foreach(Horario k in i.SusHorarios){
						Console.WriteLine(k);
					}
									}
			}
		}
		

		
			
	}
		
}
		

			
	
	
