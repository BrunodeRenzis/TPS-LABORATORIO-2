using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {
        /// <summary>
        /// Inicializa un faro tipo lámpara
        /// </summary>
        /// <param name="faro"></param>
        /// <returns>un faro</returns>
        public static Faro InicializarFaroLampara(Faro faro)
        {
            if (!ValidarProducto(faro))
                faro = new FaroLampara();

            return faro;
        }

        /// <summary>
        /// Inicializa un faro tipo led
        /// </summary>
        /// <param name="faro"></param>
        /// <returns>un faro</returns>
        public static Faro InicializarFaroLed(Faro faro)
        {
            if (!ValidarProducto(faro))
                faro = new FaroLed();

            return faro;
        }

        /// <summary>
        /// Valida los campos del faro
        /// </summary>
        /// <param name="prod"></param>
        /// <returns> true si es un objeto con información, false si es un objeto vacio</returns>
        public static bool ValidarProducto(Faro prod)
        {
            if(prod!=null)
            {
                if(prod.Nombre!=String.Empty && prod.Stock>0)
                    return true;
            }
            
            return false;
        }
    }
}
