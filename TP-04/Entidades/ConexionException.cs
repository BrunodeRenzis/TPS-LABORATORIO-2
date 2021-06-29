using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ConexionException : Exception
    {
        public ConexionException()
        {
        }

        public ConexionException(string message) : base(message)
        {
        }

        public ConexionException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
