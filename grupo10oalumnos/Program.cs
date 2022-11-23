/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */


using System;

namespace grupo10oalumos{


    class Program{
        static void Main(string[] args){

            int cont;
            float calif, prom, suma, bajo;
            suma = 0;
            prom = 0;
            bajo = 0;


            for (cont = 1; cont < 11; cont++){

                Console.WriteLine("Ingrese la calificaciones del grupo" + cont);
                calif = float.Parse(Console.ReadLine());

                if(cont == 1){
                    bajo = calif;
                }else if(calif < bajo){
                    bajo = calif;
                }

                suma = suma + calif;

            }

            prom = suma / 10;

            Console.WriteLine("EL PROMEDIO DEL GRUPO ES: " + prom);
            Console.WriteLine("LA CALIFICACION MAS BAJA ES: " + bajo);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
