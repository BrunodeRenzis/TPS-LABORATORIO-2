using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace System.Collections.Generic
{
    public static class Extensiones
    {
        public static List<Producto> ProductosCadenaFrio(this List<Producto> listaProductos)
        {

            foreach (Producto unProducto in listaProductos)
            {
               if(unProducto.TipoProducto == Producto.ETipoProducto.CadenaFrio)
                {
                    listaProductos.Add(unProducto);
                }
            }

            return listaProductos;
        }
    }
}
