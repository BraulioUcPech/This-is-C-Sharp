

using System;

namespace positivoynegativo{
    class Program{
        static void Main(string[] args){

            int cont, CPos, CNeg, CNeu;
            double num;

            cont = 0;
            CPos = 0;
            CNeg = 0;
            CNeu = 0;

            while(cont < 5){
                cont++;

                Console.WriteLine("Ingrese un numero: " + cont);
                num = double.Parse(Console.ReadLine());

                if(num == 0){
                    CNeu++;
                }else if(num > 0){
                    CPos++;
                }else{
                    CNeg++;
                }
            }

            Console.WriteLine("Numeros positivos: " + CPos);
            Console.WriteLine("Numeros negativos: " + CNeg);
            Console.WriteLine("Numeros neutros: " + CNeu);

            Console.WriteLine("Ckick para Finalizar");
            Console.ReadKey();
        }
    }
}
