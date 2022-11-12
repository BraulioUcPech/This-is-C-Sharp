/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date: 03/11/2022
 * Time: 11:53 p. m.
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoyYoDeNuevo.trescalificacionesSuma
{

    class Program
    {

        public static void Main(string[] args)
        {

            float calificacion1, calificacion2, calificacion3, calificacion4, promedio;

            Console.WriteLine("Introduce la calificación 1");
            calificacion1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la calificación 2");
            calificacion2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la calificación 3");
            calificacion3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la calificación 4");
            calificacion4 = float.Parse(Console.ReadLine());

            promedio = (calificacion1 + calificacion2 + calificacion3 + calificacion4)/4;

            Console.WriteLine("El promedio de las cuatro calificaciones es: " + promedio);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
