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
            int contadorPedidos = 0;
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
            if(contadorBinario>contadorHombre && contadorBinario > contadorMujer)
            {
                sexoMasPedidos = "Binario";
                contadorPedidos = contadorBinario;
            }

            if (contadorHombre > contadorBinario && contadorHombre > contadorMujer)
            {
                sexoMasPedidos = "Hombre";
                contadorPedidos = contadorHombre;

            }

            if (contadorMujer > contadorBinario && contadorMujer > contadorHombre)
            {
                sexoMasPedidos = "Mujer";
                contadorPedidos = contadorMujer;

            }
            if (contadorMujer == contadorBinario && contadorMujer > contadorHombre)
            {
                sexoMasPedidos = "Mujer y binario";
                contadorPedidos = contadorBinario;

            }
            if (contadorHombre == contadorBinario && contadorHombre > contadorMujer)
            {
                sexoMasPedidos = "Hombre y binario";
                contadorPedidos = contadorBinario;

            }
            if (contadorMujer == contadorHombre && contadorMujer > contadorBinario)
            {
                sexoMasPedidos = "Mujer y Hombre";
                contadorPedidos = contadorHombre;
            }
            
            
            return $"El sexo que realizó más pedidos es: {sexoMasPedidos} con {contadorPedidos} pedidos";

        }

        
        public static string PedidosZona()
        {
            int contadorZonaSur = 0;
            int contadorZonaOeste = 0;
            int contadorCaba = 0;
            string zonaMasPedidos = String.Empty;
            foreach (Pedido pedido in Mensajeria.Pedidos)
            {
                if(pedido.Cliente.Localidad == ELocalidad.ZonaSur)
                    contadorZonaSur++;
                
                if (pedido.Cliente.Localidad == ELocalidad.ZonaOeste)
                    contadorZonaOeste++;
                
                if (pedido.Cliente.Localidad == ELocalidad.CABA)
                    contadorCaba++;
                
            }

            if(contadorCaba> contadorZonaOeste && contadorCaba>contadorZonaSur)
                zonaMasPedidos = "CABA";
            if (contadorZonaOeste > contadorCaba && contadorZonaOeste > contadorZonaSur)
                zonaMasPedidos = "Zona Oeste";
            if (contadorZonaSur > contadorCaba && contadorZonaSur > contadorZonaOeste)
                zonaMasPedidos = "Zona Sur";
                
            return $"La zona con más pedidos es: {zonaMasPedidos}";
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
            int contadorPedidos = 0;
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
            if(contadorWok>contadorVestido && contadorWok>contadorVasos && contadorWok>contadorUno && contadorWok>contadorSauvage && contadorWok>contadorPerfumeAvon && contadorWok>contadorPantalon && contadorWok>contadorMesaPool && contadorWok>contadorCuchillos && contadorWok > contadorAjedrez)
            {
                nombreProducto = "Wok Tramontina";
                contadorPedidos = contadorWok;
            }
            if(contadorVestido>contadorWok && contadorVestido>contadorVasos && contadorVestido>contadorUno && contadorVestido>contadorSauvage && contadorVestido>contadorPerfumeAvon && contadorVestido>contadorPantalon && contadorVestido>contadorMesaPool && contadorVestido>contadorCuchillos && contadorVestido>contadorAjedrez)
            {
                nombreProducto = "Vestido Summer Limited Edition";
                contadorPedidos = contadorVestido;

            }
            if (contadorVasos > contadorVestido && contadorVasos > contadorWok && contadorVasos > contadorUno && contadorVasos > contadorSauvage && contadorVasos > contadorPerfumeAvon && contadorVasos > contadorPantalon && contadorVasos > contadorMesaPool && contadorVasos > contadorCuchillos && contadorVasos > contadorAjedrez)
            {
                nombreProducto = "Kit vasos";
                contadorPedidos = contadorVasos;

            }
            if (contadorUno > contadorVestido && contadorUno > contadorVasos && contadorUno > contadorWok && contadorUno > contadorSauvage && contadorUno > contadorPerfumeAvon && contadorUno > contadorPantalon && contadorUno > contadorMesaPool && contadorUno > contadorCuchillos && contadorUno > contadorAjedrez)
            {
                contadorPedidos = contadorUno;
                nombreProducto = "Uno";
            }
            if (contadorSauvage > contadorVestido && contadorSauvage > contadorVasos && contadorSauvage > contadorUno && contadorSauvage > contadorWok && contadorSauvage > contadorPerfumeAvon && contadorSauvage > contadorPantalon && contadorSauvage > contadorMesaPool && contadorSauvage > contadorCuchillos && contadorSauvage > contadorAjedrez)
            {
                contadorPedidos = contadorSauvage;
                nombreProducto = "Sauvage Dior";
            }
            if (contadorPerfumeAvon > contadorVestido && contadorPerfumeAvon > contadorVasos && contadorPerfumeAvon > contadorUno && contadorPerfumeAvon > contadorSauvage && contadorPerfumeAvon > contadorWok && contadorPerfumeAvon > contadorPantalon && contadorPerfumeAvon > contadorMesaPool && contadorPerfumeAvon > contadorCuchillos && contadorPerfumeAvon > contadorAjedrez)
            {
                contadorPedidos = contadorPerfumeAvon;
                nombreProducto = "Perfume Avon";
            }
            if(contadorPantalon>contadorVestido && contadorPantalon > contadorVasos && contadorPantalon > contadorUno && contadorPantalon > contadorSauvage && contadorPantalon > contadorPerfumeAvon && contadorPantalon > contadorWok && contadorPantalon > contadorMesaPool && contadorPantalon>contadorCuchillos && contadorPantalon>contadorAjedrez)
            {
                nombreProducto = "Pantalón chupín";
                contadorPedidos = contadorPantalon;
            }
            if(contadorMesaPool>contadorVestido && contadorMesaPool > contadorVasos && contadorMesaPool > contadorUno && contadorMesaPool > contadorSauvage && contadorMesaPool > contadorPerfumeAvon && contadorMesaPool > contadorPantalon && contadorMesaPool > contadorWok && contadorMesaPool > contadorCuchillos && contadorMesaPool > contadorAjedrez)
            {
                nombreProducto = "Mesa Pool-Ping pong";
                contadorPedidos = contadorMesaPool;
            }
            if (contadorCuchillos > contadorVestido && contadorCuchillos > contadorVasos && contadorCuchillos > contadorUno && contadorCuchillos > contadorSauvage && contadorCuchillos > contadorPerfumeAvon && contadorCuchillos > contadorPantalon && contadorCuchillos > contadorMesaPool && contadorCuchillos > contadorWok && contadorCuchillos > contadorAjedrez)
            { 
                nombreProducto = "Kit Cuchillos Tramontina";
                contadorPedidos = contadorCuchillos;
            }
            if (contadorAjedrez > contadorVestido && contadorAjedrez > contadorVasos && contadorAjedrez > contadorUno && contadorAjedrez > contadorSauvage && contadorAjedrez > contadorPerfumeAvon && contadorAjedrez > contadorPantalon && contadorAjedrez > contadorMesaPool && contadorAjedrez > contadorCuchillos && contadorAjedrez > contadorWok)
            { 
                nombreProducto = "Ajedrez";
                contadorPedidos = contadorAjedrez;
            } 

            return $"El producto más pedido es {nombreProducto} con {contadorPedidos} pedidos y {CategoriaMasPedida(lista)}";
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
            int contadorCategoriaMasPedida = 0;
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
                {
                    categoriaMasPedida = "Cocina";
                    contadorCategoriaMasPedida = contadorCocina;
                }
                if (contadorEntretenimiento > contadorCocina && contadorEntretenimiento > contadorIndumentaria && contadorEntretenimiento > contadorPerfumeria)
                {
                    categoriaMasPedida = "Entretenimiento";
                    contadorCategoriaMasPedida = contadorEntretenimiento;
                }
                if (contadorIndumentaria > contadorEntretenimiento && contadorIndumentaria > contadorCocina && contadorIndumentaria > contadorPerfumeria)
                {
                    categoriaMasPedida = "Indumentaria";
                    contadorCategoriaMasPedida = contadorIndumentaria;
                }
                if (contadorPerfumeria > contadorEntretenimiento && contadorPerfumeria > contadorIndumentaria && contadorPerfumeria > contadorCocina)
                {
                    categoriaMasPedida = "Perfumería";
                    contadorCategoriaMasPedida = contadorPerfumeria;
                }
            }
                return $"La categoría con más pedidos es: {categoriaMasPedida} con {contadorCategoriaMasPedida} pedidos";
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
            int contadorPedidos = 0;
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
            {
                sexoMasPedidos = "Binario";
                contadorPedidos = contadorBinario;
            }

            if (contadorHombre > contadorBinario && contadorHombre > contadorMujer)
            {
                sexoMasPedidos = "Hombre";
                contadorPedidos = contadorHombre;
            }

            if (contadorMujer > contadorBinario && contadorMujer > contadorHombre)
            {
                sexoMasPedidos = "Mujer";
                contadorPedidos = contadorMujer;
            }
            if (contadorMujer == contadorBinario && contadorMujer > contadorHombre)
            {
                sexoMasPedidos = "Mujer y binario";
                contadorPedidos = contadorMujer;
            }
            if (contadorHombre == contadorBinario && contadorHombre > contadorMujer)
            {
                sexoMasPedidos = "Hombre y binario";
                contadorPedidos = contadorHombre;

            }
            if (contadorMujer == contadorHombre && contadorMujer > contadorBinario)
            {
                sexoMasPedidos = "Mujer y Hombre";
                contadorPedidos = contadorMujer;
            }
            if (contadorMujer == contadorHombre && contadorMujer == contadorBinario)
                return "Todos los sexos realizaron la misma cantidad de pedidos de perfumería";

            return $"El sexo que realizó más pedidos de {tipo} es: {sexoMasPedidos} con {contadorPedidos} pedidos";
        }
    }
}
