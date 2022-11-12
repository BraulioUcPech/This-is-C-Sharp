/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date: 03/11/2022
 * Time: 10:55 p. m.
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SoyYoDeNuevo.areaVolumen
{
    class Program
    {
        public static void Main(string[] args)
        {
            float R, H, area, volumen;
            const float pi = 3.1416f;

            Console.WriteLine("Introduce el radio de la base");
            R = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la altura");
            H = float.Parse(Console.ReadLine());

            area = 2 * pi * R * (R + H);
            volumen = pi * R * R * H;


            Console.WriteLine("El área de la base es: " + area);
            Console.WriteLine("El volumen del cilindro es: " + volumen);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}