/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date: 03/11/2022
 * Time: 04:53 p. m.
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoyYoDeNuevo.cantidadpesosadolares{

    class Program{

        public static void Main(string[] args){

            float cantidad, dolar, resultado;

            Console.WriteLine("Introduce la cantidad de pesos");
            cantidad = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el valor de dolar actual");
            dolar = float.Parse(Console.ReadLine());

            resultado = cantidad / dolar;

            Console.WriteLine("La cantidad en dólares es: " + resultado);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
