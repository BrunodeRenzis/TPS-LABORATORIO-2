using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoPerecedero : Producto
    {
        string fechaVto;
        public ProductoPerecedero(int id,string descripcion, double precio, int stock, Producto.ETipoProudcto tipo, string fechaVencimiento) : base(id,descripcion, precio, stock, tipo)
        {
            this.fechaVto = fechaVencimiento;
        }
    }
}
