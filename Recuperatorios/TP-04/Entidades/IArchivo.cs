using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface IArchivo<T>
    {
        /// <summary>
        /// Guarda los datos de un archivo.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>True si pudo guardar cambios, false si no guardó</returns>
        bool Guardar(string archivo, T datos);

        /// <summary>
        /// Lee los datos de un archivo
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>true si se pudo leer el archivo, false si no se pudo leer el archivo.</returns>
        bool Leer(string archivo, out T datos);
    }
}