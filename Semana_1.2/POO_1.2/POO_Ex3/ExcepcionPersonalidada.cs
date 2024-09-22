using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex3
{
    internal class ExcepcionPersonalidada : Exception
    {
        public ExcepcionPersonalidada(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
