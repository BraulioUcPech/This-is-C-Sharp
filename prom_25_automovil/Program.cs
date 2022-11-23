/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */


using System;


namespace prom_25_automovil{

    class Program{
        static void Main(string[] args){
            int contador, puntos;
            float promedio, suma;

            contador = 1;
            suma = 0;

            while (contador <= 25){
                Console.WriteLine("Ingrese los puntos contaminantes del automovil " + contador);
                puntos = int.Parse(Console.ReadLine());
                suma = suma + puntos;
                contador = contador + 1;
            }
            promedio = suma / 25;
            Console.WriteLine("El promedio de puntos contaminantes es: " + promedio);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
     }
}


