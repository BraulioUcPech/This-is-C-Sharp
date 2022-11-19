//reinicar o pagar la maquina con una direccion IP


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;




namespace DireccionIP{
    class Program{
        static void Main(string[] args){



            Console.WriteLine("Ingrese la direccion IP del equipo");
            string ip = Console.ReadLine();

            Console.WriteLine("Ingrese 1 para reiniciar o 2 para apagar");
            string opcion = Console.ReadLine();


            if (opcion == "1"){
                //reiniciar
                string comando = "shutdown -m 10.10.0.89 -r -f -t 60 ";
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", "/c " + comando);
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                Process p = Process.Start(psi);
                p.WaitForExit();
            }
            else if (opcion == "2"){
                //apagar
                string comando = "shutdown -m 192.168.1.12 -s -f -t 60";
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", "/c " + comando);
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                Process p = Process.Start(psi);
                p.WaitForExit();
            }
            else{
                Console.WriteLine("Opcion no valida");
            }
        }
    }
}