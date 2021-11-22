using System;
using System.Runtime.Serialization;

namespace Entidades
{
    [Serializable]
    internal class ProductoRepetidoException : Exception
    {
        public ProductoRepetidoException()
        {
        }

        public ProductoRepetidoException(string message) : base(message)
        {
        }

        public ProductoRepetidoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ProductoRepetidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}