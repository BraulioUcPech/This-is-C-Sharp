/*
 * Created by Bra-Ülio.
 * User: braulio
 * Date:
 * Time:
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */




using System;

namespace unnumerounmes{
    class Program{
        public static void Main(string[] args){
            int mes, cont;

            Console.WriteLine("Ingrese un número de mes: ");
            mes = int.Parse(Console.ReadLine());

            cont = 0;

            while (cont <= mes){
                    switch (mes){
                        case 1:
                            Console.WriteLine("Enero");
                            break;
                        case 2:
                            Console.WriteLine("Febrero");
                            break;
                        case 3:
                            Console.WriteLine("Marzo");
                            break;
                        case 4:
                            Console.WriteLine("Abril");
                            break;
                        case 5:
                            Console.WriteLine("Mayo");
                            break;
                        case 6:
                            Console.WriteLine("Junio");
                            break;
                        case 7:
                            Console.WriteLine("Julio");
                            break;
                        case 8:
                            Console.WriteLine("Agosto");
                            break;
                        case 9:
                            Console.WriteLine("Septiembre");
                            break;
                        case 10:
                            Console.WriteLine("Octubre");
                            break;
                        case 11:
                            Console.WriteLine("Noviembre");
                            break;
                        case 12:
                            Console.WriteLine("Diciembre");
                            break;
                        default:
                            Console.WriteLine("No existe ese mes");
                            break;
                    }
                cont++;
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}







































































































































/*int mes;

            Console.WriteLine("Ingrese un número de mes");
            mes = int.Parse(Console.ReadLine());

            switch (mes){
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("No es un mes");
                    break;
            }*/