/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace mayordeedad{

    class Program{

        static void Main(string[] args){

            int edad;

            Console.WriteLine("Introduce tu edad: ");
            edad = int.Parse(Console.ReadLine());

            if(edad >= 18){
                Console.WriteLine("Eres mayor de edad");
            }else{
                Console.WriteLine("Eres menor de edad");
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();

        }

    }

}