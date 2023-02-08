using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class CapaAplicacionException : ApplicationException
    {
        public CapaAplicacionException(string message, Exception inner) : base ( "Excepción encontrada en la capa aplicación.", inner ) { }
    }
}
