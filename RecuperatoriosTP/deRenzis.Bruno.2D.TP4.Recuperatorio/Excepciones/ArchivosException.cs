using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        public ArchivosException(Exception innerException) : base("Error en el archivo", innerException)
        {

        }

        public ArchivosException() : base("Error en el archivo")
        {

        }

        public ArchivosException(string mensaje, Exception e) : base(mensaje,e)
        {

        }

    }
}
