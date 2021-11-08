using System;
using System.Collections.Generic;

namespace Entidades
{
    public static class Mensajeria
    {
        static List<Pedido> pedidos;
        static List<Cliente> clientes;
        static List<Producto> productos;

        /// <summary>
        /// Constructor estático de la clase Mensajería, se ejecutará solo una vez para dar inicialización a las listas.
        /// </summary>
        static Mensajeria()
        {
            Pedidos = new List<Pedido>();
            Clientes = new List<Cliente>();
            Productos = new List<Producto>();
        }

        public static List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }
        public static List<Cliente> Clientes { get => clientes; set => clientes = value; }
        public static List<Producto> Productos { get => productos; set => productos = value; }

        /// <summary>
        /// Método estático que guardará pedidos generados en el programa.
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>Retorna true si se ha podido guardar la lista, caso contrarió arrojará excepción</returns>
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
        /// <summary>
        /// Método estático que guardará clientes generados en el programa.
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>Retorna true si se ha podido leer la lista, caso contrarió arrojará excepción</returns>
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

        /// <summary>
        /// Método estático que guardará productos generados en el programa.
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>Retorna true si se ha podido guardar la lista, caso contrarió arrojará excepción</returns>
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
