using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Advanced;

namespace Tarea01
{
    internal class Docente
    {
        public int Codigo {  get; set; }
        public String Nombre { get; set; }
        public int Horas { get; set; }
        public double Tarifa { get; set; }

        public Docente(int codigo, string nombre, int horas, double tarifa)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Horas = horas;
            this.Tarifa = tarifa;
        }

        public double GetSueldoBruto()
        {
            return (this.Horas * this.Tarifa);
        }
        public double GetSueldoNeto()
        {
            double sueldo = this.GetSueldoBruto();
            switch (sueldo)
            {
                case double n when n < 4500:
                    sueldo *= 0.88;
                    break;
                case double n when n < 6500:
                    sueldo *= 0.86;
                    break;
                default:
                    sueldo *= 0.84;
                    break;
            }
            return sueldo;
        }


    }
}
