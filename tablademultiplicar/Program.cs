// tabla de multiplicar

using System;

namespace tabla_de_multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cont, res;
            num = 0;
            cont = 0;
            res = 0;

            Console.WriteLine("Ingrese el numero que desea multiplicar");
            num = int.Parse(Console.ReadLine());

            for (cont = 0; cont <= 10; cont++)
            {
                res = num * cont;
                Console.WriteLine(num + " x " + cont + " = " + res);
            }

            Console.ReadKey();
        }
    }
}
