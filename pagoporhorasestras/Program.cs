/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace pagoporhorasestras{

        class Program{
            static void Main(string[] args){

            float dinero, horas, pagoextra, triples, dobles;

            Console.Write("Introduce las horas trabajadas: ");
            horas = float.Parse(Console.ReadLine());

            Console.Write("Introduce el pago por hora: ");
            pagoextra = float.Parse(Console.ReadLine());

            if(horas > 48){
                triples = horas - 48;

                dinero = 40 * pagoextra + (8 * pagoextra * 2) + (triples * pagoextra * 3);
            }
            else{
                if(horas > 40){
                    dobles = horas - 40;

                    dinero = 40 * pagoextra + (dobles * pagoextra * 2);
                }
                else{
                    dinero = horas * pagoextra;
                }
            }

            Console.WriteLine("El pago total es: " + dinero);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
            }
        }
}