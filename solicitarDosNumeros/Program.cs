/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */


using System;

namespace solicitarDosNumeros{

    class Program{

        static void Main(string[] args){

            float numero1, numero2, resultado;

            Console.WriteLine("Introduce el primer numero: ");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero: ");
            numero2 = float.Parse(Console.ReadLine());

            if(numero1 == numero2){
                    resultado = numero1 * numero2;
                    Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
            }
            else{
                if(numero1 > numero2){
                    resultado = numero1 - numero2;
                    Console.WriteLine("El resultado de la resta es: " + resultado);
                }
                else{
                    resultado = numero1 + numero2;
                    Console.WriteLine("El resultado de la suma es: " + resultado);
                }
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();

        }

    }




}