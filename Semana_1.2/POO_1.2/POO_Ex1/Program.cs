using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Expositor expositor = new Expositor(48, 4.5);
            expositor.Imprimir();
            Console.ReadKey();
        }
    }
}
