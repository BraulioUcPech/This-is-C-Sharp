/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date: 03/11/2022
 * Time: 11:04 p. m.
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoyYoDeNuevo.areaRectangulo
{
    class Program
    {
        public static void Main(string[] args)
        {
            float baseRectangulo, alturaRectangulo, areaRectangulo;

            Console.WriteLine("Introduce la base del rectángulo");
            baseRectangulo = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la altura del rectángulo");
            alturaRectangulo = float.Parse(Console.ReadLine());

            areaRectangulo = baseRectangulo * alturaRectangulo;

            Console.WriteLine("El área del rectángulo es: " + areaRectangulo);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}