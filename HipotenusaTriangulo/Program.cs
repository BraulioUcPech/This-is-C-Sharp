/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date: 03/11/2022
 * Time: 11:01 p. m.
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoyYoDeNuevo.HipotenusaTriangulo{
    class Program{
        public static void Main(string[] args){

            float cateto1, cateto2, hipotenusa;

            Console.WriteLine("Introduce el valor del primer cateto");
            cateto1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el valor del segundo cateto");
            cateto2 = float.Parse(Console.ReadLine());

            hipotenusa = (float)Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

            Console.WriteLine("El valor de la hipotenusa es: " + hipotenusa);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}