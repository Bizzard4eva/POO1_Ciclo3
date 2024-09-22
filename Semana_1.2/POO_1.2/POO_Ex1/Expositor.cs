using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex1
{
    internal class Expositor
    {
        private int codigo {  get; set; }
        private string nombre { get; set; }
        private int horas { get; set; }
        private double tarifa { get; set; }

        private double afp = 0.1;
        private double eps = 0.05;

        public Expositor(int horas, double tarifa) 
        {
            this.codigo = 0;
            this.nombre = "Edinson";
            this.horas = horas;
            this.tarifa = tarifa;
        }

        public double getSueldoBruto()
        {
            return horas * tarifa;
        }
        public double getDesAFP()
        {
            return this.getSueldoBruto() * afp;
        }
        public double getDesEPS()
        {
            return this.getSueldoBruto() * eps;
        }
        public double getSueldoNeto()
        {
            return this.getSueldoBruto() - (this.getDesAFP() + this.getDesEPS());
        }

        public void Imprimir()
        {
            Console.WriteLine("Sueldo Bruto: " + this.getSueldoBruto());
            Console.WriteLine("Sueldo Neto: " + this.getSueldoNeto());
        }
    }
}
