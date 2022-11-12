/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date: 03/11/2022
 * Time: 04:53 p. m.
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */


using System;

namespace SoyYoDeNuevo.areaTriangulo{

    class Program{

        public static void Main(string[] args){

            float baseT, altura, area;

            Console.WriteLine("Introduce la base del triángulo");
            baseT = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la altura del triángulo");
            altura = float.Parse(Console.ReadLine());

            area = (baseT * altura) / 2;

            Console.WriteLine("El área del triángulo es: " + area);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
