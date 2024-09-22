using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1._2
{
    internal class Docente
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string documento { get; set; }


        public Docente() 
        { 
            this.codigo = 0;
            this.nombre = "Edinson";
        }
        public Docente(string nombre)
        {
            this.codigo = 1;
            this.nombre = nombre;
        }
        public Docente(int codigo)
        {
            this.codigo = codigo;
        }

        public string getNombre()
        {
            return nombre + " " + apellido;
        }

        public void saludar()
        {
            Console.WriteLine($"Hola me llamo {nombre}");
        }
    }
}
