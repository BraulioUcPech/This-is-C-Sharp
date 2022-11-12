/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date: 03/11/2022
 * Time: 04:53 p. m.
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoyYoDeNuevo.trescalificacionesSuma{

    class Program{

        public static void Main(string[] args){

            float calificacion1, calificacion2, calificacion3, suma;

            Console.WriteLine("Introduce la calificación 1");
            calificacion1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la calificación 2");
            calificacion2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la calificación 3");
            calificacion3 = float.Parse(Console.ReadLine());

            suma = calificacion1 + calificacion2 + calificacion3;

            Console.WriteLine("La suma de las tres calificaciones es: " + suma);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}