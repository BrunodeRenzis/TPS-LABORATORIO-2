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
            try
            {
                string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Pedidos.xml");
                Xml<List<Pedido>> pedido = new Xml<List<Pedido>>();

                return pedido.Guardar(path, lista);
            }

            catch(ArchivoException e)
            {
                throw new ArchivoException("Archivo no generado correctamente",e.InnerException);
            }
        }

        public static bool GuardarClientes(List<Cliente> lista)
        {
            try
            {
                string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Clientes.xml");
                Xml<List<Cliente>> clientes = new Xml<List<Cliente>>();

                return clientes.Guardar(path, lista);
            }

            catch (ArchivoException e)
            {
                throw new ArchivoException("Archivo no generado correctamente", e.InnerException);
            }
        }

        public static bool GuardarProductos(List<Producto> lista)
        {
            try
            {
                string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Productos.xml");
                Xml<List<Producto>> productos = new Xml<List<Producto>>();

                return productos.Guardar(path, lista);
            }

            catch (ArchivoException e)
            {
                throw new ArchivoException("Archivo no generado correctamente", e.InnerException);
            }
        }
    }
}
