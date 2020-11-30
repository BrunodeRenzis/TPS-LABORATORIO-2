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
