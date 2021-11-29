using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PedidoVacioException : Exception
    {
        public PedidoVacioException()
        {
        }

        public PedidoVacioException(string message) : base(message)
        {
        }

        public PedidoVacioException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PedidoVacioException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
