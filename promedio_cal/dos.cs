/*
 * Created by SharpDevelop.
 * User: 52999
 * Date: 07/11/2022
 * Time: 10:36 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace promedio_cal
{
	class Program
	{
		public static void Main(string[] args)
		{
			double n1,n2,n3, prom;
			Console.WriteLine("teclea el numero 1");
			n1=double.Parse(Console.ReadLine());
			
			Console.WriteLine("teclea el numero 2");
			n2=double.Parse(Console.ReadLine());
			
			Console.WriteLine("teclea el numero 3");
			n3=double.Parse(Console.ReadLine());
			
			prom=(n1+n2+n3)/3;
			
			Console.WriteLine("el promedio es "+prom);
			
			Console.ReadKey();
			
			
			
			
		}
	}
}