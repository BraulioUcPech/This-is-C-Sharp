/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */



//Realizar un programa que transforme todas las letras del alfabeto de mayúsculas a minúsculas.

using System;

namespace SoyYoDeNuevo.transformetodaslasletras{
    class Program{
        public static void Main(string[] args){

            /*char letra;

            Console.WriteLine("Introduce una letra");
            letra = char.Parse(Console.ReadLine());

            if(letra >= 'A' && letra <= 'Z'){
                letra = (char)(letra + 32);
                Console.WriteLine("La letra en minúscula es: " + letra);
            }
            else if(letra >= 'a' && letra <= 'z'){
                letra = (char)(letra - 32);
                Console.WriteLine("La letra en mayúscula es: " + letra);
            }
            else{
                Console.WriteLine("No es una letra");
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);*/

            string texto;
            int i, cont;

            texto = " ";

            for(cont = 0; cont < 26; cont++){
                Console.WriteLine("La letra en minúscula es: ");
                texto = Console.ReadLine();
            }
            for(cont = 0; cont < 27; cont++){

                for (i = 0; i < texto.Length; i++){
                    if (texto[i] >= 'A' && texto[i] <= 'Z'){
                        texto = texto.Replace(texto[i], (char)(texto[i] + 32));

                    }else if (texto[i] >= 'a' && texto[i] <= 'z'){
                        texto = texto.Replace(texto[i], (char)(texto[i] - 32));
                    }
                }

                Console.WriteLine("La letra en mayúscula es: " + texto);
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
