/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date: 03/11/2022
 * Time: 04:53 p. m.
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoyYoDeNuevo.areacuadrado{

    class Program{

        public static void Main(string[] args){

            float lado, area;

            Console.WriteLine("Introduce el lado del cuadrado");
            lado = float.Parse(Console.ReadLine());

            area = lado * lado;

            Console.WriteLine("El área del cuadrado es: " + area);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
