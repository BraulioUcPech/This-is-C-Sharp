/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date: 03/11/2022
 * Time: 04:53 p. m.
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoyYoDeNuevo.dosnumerosysuma{

    class Program{

        public static void Main(string[] args){

            float numero1, numero2, suma;

            Console.WriteLine("Introduce el primer número");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número");
            numero2 = float.Parse(Console.ReadLine());

            suma = numero1 + numero2;

            Console.WriteLine("La suma de los dos números es: " + suma);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
