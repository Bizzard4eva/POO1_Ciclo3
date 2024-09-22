using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace POO_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string link = ConfigurationManager.AppSettings["ruta_log"].ToString();
            string correo = ConfigurationManager.AppSettings["correo"].ToString();
            ArchivoTXT(link);

        }

        public static void ArchivoTXT(string link)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(link, true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                sw.Close();
            }
        }
    }
}
