/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date: 03/11/2022
 * Time: 04:53 p. m.
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SoyYoDeNuevo.calificacionFinal{

    class Program{

        public static void Main(string[] args)
        {

            float calificacion1, calificacion2, ExamFinal, TrabaFinal, promedio, promFinal;

            Console.WriteLine("Introduce la calificación 1");
            calificacion1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la calificación 2");
            calificacion2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Calificacion de examen final");
            ExamFinal = float.Parse(Console.ReadLine());

            Console.WriteLine("Calificacion del trabajo final");
            TrabaFinal = float.Parse(Console.ReadLine());

            promedio = (calificacion1 + calificacion2) / 2;
            promFinal = (promedio * 0.55f) + (ExamFinal * 0.30f) + (TrabaFinal * 0.15f);

            Console.WriteLine("El promedio final es: " + promFinal);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
