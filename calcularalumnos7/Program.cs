/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date: /2022
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */



using System;


namespace calcularalumnos7{
    class Program{
        static void Main(string[] args){

            int cont;
            float calif, prom, suma;
            suma = 0;
            prom = 0;


            for (cont = 0; cont < 7; cont++){

                Console.WriteLine("Ingrese la calificacion del alumno" + cont);
                calif = float.Parse(Console.ReadLine());

                suma = suma + calif;

            }

            prom = suma / 7;

            Console.WriteLine("TU PROMEDIO ES DE LA MATERIA DISAÑO ESTRUCTURADO DE ALGORITMOS ES: " + prom);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}