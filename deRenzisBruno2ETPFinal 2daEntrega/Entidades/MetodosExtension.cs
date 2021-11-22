using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodosExtension
    {
        /// <summary>
        /// Da una estadística de cuantos pedidos han sido entregados, están en proceso y cuantos no han sido entregados.
        /// </summary>
        /// <returns></returns>
        public static string EstadisticaEnvios(this string valor, List<Pedido> lista)
        {
            for(; ; )
            {
                double total = Mensajeria.Pedidos.Count;
                double totalEntregado = 0;
                double totalNoEntregado = 0;
                double totalEnProceso = 0;
                StringBuilder sb = new StringBuilder();
                foreach (Pedido pedido in lista)
                {
                    if (pedido.Estado is EEstado.Generado)
                        totalEnProceso++;

                    else if (pedido.Estado is EEstado.NoEntregado)
                        totalNoEntregado++;

                    else if (pedido.Estado is EEstado.Entregado)
                        totalEntregado++;
                }
                if ((totalEntregado / total) * 100 == 0)
                    sb.AppendLine("No hay pedidos entregados");
                else
                    sb.AppendLine($"El porcentaje de pedidos entregados es de: {((totalEntregado / total) * 100).ToString()}%");
                if ((totalEnProceso / total) * 100 == 0)
                    sb.AppendLine("No hay pedidos en preparación");
                else
                    sb.AppendLine($"El porcentaje de pedidos preparados es de: {((totalEnProceso / total) * 100).ToString()}%");
                if ((totalNoEntregado / total) * 100 == 0)
                    sb.AppendLine("No hay pedidos no entregados");
                else
                    sb.AppendLine($"El porcentaje de pedidos no entregados es de: {((totalNoEntregado / total) * 100).ToString()}%");
                
                return sb.ToString();
            }
        }
    }
}
