/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date: 03/11/2022
 * Time: 04:53 p. m.
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */



//Calcular el mayor de cuatro números enteros introducidos por teclado.

using System;

namespace mayordecuatronumeros{
    class Program{
        public static void Main(string[] args){
            double num, mayor, menor;
            int cont;

            mayor = 0;
            menor = 0;
            cont = 0 ;

            do{
                Console.WriteLine("Ingrese un número");
                num = double.Parse(Console.ReadLine());

                cont++;

                if (num == 0){
                    mayor = num;
                    menor = num;
                }
                else if (num > mayor){
                    mayor = num;
                }
                else{
                    menor = num;
                }
            } while (cont < 4);



            Console.WriteLine("El mayor es: " + mayor);
            Console.WriteLine("El menor es: " + menor);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}

