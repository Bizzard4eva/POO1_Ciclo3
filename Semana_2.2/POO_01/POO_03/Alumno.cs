using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_03
{
    internal class Alumno
    {
        public int codigo {  get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }

        public Alumno(int codigo, string nombre, string apellido, int edad)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public Alumno() { }
    }
}
