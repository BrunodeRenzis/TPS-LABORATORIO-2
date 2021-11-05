using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        int idProducto;
        string nombreProducto;
        float precio;
        double stock;
        ETipo tipo;

        public Producto()
        {
            this.NombreProducto = String.Empty;
            this.Precio = 0;
        }
        public Producto(int idProducto,string nombreProducto, float precio, ETipo tipo, double stock)
        {
            this.IdProducto = idProducto;
            this.NombreProducto = nombreProducto;
            this.Precio = precio;
            this.Tipo = tipo;
            this.Stock = stock;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public ETipo Tipo { get => tipo; set => tipo = value; }
        public float Precio { get => precio; set => precio = value; }
        public double Stock { get => stock; set => stock = value; }

        public static void HardcodearXmlProductos()
        {

            try
            {
                Mensajeria.Productos.Add(new Producto(1, "Perfume avon", 500, ETipo.Perfumería, 20));
                Mensajeria.Productos.Add(new Producto(2, "Cuchillo chef Tramontia", 2500, ETipo.Cocina, 10));
                Mensajeria.Productos.Add(new Producto(3, "Uno", 1500, ETipo.Entretenimiento, 20));
                Mensajeria.Productos.Add(new Producto(4, "Ajedrez", 500, ETipo.Entretenimiento, 20));
                Mensajeria.Productos.Add(new Producto(5, "Pantalón Chupín", 2500, ETipo.Indumentaria, 14));
                Mensajeria.Productos.Add(new Producto(6, "Sauvage Dior", 3500, ETipo.Perfumería, 20));
                Mensajeria.Productos.Add(new Producto(7, "Wok Tramontina", 2500, ETipo.Cocina, 20));
                Mensajeria.Productos.Add(new Producto(8, "Vestido Summer Limited Edition", 3500, ETipo.Indumentaria, 10));
                Mensajeria.Productos.Add(new Producto(9, "Mesa Pool-PingPong", 15000, ETipo.Entretenimiento, 20));
                Mensajeria.Productos.Add(new Producto(10, "Kit vasos", 1500, ETipo.Cocina, 8));
                Mensajeria.GuardarProductos(Mensajeria.Productos);
            }

            catch (ArchivoException ex)
            {
                throw new ArchivoException(ex.Message, ex);
            }
        }

        
    }

    public enum ETipo
    {
        Indumentaria,
        Perfumería,
        Entretenimiento,
        Cocina
    }
}
