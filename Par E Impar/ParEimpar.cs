}/*
 * Created by SharpDevelop.
 * User: Alumno
 * Date: 14/11/2022
 * Time: 10:32 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CONSICONDBOLE
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			/*eSCRIBIR UN PROGRAMA QUE PIDA AL USUARIO UN NUMERO ENTERO Y MUESTRE POR PANTALL SI ES PAR O IMPAR*/
			int num;
			
			
			Console.WriteLine("Ingresa un numero");
			num = int.Parse(Console.ReadLine());
			
			if(num% 2 == 0){
				Console.WriteLine("Par");
			}
			else{
				Console.WriteLine("Impar");
			}
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}