using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POO_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            //\\
            List<Alumno> alumnos = new List<Alumno>();
            alumnos.Add(new Alumno(01, "Edinson", "Vitterio", 25));
            alumnos.Add(new Alumno(02, "Edins", "Vitterio", 22));
            alumnos.Add(new Alumno(03, "Edson", "Vitterio", 20));
            alumnos.Add(new Alumno(04, "Eson", "Vitterio", 27));
            alumnos.Add(new Alumno(05, "Edinn", "Vitterio", 29));
            alumnos.Add(new Alumno(06, "Edin", "Vitterio", 19));
            alumnos.Add(new Alumno(07, "Dson", "Vitterio", 24));

            Imprimir(alumnos);
            alumnos.RemoveAll(x => x.codigo == 3);
            //\\
            //Thread.Sleep(3000); // 3 segundos
            watch.Stop();
            Console.WriteLine($"\nTiempo: {watch.Elapsed}"); 

            DateTime fecha = DateTime.Now;
            Console.WriteLine($"Fecha en que se detuvo el programa: {fecha}");
            Console.WriteLine(fecha.ToString("yyyy-MM-dd hh:mm:ss.fff tt"));

            Console.ReadKey();
        }
        public static void Imprimir( List<Alumno> list)
        {
            List<Alumno> lista;
            lista = list.OrderBy(x => x.edad).ToList();
            //lista = list.OrderByDescending(x => x.edad).ToList();
            foreach (var x in lista)
            {
                Console.WriteLine($"ID: {x.codigo} - N: {x.nombre} - A: {x.apellido} - E: {x.edad}");
            }
        }
    }
}
