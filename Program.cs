
using System;
using System.Collections;
namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{   
			ArrayList ListaHorMat=new ArrayList();
			ArrayList listaAlumnos=new ArrayList();
			ArrayList listaAlumnos2=new ArrayList();
			Alumno A=new Alumno("",0);
			Grilla_materias GM=new Grilla_materias(ListaHorMat);
			GM.oferta_Materias(ListaHorMat);    //grilla materias en lista
			//foreach(Horario i in ListaHorMat){
				//Console.WriteLine(i);
				//}
			int op=0;
			while(op!=4){
				Console.WriteLine("\nIngrese opción:\n1-cargar alumno\n2-cargar materias alumno\n3-ver materias alumno\n4-salir\n");				                 
				op=int.Parse(Console.ReadLine());
			
				switch(op){
							case 1:
								A.cargarAlumno(listaAlumnos);
								break;
							case 2:
								Console.WriteLine("----------------------");
								Console.WriteLine("Oferta horario de materias");
								Console.WriteLine("----------------------");					
								foreach(Horario i in ListaHorMat){
									Console.WriteLine(i);
								}
								Console.WriteLine("----------------------");
								listaAlumnos2=A.cargarMaterias(ListaHorMat,listaAlumnos);
								break;
							case 3:
								A.verAlumno(listaAlumnos2);
								break;
							case 4:
								break;
							default:
								Console.WriteLine("Ingrese dato correcto\n");
								break;
			}
			}
				
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
			  				
	}
		
}
