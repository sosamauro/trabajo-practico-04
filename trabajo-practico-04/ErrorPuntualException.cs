using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class ErrorPuntualException : ApplicationException
    {
        public ErrorPuntualException(string message) : base ( String.Format("Error puntual el día {0:d} a las {0:t}", DateTime.Now) ) { }
    }
}
