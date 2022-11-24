/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */




using System;

namespace SoyYoDeNuevo.nautoscalcomaniadecolor{
    class Program{
        public static void Main(string[] args){
            int n, i, cont1, cont2, cont3, cont4, cont5, placa;

            cont1 = 0;
            cont2 = 0;
            cont3 = 0;
            cont4 = 0;
            cont5 = 0;
            placa = 0;

            Console.WriteLine("Introduce la cantidad de autos que entran a la ciudad de Caracas");
            n = int.Parse(Console.ReadLine());

            for(i = 1; i < n; i++){

                Console.WriteLine("Introduce el ultimo digito del auto " + i);
                placa = int.Parse(Console.ReadLine());

                if(placa == 1 || placa == 2){
                    cont1++;
                }else if(placa == 3 || placa == 4){
                    cont2++;
                }else if(placa == 5 || placa == 6){
                    cont3++;
                }else if(placa == 7 || placa == 8){
                    cont4++;
                }else if(placa == 9 || placa == 0){
                    cont5++;
                }


            }

            Console.WriteLine("La cantidad de autos con calcomanía de color amarillo es: " + cont1);
            Console.WriteLine("La cantidad de autos con calcomanía de color rosa es: " + cont2);
            Console.WriteLine("La cantidad de autos con calcomanía de color roja es: " + cont3);
            Console.WriteLine("La cantidad de autos con calcomanía de color verde es: " + cont4);
            Console.WriteLine("La cantidad de autos con calcomanía de color azul es: " + cont5);

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey(true);

        }
    }
}
