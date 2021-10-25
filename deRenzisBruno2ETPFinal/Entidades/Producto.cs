using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        string nombreProducto;
        float precio;
        ETipo tipo;

        public Producto()
        {
            this.NombreProducto = String.Empty;
            this.Precio = 0;
        }
        public Producto(string nombreProducto, float precio, ETipo tipo)
        {
            this.NombreProducto = nombreProducto;
            this.Precio = precio;
            this.Tipo = tipo;
        }

        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public float Precio { get => precio; set => precio = value; }
        public ETipo Tipo { get => tipo; set => tipo = value; }
    }
}
