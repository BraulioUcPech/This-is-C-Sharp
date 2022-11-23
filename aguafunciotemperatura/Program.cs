/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date: 03/11/2022
 * Time: 04:53 p. m.
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */



using System;

namespace SoyYoDeNuevo.aguafunciotemperatura{
    class Program{
        public static void Main(string[] args){

            int temperatura;

            Console.WriteLine("Ingrese la temperatura del agua");
            temperatura = int.Parse(Console.ReadLine());

            if (temperatura < 0){
                Console.WriteLine("El estado del agua es sólido");
            }
            else if (temperatura < 100){
                Console.WriteLine("El estado del agua es líquido");
            }
            else{
                Console.WriteLine("El estado del agua es gas");
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);

        }
    }
}