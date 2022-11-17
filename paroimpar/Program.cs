/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace paroimpar{

    class Program{

        static void Main(string[] args){

            int numero;

            Console.WriteLine("Introduce un numero: ");
            numero = int.Parse(Console.ReadLine());

            if(numero%2 == 0){
                Console.WriteLine("El numero es par");
            }
            else{
                Console.WriteLine("El numero es impar");
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();

        }

    }

}
