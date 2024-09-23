using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Docente doc = new Docente(01, "Edinson", 48, 25.5);
            Console.WriteLine("Sueldo Bruto: " + doc.GetSueldoBruto());
            Console.WriteLine("Sueldo Neto: " + doc.GetSueldoNeto());


            Console.ReadKey();
        }
    }
}
