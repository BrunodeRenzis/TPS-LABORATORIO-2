using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodoExtension
    {
        public static long CantidadDigitos(this long cant)
        {
            return cant.ToString().Length;
        }


        public static string CantidadPuntos(this string cad)
        {
            int counter = 0;
            for (int i = 0; i < cad.Length; i++)
            {
                if (cad[i] == ',' || cad[i] == '.' || cad[i] == ';')
                {
                    counter++;
                }

            }

            return counter.ToString();
        }
    }
}
