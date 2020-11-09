using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
namespace Entidades
{
    public static class Validaciones
    {
        public static bool ValidarDni(string dni)
        {
            int dniAux=0;
            bool retorno=false;
            if (string.IsNullOrEmpty(dni) || !int.TryParse(dni, out dniAux))
            {
                throw new DNIIncorrectoClienteException("El dni ingresado no es válido");
            }
            retorno = true;

            return retorno;
        }

        public static int ValidarDni(int dni)
        {
            int dniAux;
            if (string.IsNullOrEmpty(dni) || !int.TryParse(dni, out dniAux))
            {
                dniAux = 0;
                throw new DNIIncorrectoClienteException("El dni ingresado no es válido");
            }

            return dniAux;
        }

        public static bool QuitarProductoDeLaLista(Producto unProducto,List<Producto> listaProductos)
        {
            for(int i=0;i<listaProductos.Count;i++)
            {
                if(unProducto.Cantidad==0)
                {
                    listaProductos.Remove(unProducto);
                    return true;
                }
            }
            return false;
        }

        
    }
}
