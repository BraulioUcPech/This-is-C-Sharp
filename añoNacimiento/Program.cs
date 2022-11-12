/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date: 03/11/2022
 * Time: 04:53 p. m.
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoyYoDeNuevo{
    class Program{
        public static void Main(string[] args){

            int añoActual, añoNacimiento, edad;

            Console.WriteLine("El año actual");
            añoActual = int.Parse(Console.ReadLine());
            Console.WriteLine("Tu edad");
            edad = int.Parse(Console.ReadLine());

            añoNacimiento = añoActual - edad;

            Console.WriteLine("Tu año de nacimiento es: " + añoNacimiento);


            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}