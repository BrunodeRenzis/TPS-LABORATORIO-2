using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Informe
    {
        public static string SexoMasPedidos(List<Pedido> lista)
        {
            string sexoMasPedidos = string.Empty;
            int contadorBinario = 0;
            int contadorMujer = 0;
            int contadorHombre = 0;
            foreach (Pedido pedido in lista)
            {
                if(pedido.Cliente.Sexo is Persona.ESexo.Binario)
                {
                    contadorBinario++;
                }

                if (pedido.Cliente.Sexo is Persona.ESexo.Hombre)
                {
                    contadorHombre++;
                }

                if (pedido.Cliente.Sexo is Persona.ESexo.Mujer)
                {
                    contadorMujer++;
                }
            }
            if(contadorBinario>contadorHombre && contadorBinario>contadorMujer)
                sexoMasPedidos = "Binario";

            if (contadorHombre > contadorBinario && contadorHombre > contadorMujer)
                sexoMasPedidos = "Hombre";

            if (contadorMujer > contadorBinario && contadorMujer > contadorHombre)
                sexoMasPedidos = "Mujer";
            if (contadorMujer == contadorBinario && contadorMujer > contadorHombre)
                sexoMasPedidos = "Mujer y binario";
            if (contadorHombre == contadorBinario && contadorHombre > contadorMujer)
                sexoMasPedidos = "Hombre y binario";
            if (contadorMujer == contadorHombre && contadorMujer > contadorBinario)
                sexoMasPedidos = "Mujer y Hombre";
            return $"El sexo que realizó más pedidos es: {sexoMasPedidos}";
        }

        

        public static string EstadisticaEnvios()
        {
            double total = Mensajeria.Pedidos.Count;
            double totalEntregado = 0;
            double totalNoEntregado = 0;
            double totalEnProceso = 0;
            StringBuilder sb = new StringBuilder();
            foreach (Pedido pedido in Mensajeria.Pedidos)
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
                sb.AppendLine($"El porcentaje de pedidos entregados es de: {((totalEntregado/total)*100).ToString()}%");
            if((totalEnProceso / total) * 100 == 0)
                sb.AppendLine("No hay pedidos en preparación");
            else
                sb.AppendLine($"El porcentaje de pedidos preparados es de: {((totalEnProceso/total)*100).ToString()}%");
            if ((totalNoEntregado / total) * 100 == 0)
                sb.AppendLine("No hay pedidos no entregados");
            else
                sb.AppendLine($"El porcentaje de pedidos no entregados es de: {((totalNoEntregado/total)*100).ToString()}%");
            return sb.ToString(); 
        }

        public static string ProductoMasPedido()
        {
            Dictionary<string, Producto> productoMasPedido = new Dictionary<string, Producto>();
            string nombreProducto = String.Empty;
            foreach (Pedido pedido in Mensajeria.Pedidos)
            {
                int contadorProductoMasPedido = 1;
                foreach (Producto producto in pedido.Productos)
                {
                    if(!productoMasPedido.ContainsKey(producto.NombreProducto))
                    {
                        productoMasPedido.Add(producto.NombreProducto, producto);
                    }

                    foreach (KeyValuePair<string, Producto> entry in productoMasPedido)
                    {
                        if (entry.Key == producto.NombreProducto)
                            contadorProductoMasPedido++;
                    }
                }
            }

            return $"El producto más pedido es {nombreProducto} y {CategoriaMasPedida()}";
        }
        
        public static string CategoriaMasPedida()
        {
            int contadorPerfumeria = 0;
            int contadorIndumentaria = 0;
            int contadorEntretenimiento = 0;
            int contadorCocina = 0;
            string categoriaMasPedida = string.Empty;
            foreach (Pedido pedido in Mensajeria.Pedidos)
            {
                foreach (Producto producto in pedido.Productos)
                {
                    if (producto.Tipo is ETipo.Perfumería)
                        contadorPerfumeria++;
                    if (producto.Tipo is ETipo.Indumentaria)
                        contadorIndumentaria++;
                    if (producto.Tipo is ETipo.Entretenimiento)
                        contadorEntretenimiento++;
                    if (producto.Tipo is ETipo.Cocina)
                        contadorCocina++;
                }

                if (contadorCocina > contadorEntretenimiento && contadorCocina > contadorIndumentaria && contadorCocina > contadorPerfumeria)
                    categoriaMasPedida = "Cocina";
                if (contadorEntretenimiento > contadorCocina && contadorEntretenimiento > contadorIndumentaria && contadorEntretenimiento > contadorPerfumeria)
                    categoriaMasPedida = "Entretenimiento";
                if (contadorIndumentaria > contadorEntretenimiento && contadorIndumentaria > contadorCocina && contadorIndumentaria > contadorPerfumeria)
                    categoriaMasPedida = "Indumentaria";
                if (contadorPerfumeria > contadorEntretenimiento && contadorPerfumeria > contadorIndumentaria && contadorPerfumeria > contadorCocina)
                    categoriaMasPedida = "Perfumería";
            }
                return $"La categoría con más pedidos es: {categoriaMasPedida}";
        }
        /*
        public static string SexoQueMasCompraPerfumeria()
        {

        }

        public static string SexoQueMasCompraCocina()
        {

        }

        public static string SexoQueMasCompraIndumentaria()
        {

        }

        public static string SexoQueMasCompraEntretenimiento()
        {

        }*/
    }
}
