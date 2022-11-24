/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */


/*Leer 50 calificaciones de un grupo de alumnos. Calcule y escriba el porcentaje de reprobados. Tomando en cuenta que la calificación mínima aprobatoria es de70*/


using System;

namespace SoyYoDeNuevo._50calificacionesrepro{
    class Program{
        public static void Main(string[] args){
            int calificacion;
            float reprobados = 0;
            int aprobados = 0;
            int total = 0;
            float porcentaje;

            for (int cont = 0; cont < 10; cont++){

                Console.WriteLine("Introduce la calificacion " + cont);
                calificacion = int.Parse(Console.ReadLine());

                if (calificacion < 70){
                    reprobados++;
                }else{
                    aprobados++;
                }
                total++;
            }
            porcentaje = reprobados / total * 100;
            Console.WriteLine("El porcentaje de reprobados es de " + porcentaje + "%");

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
