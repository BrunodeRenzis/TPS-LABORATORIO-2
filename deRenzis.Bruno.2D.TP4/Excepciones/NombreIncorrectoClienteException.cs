using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NombreIncorrectoClienteException:Exception
    {
        public NombreIncorrectoClienteException():base("Datos incorrectos del cliente")
        {

        }

        public NombreIncorrectoClienteException(string mensaje):base(mensaje)
        {

        }
    }
}
