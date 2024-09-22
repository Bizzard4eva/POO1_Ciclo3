using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trabajador trabajador = new Trabajador("Jennifer", 36, 5.5);
            trabajador.Imprimir();

            Console.ReadKey();
        }
    }
}
