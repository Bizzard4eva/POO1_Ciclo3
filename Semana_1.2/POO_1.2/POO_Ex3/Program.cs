using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 0;

            try
            {
                if (b == 0)
                {
                    throw new ExcepcionPersonalidada("El denominador no puede ser 0");
                }
                int resultado = a / b;
                Console.WriteLine("Resultado: " + resultado);

                string edad = "25";
                int numero = int.Parse(edad);
                Console.WriteLine("Edad: " + numero);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine("Error: " + e.TargetSite);
                Console.WriteLine("Error: " + e.ToString());

            } 
            finally
            {

            }

            Console.ReadKey();
        }


            //private static readonly ILog LOG = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        
    }
}
