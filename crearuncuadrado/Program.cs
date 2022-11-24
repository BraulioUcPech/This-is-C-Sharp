/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */


using System;


namespace SoyYoDeNuevo.crearuncuadrado{
    class Program{
        public static void Main(string[] args){



            int lado;

            Console.WriteLine("Introduce el lado del cuadrado");
            lado = int.Parse(Console.ReadLine());


            for (int cont = 0; cont < lado; cont++){
                for (int cont2 = 0; cont2 < lado; cont2++){
                    if (cont == 0 || cont == lado - 1 || cont2 == 0 || cont2 == lado - 1){
                        Console.Write("*");
                    }else{
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}

