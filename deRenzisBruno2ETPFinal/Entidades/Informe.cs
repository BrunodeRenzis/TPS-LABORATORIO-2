using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Informe
    {
        /// <summary>
        /// Determina que sexo realizó más pedidos
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>Retorna un string con el nombre del sexo con más pedidos.</returns>
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
            else
                return "Todos los sexos realizaron la misma cantidad de pedidos";
            
            return $"El sexo que realizó más pedidos es: {sexoMasPedidos}";

        }

        
        /// <summary>
        /// Da una estadística de cuantos pedidos han sido entregados, están en proceso y cuantos no han sido entregados.
        /// </summary>
        /// <returns></returns>
        public static string EstadisticaEnvios(List<Pedido> lista)
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

        /// <summary>
        /// Determina el producto más pedido.
        /// </summary>
        /// <returns>Retorna un string con el producto más pedido</returns>
        public static string ProductoMasPedido(List<Pedido> lista)
        {
            int contadorVasos = 0;
            int contadorPerfumeAvon = 0;
            int contadorCuchillos = 0;
            int contadorUno = 0;
            int contadorAjedrez = 0;
            int contadorPantalon = 0;
            int contadorSauvage = 0;
            int contadorWok = 0;
            int contadorVestido = 0;
            int contadorMesaPool = 0;
            string nombreProducto = String.Empty;
            foreach (Pedido pedido in lista)
            {
                foreach (Producto producto in pedido.Productos)
                {
                    switch (producto.NombreProducto)
                    {
                        case "Perfume avon":
                            contadorPerfumeAvon++;
                            break;
                        case "Cuchillo chef Tramontia":
                            contadorCuchillos++;
                            break;
                        case "Uno":
                            contadorUno++;
                            break;
                        case "Ajedrez":
                            contadorAjedrez++;
                            break;
                        case "Pantalón chupín":
                            contadorPantalon++;
                            break;
                        case "Sauvage Dior":
                            contadorSauvage++;
                            break;
                        case "Wok Tramontina":
                            contadorWok++;
                            break;
                        case "Vestido Summer Limited Edition":
                            contadorVestido++;
                            break;
                        case "Mesa Pool-PingPong":
                            contadorMesaPool++;
                            break;
                        case "Kit vasos":
                            contadorVasos++;
                            break;
                        default:
                            break;
                    }
                }
            }
            if(contadorWok>contadorVestido && contadorWok>contadorVasos && contadorWok>contadorUno && contadorWok>contadorSauvage && contadorWok>contadorPerfumeAvon && contadorWok>contadorPantalon && contadorWok>contadorMesaPool && contadorWok>contadorCuchillos && contadorWok>contadorAjedrez)
                nombreProducto = "Wok Tramontina";
            if(contadorVestido>contadorWok && contadorVestido>contadorVasos && contadorVestido>contadorUno && contadorVestido>contadorSauvage && contadorVestido>contadorPerfumeAvon && contadorVestido>contadorPantalon && contadorVestido>contadorMesaPool && contadorVestido>contadorCuchillos && contadorVestido>contadorAjedrez)
                nombreProducto = "Vestido Summer Limited Edition";
            if(contadorVasos>contadorVestido && contadorVasos>contadorWok && contadorVasos>contadorUno && contadorVasos>contadorSauvage && contadorVasos>contadorPerfumeAvon && contadorVasos>contadorPantalon && contadorVasos>contadorMesaPool && contadorVasos>contadorCuchillos && contadorVasos>contadorAjedrez)
                nombreProducto = "Kit vasos";
            if(contadorUno>contadorVestido && contadorUno>contadorVasos && contadorUno>contadorWok && contadorUno>contadorSauvage && contadorUno>contadorPerfumeAvon && contadorUno>contadorPantalon && contadorUno>contadorMesaPool && contadorUno>contadorCuchillos && contadorUno>contadorAjedrez)
                nombreProducto = "Uno";
            if(contadorSauvage>contadorVestido && contadorSauvage>contadorVasos && contadorSauvage > contadorUno && contadorSauvage > contadorWok && contadorSauvage > contadorPerfumeAvon && contadorSauvage > contadorPantalon && contadorSauvage > contadorMesaPool && contadorSauvage > contadorCuchillos && contadorSauvage > contadorAjedrez)
                nombreProducto = "Sauvage Dior";
            if(contadorPerfumeAvon>contadorVestido && contadorPerfumeAvon > contadorVasos && contadorPerfumeAvon > contadorUno && contadorPerfumeAvon > contadorSauvage && contadorPerfumeAvon > contadorWok && contadorPerfumeAvon>contadorPantalon && contadorPerfumeAvon > contadorMesaPool && contadorPerfumeAvon > contadorCuchillos && contadorPerfumeAvon > contadorAjedrez)
                nombreProducto = "Perfume Avon";
            if(contadorPantalon>contadorVestido && contadorPantalon > contadorVasos && contadorPantalon > contadorUno && contadorPantalon > contadorSauvage && contadorPantalon > contadorPerfumeAvon && contadorPantalon > contadorWok && contadorPantalon > contadorMesaPool && contadorPantalon>contadorCuchillos && contadorPantalon>contadorAjedrez)
                nombreProducto = "Pantalón chupín";
            if(contadorMesaPool>contadorVestido && contadorMesaPool > contadorVasos && contadorMesaPool > contadorUno && contadorMesaPool > contadorSauvage && contadorMesaPool > contadorPerfumeAvon && contadorMesaPool > contadorPantalon && contadorMesaPool > contadorWok && contadorMesaPool > contadorCuchillos && contadorMesaPool > contadorAjedrez)
                nombreProducto = "Mesa Pool-Ping pong";
            if(contadorCuchillos>contadorVestido && contadorCuchillos > contadorVasos && contadorCuchillos > contadorUno && contadorCuchillos > contadorSauvage && contadorCuchillos > contadorPerfumeAvon && contadorCuchillos > contadorPantalon && contadorCuchillos > contadorMesaPool && contadorCuchillos > contadorWok && contadorCuchillos > contadorAjedrez)
                nombreProducto = "Kit Cuchillos Tramontina";
            if(contadorAjedrez>contadorVestido && contadorAjedrez > contadorVasos && contadorAjedrez > contadorUno && contadorAjedrez > contadorSauvage && contadorAjedrez > contadorPerfumeAvon && contadorAjedrez > contadorPantalon && contadorAjedrez > contadorMesaPool && contadorAjedrez > contadorCuchillos && contadorAjedrez > contadorWok)
                nombreProducto = "Ajedrez";

            return $"El producto más pedido es {nombreProducto} y {CategoriaMasPedida(lista)}";
        }
        
        /// <summary>
        /// Determila la categoría del producto más pedido.
        /// </summary>
        /// <returns>Retorna un string con la categoría más comprada</returns>
        private static string CategoriaMasPedida(List<Pedido> lista)
        {
            int contadorPerfumeria = 0;
            int contadorIndumentaria = 0;
            int contadorEntretenimiento = 0;
            int contadorCocina = 0;
            string categoriaMasPedida = string.Empty;
            foreach (Pedido pedido in lista)
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
        
        /// <summary>
        /// Determina el sexo que más compra una categoría, especificada en el parámetro
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="tipo"></param>
        /// <returns>Retorna un string con el sexo que más compra la categoría seleccionada.</returns>
        public static string SexoQueMasCompraUnaCategoria(List<Pedido> lista,ETipo tipo)
        {
            int contadorMujer = 0;
            int contadorHombre = 0;
            int contadorBinario = 0;
            string sexoMasPedidos = String.Empty;
            foreach (Pedido pedido in lista)
            {
                foreach (Producto producto in pedido.Productos)
                {
                    if (producto.Tipo == tipo && pedido.Cliente.Sexo is Persona.ESexo.Mujer)
                        contadorMujer++;

                    else if (producto.Tipo == tipo && pedido.Cliente.Sexo is Persona.ESexo.Hombre)
                        contadorHombre++;

                    else if (producto.Tipo == tipo && pedido.Cliente.Sexo is Persona.ESexo.Binario)
                        contadorBinario++;
                }
            }

            if (contadorBinario > contadorHombre && contadorBinario > contadorMujer)
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
            if(contadorMujer == contadorHombre && contadorMujer == contadorBinario)
                return "Todos los sexos realizaron la misma cantidad de pedidos de perfumería";

            return $"El sexo que realizó más pedidos de {tipo.ToString()} es: {sexoMasPedidos}";
        }
    }
}
