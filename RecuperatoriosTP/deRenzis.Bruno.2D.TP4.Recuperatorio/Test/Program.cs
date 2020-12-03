using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Archivos;
using Entidades;
using Excepciones;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "de Renzis.Bruno.2D.TP4";
            ProductoCadenaFrio paty = new ProductoCadenaFrio("Hamburguesa",200,Producto.ETipoProducto.CadenaFrio,50);
            ProductoCadenaFrio nugget = new ProductoCadenaFrio("Patitas pollo", 250, Producto.ETipoProducto.CadenaFrio, 50);
            ProductoSinCadenaFrio arroz = new ProductoSinCadenaFrio("Arroz gallo", 100, Producto.ETipoProducto.SinCadenaFrio, 50);
            Venta unaVenta = new Venta();

            Thread hilo1 = new Thread(Comercio.Venta1);
            Thread hilo2 = new Thread(Comercio.Venta2);

            try
            {
                if (paty+Comercio.ListaProductos)
                    Console.WriteLine($"Producto: {paty.Nombre} cargado");
                if (nugget+Comercio.ListaProductos)
                    Console.WriteLine($"Producto: {nugget.Nombre} cargado");
                if (arroz+Comercio.ListaProductos)
                    Console.WriteLine($"Producto: {arroz.Nombre} cargado");
                
            }
            catch (ProductoException e)
            {

                Console.WriteLine(e.Message);

            }


            try
            {
                Console.WriteLine(Comercio.Mostrar());
            }
            catch (ArchivoException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException.Message);
            }

           
            try
            {

                if(Comercio.ListaVentas+unaVenta)
                {
                    Console.WriteLine("Venta realizada");
                }
                

            }
            catch (VentaException e)
            {

                Console.WriteLine(e.Message);
            }

            try
            {
 
                if (Comercio.ListaVentas + unaVenta)
                    Console.WriteLine($"Venta guardada");

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }

            try
            {
                hilo1.Name = "Punto de venta 1";
                hilo2.Name = "Punto de venta 2";
                Console.WriteLine("SE GENERAN VENTAS DESDE DOS HILOS DIFERENTES");
                hilo1.Start();
                hilo2.Start();
                Thread.Sleep(3000);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            try
            {
                Console.WriteLine("\nSE IMPRIME EL LISTADO DE PRODUCTOS PARA VERIFICAR QUE BAJO EL STOCK DE LOS PRODUCTOS VENDIDOS: ");
                Console.WriteLine();

                Console.WriteLine(Comercio.Mostrar());
            }
            catch (ArchivoException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException.Message);
            }

            
            try
            {
                Console.WriteLine("\nMÉTODOS DE EXTENSIÓN PARA CALCULAR EL MONTO TOTAL DE VENTAS");
                Console.WriteLine($"Acumulado de ventas: ${Comercio.ListaVentas.TotalVentas()}");

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            
            try
            {
                Console.WriteLine("\nSE GUARDA EL LISTADO DE VENTAS EN UN ARCHIVO XML");
                Console.WriteLine();
                if (Comercio.Guardar(Comercio.ListaVentas))
                    Console.WriteLine("Guardado con exito");

            }
            catch (ArchivoException e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException.Message);
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}