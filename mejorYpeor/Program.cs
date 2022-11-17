/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */


using System;

namespace mejorYpeor{

        class Program{
            static void Main(string[] args){


            float peor, num, mejor, igual;
            igual = 0;
            mejor = 0;
            peor = 0;

            for(int cont = 0; cont < 2; cont++){
                Console.Write("Introduce un numero: ");
                num = float.Parse(Console.ReadLine());

                if(num == 0){
                    mejor = num;
                    peor = num;
                }
                else{
                    if(num > mejor){
                        mejor = num;
                    }
                    else{
                        peor = num;
                    }
                }
            }

            Console.WriteLine("El numero Menor es: " + peor);
            Console.WriteLine("El numero Mayor es: " + mejor);


            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
            }
        }
}