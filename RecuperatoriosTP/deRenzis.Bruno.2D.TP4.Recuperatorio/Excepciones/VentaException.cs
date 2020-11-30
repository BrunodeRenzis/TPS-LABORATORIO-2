using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class VentaException:Exception
    {
        public VentaException():base("Error en la venta")
        {

        }

        public VentaException(Exception innerException):base("Error en la venta",innerException)
        {

        }

        public VentaException(string mensaje, Exception ex) : base(mensaje, ex)
        {

        }

        public VentaException(string mensaje) : base(mensaje)
        {

        }
    }
}
