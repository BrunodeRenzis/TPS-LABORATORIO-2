using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PedidoNoGeneradoException : Exception
    {
        public PedidoNoGeneradoException()
        {
        }

        public PedidoNoGeneradoException(string message) : base(message)
        {
        }

        public PedidoNoGeneradoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
