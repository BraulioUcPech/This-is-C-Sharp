/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */




using System;

namespace dosnumerosenformaascedente{
    class Program{
        public static void Main(string[] args){

            int num1, num2;

            Console.WriteLine("Introduce el primer número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2){
                Console.WriteLine("El orden de los números es: " + num2 + " " + num1);
            }
            else{
                Console.WriteLine("El orden de los números es: " + num1 + " " + num2);
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}

