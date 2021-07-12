using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NoStockException : Exception
    {
        public NoStockException():base ("No hay suficientes materiales")
        {
        }

        public NoStockException(string message) : base(message)
        {
        }

        public NoStockException(string message, Exception innerException) : base(message, innerException)
        {
        }

        
    }
}
