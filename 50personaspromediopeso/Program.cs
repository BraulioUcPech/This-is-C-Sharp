/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */


using System;



namespace SoyYoDeNuevo{
    class Program{
        public static void Main(string[] args){
            int cont, edad, niño, joven, adulto, viejito;
            double peso, suma, pesoNiño, pesoJoven, pesoAdulto, pesoViejito, promedioNiño, promedioJoven, promedioAdulto, promedioViejito;

            niño = 0;
            suma = 0;
            joven = 0;
            adulto = 0;
            viejito = 0;
            pesoNiño = 0;
            pesoJoven = 0;
            pesoAdulto = 0;
            pesoViejito = 0;
            promedioNiño = 0;
            promedioJoven = 0;
            promedioAdulto = 0;
            promedioViejito = 0;


            for (cont = 1; cont < 5; cont++)
            {
                Console.WriteLine("Persona " + cont);
                Console.WriteLine("Ingrese su edad: ");
                edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su peso: ");
                peso = double.Parse(Console.ReadLine());

                suma = suma + peso;

                if (edad <= 13)
                {
                    niño = niño + 1;
                    pesoNiño = pesoNiño + peso;
                    promedioNiño = pesoNiño / niño;

                }
                else if (edad <= 29)
                {
                    joven = joven + 1;
                    pesoJoven = pesoJoven + peso;
                    promedioJoven = pesoJoven / joven;

                }
                else if (edad <= 49)
                {
                    adulto = adulto + 1;
                    pesoAdulto = pesoAdulto + peso;
                    promedioAdulto = pesoAdulto / adulto;

                }
                else if (edad >= 60)
                {
                    viejito = viejito + 1;
                    pesoViejito = pesoViejito + peso;
                    promedioViejito = pesoViejito / viejito;

                }

            }


            Console.WriteLine("El promedio de peso de los niños es: " + promedioNiño);
            Console.WriteLine("El promedio de peso de los jovenes es: " + promedioJoven);
            Console.WriteLine("El promedio de peso de los adultos es: " + promedioAdulto);
            Console.WriteLine("El promedio de peso de los viejitos es: " + promedioViejito);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}

