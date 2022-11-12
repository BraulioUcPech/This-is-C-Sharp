/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date: 03/11/2022
 * Time: 10:53 p. m.
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SoyYoDeNuevo.dosnumeros
{
    class Program
    {
        public static void Main(string[] args)
        {
            float num1, num2, suma, promedio;

            Console.WriteLine("Introduce el primer número");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número");
            num2 = float.Parse(Console.ReadLine());

           suma = num1 + num2;
           promedio = suma / 2;

           Console.WriteLine("La suma de los dos números es: " + suma);
           Console.WriteLine("El promedio de los dos números es: " + promedio);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}