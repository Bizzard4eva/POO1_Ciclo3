using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex2
{
    internal class Trabajador
    {
        private int codigo { get; set; }
        private string nombre { get; set; }
        private int horas { get; set; }
        private double tarifa { get; set; }

        public static int cod = 0;

        public Trabajador(string nombre, int horas, double tarifa)
        {
            cod += 1;
            this.codigo = cod;
            this.nombre = nombre;
            this.horas = horas;
            this.tarifa = tarifa;
        }

        public double getSueldo()
        {
            return horas * tarifa;
        }

        public void Imprimir()
        {
            Console.WriteLine("Codigo: " + this.codigo);
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Sueldo: " + this.getSueldo());
        }
    }
}
