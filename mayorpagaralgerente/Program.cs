/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace mayorpagaralgerente{

    class Program{

        static void Main(string[] args){

            int edad;

            Console.WriteLine("Ingresa su edad");
            edad = int.Parse(Console.ReadLine());

            if(edad < 4){
                Console.WriteLine("Usted puede entrar gratis, disfruta");
            }
            else if(edad >= 4 && edad <= 18){
                Console.WriteLine("Paga 5 pesos");
            }
            else if(edad > 18){
                Console.WriteLine("Paga 10 pesos");
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();

        }

    }

}
