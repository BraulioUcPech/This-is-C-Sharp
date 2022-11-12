/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date: 03/11/2022
 * Time: 10:26 p. m.
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace velocidadAutomovil
{
    class Program
    {
        public static void Main(string[] args)
        {

            float velocidadKM, velocidadMS;

            Console.WriteLine("ingrese la velocidad del automovil");
            velocidadKM = float.Parse(Console.ReadLine());
            //float velocidad = float.Parse(Console.ReadLine());

            velocidadMS = velocidadKM * 10 / 36;


            Console.WriteLine("Velocidad en metros por segundo: " + velocidadMS);
            Console.WriteLine("Presione cualquier tecla para continuar . . . ");
            Console.ReadKey(true);
        }
    }
}