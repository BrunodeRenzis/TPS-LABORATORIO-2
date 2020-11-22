using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extensiones
    {
        public static double TotalVentas(this List<Venta> listaVentas)
        {
            double montoTotal = 0;

            foreach (Venta unaVenta in listaVentas)
            {
                montoTotal += unaVenta.MontoTotal;
            }

            return montoTotal;
        }
    }
}
