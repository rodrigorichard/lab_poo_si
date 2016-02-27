using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            CPU cpu = new CPU();
            cpu.Monitor = new Monitor();
            Console.WriteLine("Estado do monitor:" +
                               cpu.Monitor.isLigado());
            cpu.Monitor.ligar();
            Console.WriteLine("Estado do monitor:" +
                               cpu.Monitor.isLigado());
            cpu.Monitor.desligar();
            Console.WriteLine("Estado do monitor:" +
                               cpu.Monitor.isLigado());

            Console.ReadKey();

        }
    }
}
