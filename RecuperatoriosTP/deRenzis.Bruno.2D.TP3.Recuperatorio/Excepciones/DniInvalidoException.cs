using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException:Exception
    {
        public DniInvalidoException():base()
        {

        }

        public DniInvalidoException(Exception e): base("Dni inválido",e)
        {

        }

        public DniInvalidoException(string message)
        {

        }

        public DniInvalidoException(string message, Exception e)
        {

        }
    }
}
