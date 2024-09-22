using POO_1._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_S12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Docente doc = new Docente();
            Docente doc2 = new Docente("Leslie");
            Console.WriteLine(doc.codigo);
            Console.WriteLine(doc.nombre);
            Console.WriteLine("*************");
            Console.WriteLine(doc2.codigo);
            Console.WriteLine(doc2.nombre);

            Console.ReadKey();


        }
    }
}
