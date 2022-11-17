/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace verificaciondecontraseña{

    class Program{

        static void Main(string[] args){

            string contraseña, contraseña2;

            Console.WriteLine("Introduce tu contraseña: ");
            contraseña = Console.ReadLine();

            Console.WriteLine("Introduce tu contraseña nuevamente: ");
            contraseña2 = Console.ReadLine();

            if(contraseña == contraseña2){
                Console.WriteLine("Contraseña correcta");
            }
            else{
                Console.WriteLine("Contraseña incorrecta");
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();

        }

    }

}
