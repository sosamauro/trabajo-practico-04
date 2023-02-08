using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class CapaAplicacion
    {
        public static void Ejecutar()
        {
            try
            {
                CapaDominio.Ejecutar();
            }
            catch (ErrorPuntualException ex)
            {
                throw new CapaAplicacionException("Capa aplicacion exception.", ex);
            }
        }
    }
}
