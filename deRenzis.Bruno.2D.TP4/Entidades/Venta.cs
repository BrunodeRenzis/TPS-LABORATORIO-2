﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
namespace Entidades
{
    public delegate void DelegadoVenta(Venta unaVenta);
    public class Venta
    {
        public static event DelegadoVenta delegVent;
        List<Producto> listaProductos;
        double montoTotal;
        static int idVenta;


        public Venta()
        {
            MontoTotal = 0;
            ListaProductos = new List<Producto>();
            idVenta = 0;
        }

        //Agrego los métodos al delegado
        static Venta()
        {

        }

        public List<Producto> ListaProductos { get => listaProductos; set => listaProductos = value; }
        public double MontoTotal { get => montoTotal; set => montoTotal = value; }
        public int IdVenta { get => idVenta; set => idVenta = value; }

        public static Venta operator +(Venta unaVenta, int idProducto)
        {
            Producto unProducto = (unaVenta == idProducto);

            if (unProducto != null && unProducto.Cantidad > 0)
            {
                unProducto.Cantidad = 1;
                unaVenta.ListaProductos.Add(unProducto);

            }
            else
            {
                throw new VentaException("No se pudo cargar el producto a la lista.");
            }

            return unaVenta;

        }

        public static Producto operator ==(Venta unaVenta, int idProducto)
        {
            Producto unProducto = null;

            foreach (var item in Comercio.ListaProductos)
            {
                if (item.Id == idProducto)
                {
                    unProducto = item;
                    break;
                }
            }

            return unProducto;
        }

        public static Producto operator !=(Venta unaVenta, int idVenta)
        {
            Producto unProducto = null;

            foreach (var item in Comercio.ListaProductos)
            {
                if (item.Id != idVenta)
                {
                    unProducto = item;
                    break;
                }
            }

            return unProducto;
        }

        public static bool operator ==(List<Venta> listaVentas, Venta unaVenta)
        {
            foreach (Venta venta in listaVentas)
            {
                if(venta.IdVenta == unaVenta.IdVenta )
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator != (List<Venta> listaVentas, Venta unaVenta)
        {
            return !(listaVentas==unaVenta);
        }

        public static bool operator + (List<Venta> listaVentas,Venta unaVenta)
        {
            if (listaVentas != unaVenta)
            {
                delegVent.Invoke(unaVenta);

                return true;
            }

            else
                throw new VentaException("No se puede realizar la venta");
        }

        public int NroVenta(List<Venta> listaVentas, Venta unaVenta)
        {
            try
            {
                if (listaVentas + unaVenta)
                {
                    Venta.idVenta++;
                }

                return Venta.idVenta;

            }
            catch (VentaException e)
            {

                throw new VentaException("No se ha cargado ningún numero de venta");
            }
        }

    }
}
