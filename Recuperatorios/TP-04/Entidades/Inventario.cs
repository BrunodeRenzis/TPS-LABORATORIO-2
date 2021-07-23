using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public delegate void DelegateStock();
    public class Inventario
    {
        static double tornillos;
        static double bulones;
        static double arandelas;
        static double tuercas;
        static double lentes;
        public static event DelegateStock delStock;

        public static double Tornillos { get => tornillos; set => tornillos = value; }
        public static double Bulones { get => bulones; set => bulones = value; }
        public static double Arandelas { get => arandelas; set => arandelas = value; }
        public static double Tuercas { get => tuercas; set => tuercas = value; }
        public static double Lentes { get => lentes; set => lentes = value; }

        static Inventario()
        {
            delStock += CargarInventario;
            delStock += UpdateInventario;
        }
        

        public static bool VerificarStock(int cantidad, string material)
        {
            switch(material)
            {
                case "tornillos":
                    return Tornillos >= cantidad;

                case "tuercas":
                    return Tuercas >= cantidad;

                case "bulones":
                    return Bulones >= cantidad;

                case "arandelas":
                    return Arandelas >= cantidad;

                case "lentes":
                    return Lentes >= cantidad;

                default:
                    return false;
            }
        }

        public static void ActualizarDatos()
        {
            delStock.Invoke();
        }
        public static void UpdateInventario()
        {
            StockDAO stock = new StockDAO();
            stock.DescontarMateriales();
        }

        public static void CargarInventario()
        {
            StockDAO stock = new StockDAO();

            stock.SelectMateriales();
        }

    }
}
