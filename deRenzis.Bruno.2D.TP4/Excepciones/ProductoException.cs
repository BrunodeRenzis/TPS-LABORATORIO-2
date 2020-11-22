using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ProductoException:Exception
    {
        public ProductoException():base("Datos incorrectos del producto")
        {

        }

        public ProductoException(string mensaje):base(mensaje)
        {

        }
    }
}
