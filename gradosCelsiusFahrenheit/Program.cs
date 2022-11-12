/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date: 03/11/2022
 * Time: 04:53 p. m.
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoyYoDeNuevo.gradosCelsiusFahrenheit{

    class Program{

        public static void Main(string[] args){

            float celsius, fahrenheit;

            Console.WriteLine("Introduce los grados Celsius");
            celsius = float.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9/5) + 32;

            Console.WriteLine("Los grados Fahrenheit son: " + fahrenheit + "°F");

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
