/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date: 03/11/2022
 * Time: 04:53 p. m.
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoyYoDeNuevo.velocidadKMH{
    class Program{
        public static void Main(string[] args){

            float velocidadKMH, velocidadMS;

            Console.WriteLine("Introduce la velocidad en MS");
            velocidadMS = float.Parse(Console.ReadLine());

            velocidadKMH = velocidadMS * 3.6f;

            Console.WriteLine("La velocidad en KMH es: " + velocidadKMH + "Km/h");

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
