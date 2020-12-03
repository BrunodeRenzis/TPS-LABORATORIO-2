using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Archivos;
using Excepciones;
namespace Entidades
{
    public static class Comercio
    {
        static List<Venta> listaVentas;
        
        static Comercio()
        {
            listaVentas = new List<Venta>();
        }

        public static List<Venta> ListaVentas
        {
             get => listaVentas; 
        }

        public static List<Producto> ListaProductos
        {
            get
            {
                List<Producto> listaProd = new List<Producto>();
                return listaProd = DB.Leer();
            }
        }



        public static bool Guardar(List<Producto> productos)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Producto.xml");
            Xml<List<Producto>> auxProd = new Xml<List<Producto>>();

            return auxProd.Guardar(path, productos);
        }

        public static List<Producto> Leer()
        {
            List<Producto> datosProducto = new List<Producto>();
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Producto.xml");
            Xml<List<Producto>> comercio = new Xml<List<Producto>>();

            comercio.Leer(path, out datosProducto);

            return datosProducto;

        }

        public static void Venta1()
        {
            try
            {

                Venta primerVenta = new Venta();

                if (Comercio.ListaVentas + primerVenta)
                {
                    Thread.Sleep(3000);
                    Console.WriteLine($"Nueva venta en {Thread.CurrentThread.Name}");
                }

            }
            catch (VentaException e)
            {

                Console.WriteLine(e.Message);
            }

            try
            {

                Venta segundaVenta = new Venta();
           
                if (Comercio.ListaVentas + segundaVenta)
                {
                    Thread.Sleep(3000);
                    Console.WriteLine($"Nueva venta en {Thread.CurrentThread.Name}");
                }

            }
            catch (VentaException e)
            {

                Console.WriteLine(e.Message);
            }

            try
            {

                Venta tercerVenta = new Venta();
          
                if (Comercio.ListaVentas + tercerVenta)
                {
                    Thread.Sleep(3000);
                    
                    Console.WriteLine($"Nueva venta en {Thread.CurrentThread.Name}");
                }

            }
            catch (VentaException e)
            {

                Console.WriteLine(e.Message);
            }

        }

        public static void Venta2()
        {


            try
            {
                Venta primerVenta = new Venta();
         
                if (Comercio.ListaVentas + primerVenta)
                {
                    Thread.Sleep(3000);
                    Console.WriteLine($"Nueva venta en {Thread.CurrentThread.Name}");
                }

            }
            catch (VentaException e)
            {

                Console.WriteLine(e.Message);
            }

            try
            {

                Venta segundaVenta = new Venta();
          
                if (Comercio.ListaVentas + segundaVenta)
                {
                    Thread.Sleep(3000);
                    Console.WriteLine($"Nueva venta en {Thread.CurrentThread.Name}");
                }

            }
            catch (VentaException e)
            {

                Console.WriteLine(e.Message);
            }

            try
            {

                Venta tercerVenta = new Venta();
         
                if (Comercio.ListaVentas + tercerVenta)
                {
                    Thread.Sleep(3000);
                    Console.WriteLine($"Nueva venta en {Thread.CurrentThread.Name}");
                }

            }
            catch (VentaException e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public static string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LISTA DE PRODUCTOS");

            foreach (Producto unProducto in Comercio.ListaProductos)
            {
                sb.AppendLine(unProducto.ToString());
            }

            
            return sb.ToString();
        }

        

    }
}
