/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace colordeboladescuento{

        class Program{
            static void Main(string[] args){

            double dinero, total, descuento;
            string color;

            descuento = 0;

            Console.WriteLine("El total ");
            dinero = double.Parse(Console.ReadLine());


            Console.WriteLine("Introduce el color de la bola: (Blanca, Verde, Amarilla, Azul, Roja) ");
            color = Console.ReadLine();

            if(color == "blanco"){
                descuento = 0;
            }
            else{
                if(color == "verde"){
                    descuento = dinero * 0.10;
                }
                else{
                    if(color == "amarilla"){
                        descuento = dinero * 0.25;
                    }
                    else{
                        if(color == "azul"){
                            descuento = dinero * 0.50;
                        }
                        else{
                            if(color == "roja"){
                                descuento = dinero * 1;
                            }
                            else{
                                Console.WriteLine("Color de la bola no existe");
                            }
                        }
                    }
                }
            }
            total = dinero - descuento;

            Console.WriteLine("El total a pagar ya con el descuento aplicado es: " + total);
            Console.WriteLine("El descuento aplicado es: " + descuento);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
            }
        }
}