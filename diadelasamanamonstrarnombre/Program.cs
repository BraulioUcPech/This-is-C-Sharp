/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

//Solicitar al usuario la inicial del día de la semana y mostrar el nombre del día completo. La letra inicial puede ser mayúscula o minúscula. Usar la x para el miércoles


using System;

namespace diadelasamanamonstrarnombre{
    class Program{
        public static void Main(string[] args){

            string dia;

            Console.WriteLine("Introduce la inicial del día de la semana");
            dia = Console.ReadLine();

            if(dia == "l" || dia == "L"){
                Console.WriteLine("Lunes");

            }else if(dia == "m" || dia == "M"){
                Console.WriteLine("Martes");

            }else if(dia == "x" || dia == "X"){
                Console.WriteLine("Miércoles");

            }else if(dia == "j" || dia == "J"){
                Console.WriteLine("Jueves");

            }else if(dia == "v" || dia == "V"){
                Console.WriteLine("Viernes");

            }else if(dia == "s" || dia == "S"){
                Console.WriteLine("Sábado");

            }else if(dia == "d" || dia == "D"){
                Console.WriteLine("Domingo");

            }else{
                Console.WriteLine("No es un día de la semana");

            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}


