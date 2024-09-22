using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista.Add(25);
            lista.Add(22);
            lista.Add(19);
            lista.Add(89);
            lista.Add(10);
            lista.Add(19);

            Imprimir(lista);
            Contar(lista);
            OrdenarAsc(lista);
            OrdenarDes(lista);
            Eliminar1erCoincidencia(19, lista);
            EliminarCiertaPoscicion(2, lista);

            //lista.RemoveAll(x => x == 19);
            //lista.RemoveAll(x => x % 2 == 1);
            //lista.RemoveAll(x => x % 2 == 0);
            //int posicion = lista.IndexOf(3);
            lista.RemoveRange(2, 3); 
            Console.ReadKey();
        }

        static void Imprimir(List<int> list)
        {
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
        static void Contar(List<int> list)
        {
            int cantidad = list.Count;
            Console.WriteLine($"Cantidad: {cantidad}");
        }
        static void OrdenarAsc(List<int> list)
        {
            list.Sort();
            Console.WriteLine(list);
        }
        static void OrdenarDes(List<int> list)
        {
            list.Sort();
            list.Reverse();
            Console.WriteLine(list);
        }
        static void Eliminar1erCoincidencia(int x, List<int> list)
        {
            list.Remove(x);
            Console.WriteLine(list);
        }
        static void EliminarCiertaPoscicion(int x, List<int> list)
        {
            list.RemoveAt(x);
            Console.WriteLine(list);
        }
        static void LimpiarLista(List<int> list)
        {
            list.Clear();
        }
        
    }
}
