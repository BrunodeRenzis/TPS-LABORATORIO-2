using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoNoPerecedero : Producto
    {
        public ProductoNoPerecedero(int idProducto, string nombreProducto,double precio, int cantidad, Producto.ETipoProudcto tipoProd) : base(idProducto, nombreProducto,precio, cantidad, tipoProd)
        {
            
        }

    }
}
