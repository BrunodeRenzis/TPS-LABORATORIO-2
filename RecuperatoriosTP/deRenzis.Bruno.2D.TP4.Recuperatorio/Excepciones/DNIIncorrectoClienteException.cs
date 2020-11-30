using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DNIIncorrectoClienteException:Exception
    {
        public DNIIncorrectoClienteException() : base("Datos incorrectos del cliente")
        {

        }

        public DNIIncorrectoClienteException(string mensaje) : base(mensaje)
        {

        }
    }
}
