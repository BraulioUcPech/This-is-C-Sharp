/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace descuentoProducto{

    class Program{

        static void Main(string[] args){

            float prod1, prod2, total;

            Console.WriteLine("Introduce el precio del producto: ");
            prod1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el precio del segundo producto: ");
            prod2 = float.Parse(Console.ReadLine());


            total = prod1 + prod2;

            if(total >= 100){
                Console.WriteLine("Felicidades, usdet tiene un descuento por su compra mayor a 100 pesos " + total);
            }



            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();

        }

    }

}
