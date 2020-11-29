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



        public static bool Guardar(List<Venta> ventas)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Comercio.xml");
            Xml<List<Venta>> auxUni = new Xml<List<Venta>>();

            return auxUni.Guardar(path, ventas);
        }

        public static List<Venta> Leer()
        {
            List<Venta> datosVenta = new List<Venta>();
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Comercio.xml");
            Xml<List<Venta>> comercio = new Xml<List<Venta>>();

            comercio.Leer(path, out datosVenta);

            return datosVenta;

        }

        public static void Venta1()
        {
            try
            {

                Venta primerVenta = new Venta();
                primerVenta += 1;
                primerVenta += 2;

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
                segundaVenta += 1;
                segundaVenta += 2;
                segundaVenta += 3;
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
                tercerVenta += 1;
                tercerVenta += 2;
                tercerVenta += 3;
                tercerVenta += 4;
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
                primerVenta += 1;
                primerVenta += 2;
                primerVenta += 3;
                primerVenta += 4;
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
                segundaVenta += 1;
                segundaVenta += 2;
                segundaVenta += 3;
                segundaVenta += 4;
                if (Comercio.ListaVentas + segundaVenta)
                {
                    Thread.Sleep(3000);
                    Console.WriteLine($"Se genero una nueva venta en {Thread.CurrentThread.Name}");
                }

            }
            catch (VentaException e)
            {

                Console.WriteLine(e.Message);
            }

            try
            {

                Venta tercerVenta = new Venta();
                tercerVenta += 1;
                tercerVenta += 2;
                tercerVenta += 3;
                tercerVenta += 4;
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
