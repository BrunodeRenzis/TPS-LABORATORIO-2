using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PaqueteNoEntregadoException : Exception
    {
        public PaqueteNoEntregadoException()
        {
        }

        public PaqueteNoEntregadoException(string message) : base(message)
        {
        }

        public PaqueteNoEntregadoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}