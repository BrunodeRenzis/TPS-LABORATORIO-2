using System;
using System.Runtime.Serialization;

namespace Entidades
{
    public class ClienteException : Exception
    {
        private string v;
        private ClienteException e;

        public ClienteException()
        {
        }

        public ClienteException(string message) : base(message)
        {
        }

        public ClienteException(string v, ClienteException e)
        {
            this.v = v;
            this.e = e;
        }

        public ClienteException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ClienteException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}