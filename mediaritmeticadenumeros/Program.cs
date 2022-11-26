


using System;

namespace mediaaritmetica{
    class program{
        public static void Main(string[] args){

            double Asum;
            double prom;
            double num;

            Asum = 0;
            prom = 0;
            num = 0;
            int cont = 0;

            do{
                Console.WriteLine("Ingresa un numero");
                num = double.Parse(Console.ReadLine());

                if (num > 0){
                    Asum += num;
                }
                cont++;

            }while (num > 0);

            prom = Asum / cont;

            Console.WriteLine("El promedio es: " + prom);
            Console.WriteLine("La suma de los numeros es: " + Asum);

            Console.ReadKey();
        }
    }
}
