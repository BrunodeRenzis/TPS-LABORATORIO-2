using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PedidoRepetidoException : Exception
    {
        public PedidoRepetidoException()
        {
        }

        public PedidoRepetidoException(string message) : base(message)
        {
        }

        public PedidoRepetidoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
