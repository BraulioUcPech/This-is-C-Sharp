/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */


using System;

namespace solicitarunnumeromayora15{

    class Program{

        static void Main(string[] args){

            float numero, año_actual, año_nacimiento, edad, bas, altura, area;

            Console.WriteLine("Introduce un numero: ");
            numero = float.Parse(Console.ReadLine());

            if(numero >= 15){
                Console.WriteLine("Calculo del Año de nacimiento");
                Console.WriteLine("Ingresa el año de nacimiento actual: ");
                año_actual = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el año de nacimiento: ");
                año_nacimiento = float.Parse(Console.ReadLine());

                edad= año_actual - año_nacimiento;
                Console.WriteLine("Tu edad es: " + edad);
            }
            else{
                Console.WriteLine("Calculo del Area de un rectangulo");
                Console.WriteLine("Ingresa la base del rectangulo: ");
                bas = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa la altura del rectangulo: ");
                altura = float.Parse(Console.ReadLine());

                area = bas * altura;
                Console.WriteLine("El area del rectangulo es: " + area);
            }






            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();

        }

    }

}