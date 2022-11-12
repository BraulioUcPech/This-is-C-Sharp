/*
 * Created by SharpDevelop.
 * User: braulio
 * Date: 03/11/2022
 * Time: 04:53 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SoyYoDeNuevo
{
	class Program
	{
		public static void Main(string[] args)
		{
            /* Console.WriteLine("¡hola time of Software!");
            Console.ReadKey(); */        // el "readkey no pudes interactuar en la consola"

            /* Console.Write("hola");    // el "write" no da salto de linea 
            Console.Write("¿que haces?");
            Console.WriteLine();        //el "writeline" da salto de linea y no tiene un mensaje hace un salto de linea para el otro codigo 
            Console.WriteLine("hola");
            Console.WriteLine("que haces?");
            Console.ReadLine(); */      // el "readline" te permite escribir el la consola para almacenar informacion del usuario y interactuar, se usa para teclear datos que preguntas al usuario

            int edadUsuario = 16;
            string nombreUsuario = "Braulio";
            Console.WriteLine("Hola me llamo" + nombreUsuario + "y tengo" + edadUsuario + "años.");
            Console.WriteLine("hola me llamo {0} y tengo {1} años.",nombreUsuario,edadUsuario);
            Console.WriteLine("Hola me llamo" + nombreUsuario+ ".\nTengo" + edadUsuario + "años.");
            Console.WriteLine("hola me llamo \"{0}\" y tengo \"{1}\" años.",nombreUsuario,edadUsuario);
            Console.ReadLine();

            Console.WriteLine("HOLA MUNDO!");

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}