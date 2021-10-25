using System;
using System.Collections.Generic;

namespace Entidades
{
    public static class Mensajeria
    {
        static List<Pedido> pedidos;
        static List<Cliente> clientes;
        static List<Producto> productos;
        static double facturacion;

        static Mensajeria()
        {
            Pedidos = new List<Pedido>();
            Clientes = new List<Cliente>();
            Productos = new List<Producto>();
            facturacion = 0;
        }

        public static List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }
        public static List<Cliente> Clientes { get => clientes; set => clientes = value; }
        public static double Facturacion { get => facturacion; set => facturacion = value; }
        public static List<Producto> Productos { get => productos; set => productos = value; }

        public static bool GuardarPedidos(List<Pedido> lista)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Pedidos.xml");
            Xml<List<Pedido>> lampara = new Xml<List<Pedido>>();

            return lampara.Guardar(path, lista);
        }
    }
}
