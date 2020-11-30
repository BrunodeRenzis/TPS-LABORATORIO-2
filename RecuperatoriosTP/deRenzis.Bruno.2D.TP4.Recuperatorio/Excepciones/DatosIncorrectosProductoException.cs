using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DatosIncorrectosProductoException:Exception
    {
        public DatosIncorrectosProductoException() : base("Datos incorrectos del cliente")
        {

        }

        public DatosIncorrectosProductoException(string mensaje) : base(mensaje)
        {

        }
    }
}
