using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

            empleados.Add(new Empleado(001, "Edinson", "Vitterio", 1325.00));

            foreach (var empleado in empleados)
            {
                Console.WriteLine(empleado.codigo + " - " + empleado.nombre);
            }
            //foreach (Empleado empleado in empleados)
            //{
            //    Console.WriteLine(empleado.codigo + " - " + empleado.nombre);
            //}

            for (int i = 0; i < empleados.Count; i++)
            {
                Console.WriteLine(empleados[i].codigo + " - " + empleados[i].nombre);
            }

            Console.ReadKey();
        }
    }
}
