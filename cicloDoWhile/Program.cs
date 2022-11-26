

using System;

namespace cicloDoWhile{
    class Program{

        public static void Main(string[] args){
            //SOLICITAR NUMEROS Y MOSTRAR CUANTOS POSITIVOS NEGATIVSO O NEUTROS

            double num;
            double Asum = 0;
            int i = 0;

            do{
                i++;
                Console.WriteLine("Ingrese el numero" + i);
                num = double.Parse(Console.ReadLine());

                Asum += num;

            }while(i < 5);

            Console.WriteLine("La suma es: " + Asum);

            Console.Write("FInalizar");
            Console.ReadKey();
        }
    }
}
