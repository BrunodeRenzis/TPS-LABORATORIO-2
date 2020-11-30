using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Excepciones;
namespace Archivos
{
    public class Xml<T>: IArchivo<T>
    {

        /// <summary>
        /// Lee un archivo xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>retorna true si se logró leer correctamente, false si no.</returns>
        public bool Leer(string archivo, out T datos)
        {
            datos = default;

            try
            {
                if (File.Exists(archivo))
                {
                    using (XmlTextReader reader = new XmlTextReader(archivo))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(T));

                        datos = (T)ser.Deserialize(reader);

                        return true;
                    }
                }
            }
            catch (Exception e)
            {

                throw new ArchivosException("Error al intentar leer archivo xml");
            }

            return false;
        }

        /// <summary>
        /// Guarda un archivo xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>retorna true si se logró guardar correctamente, false si no.</returns>
        public bool Guardar(string archivo, T datos)
        {
            try
            {
                if (archivo != null)
                {
                    using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(T));

                        ser.Serialize(writer, datos);

                        return true;
                    }
                }
            }
            catch (Exception e)
            {

                throw new ArchivosException("Error al intentar guardar archivo xml");
            }

            return false;
        }
    }
}
