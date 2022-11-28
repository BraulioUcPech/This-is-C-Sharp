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


            Console.WriteLine("Ingrese la direccion IP de la maquina a reiniciar o apagar");
            string ip = Console.ReadLine();

            Console.WriteLine("Ingrese la accion a realizar: 1 para reiniciar, 2 para apagar");
            string accion = Console.ReadLine();

            Console.WriteLine("Ingrese el tiempo de espera");
            int tiempo = Convert.ToInt32(Console.ReadLine());


            if (accion == "1"){
                //reiniciar
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";
                psi.Arguments = "/c shutdown -r -m \\\\" + ip + " -t " + tiempo;
                psi.UseShellExecute = false;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;
                psi.CreateNoWindow = true;
                Process p = Process.Start(psi);
                p.WaitForExit();
                Console.WriteLine(p.StandardOutput.ReadToEnd());
                Console.WriteLine(p.StandardError.ReadToEnd());
            }
            else if (accion == "apagar"){
                //apagar
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";
                psi.Arguments = "/c shutdown -s -m \\\\" + ip + " -t " + tiempo;
                psi.UseShellExecute = false;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;
                psi.CreateNoWindow = true;
                Process p = Process.Start(psi);
                p.WaitForExit();
                Console.WriteLine(p.StandardOutput.ReadToEnd());
                Console.WriteLine(p.StandardError.ReadToEnd());
            }
            else{
                Console.WriteLine("No se reconoce la accion");
            }
            
            //el codigo fue modificado, para mojorarlo.
        }
    }
}
