/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */


using System;

namespace tresnumeros{

    class Program{

        static void Main(string[] args){

            int num1, num2, resultado;

            Console.WriteLine("Ingresa el primer numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            if(num1 == num2){
                resultado = num1 * num2;
   ;
            }
            else if(num1 > num2){
                resultado = num1 - num2;
            }
            else{
                resultado = num1 + num2;
            }

            Console.WriteLine("Esto le paso a tus numeros: " + resultado);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();

        }

    }

}
