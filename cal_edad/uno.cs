/*
 * Created by SharpDevelop.
 * User: 52999
 * Date: 07/11/2022
 * Time: 10:09 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace cal_edad{
	class Program{
		public static void Main(string[] args){
			int edad, a_nac, a_actu;

			Console.WriteLine("ingresa el año actual");
			a_actu=int.Parse( Console.ReadLine());

			Console.WriteLine("ingresa el año de nacimiento");
			a_nac = int.Parse(Console.ReadLine());
			edad= a_actu-a_nac;

			Console.WriteLine("la edad es "+edad);
			Console.ReadKey();
		}
	}
}