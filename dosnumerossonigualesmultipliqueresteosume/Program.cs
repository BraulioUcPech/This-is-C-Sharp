/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoyYoDeNuevo.dosnumerossonigualesmultipliqueresteosume{
    class Program{
        public static void Main(string[] args){
            double num1, num2, resultado;

            Console.WriteLine("Introduce el primer número");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            num2 = double.Parse(Console.ReadLine());

            if(num1 == num2){
                resultado = num1 * num2;
                Console.WriteLine("El resultado de multiplicar los dos números es: " + resultado);
            }
            else if(num1 > num2){
                resultado = num1 - num2;
                Console.WriteLine("El resultado de restar los dos números es: " + resultado);
            }
            else{
                resultado = num1 + num2;
                Console.WriteLine("El resultado de sumar los dos números es: " + resultado);
            }


            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
