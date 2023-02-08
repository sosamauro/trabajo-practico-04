using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    public static class CapaVista
    {
        public static void Ejecutar()
        {
            try
            {
                CapaControlador.Ejecutar();
            }
            catch (CapaAplicacionException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                Console.WriteLine(ex.InnerException.Message.ToString());
                Console.WriteLine(
                    "\nStackTrace ---\n{0}", ex.StackTrace);

            }
        }
    }
}
