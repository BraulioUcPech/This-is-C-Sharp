/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date: 03/11/2022
 * Time: 11:16 p. m.
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoyYoDeNuevo{
    class Program{
        public static void Main(string[] args){

            float baseRectangulo, alturaRectangulo, areaRectangulo, perimetro;

            Console.WriteLine("Introduce la base del rectángulo");
            baseRectangulo = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la altura del rectángulo");
            alturaRectangulo = float.Parse(Console.ReadLine());

            areaRectangulo = baseRectangulo * alturaRectangulo;
            perimetro = (baseRectangulo + alturaRectangulo) * 2;


            Console.WriteLine("El área del rectángulo es: " + areaRectangulo);
            Console.WriteLine("El perímetro del rectángulo es: " + perimetro);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);


        }
    }
}
