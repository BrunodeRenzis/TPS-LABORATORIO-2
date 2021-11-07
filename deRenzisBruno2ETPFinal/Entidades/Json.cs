using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class Json<T> : IArchivo<T>
    {
        public bool Guardar(string nombre, T datos)
        {
            
            string nombreArchivo =  nombre + ".js";
            try
            {
                JsonSerializerOptions opcionesSerializer = new JsonSerializerOptions();
                opcionesSerializer.WriteIndented = true;
                File.WriteAllText(nombreArchivo, JsonSerializer.Serialize(datos));
                
                return true;
            }

            catch (ArchivoException e)
            {
                throw new ArchivoException("Error al intentar guardar archivo json", e);
            }
        }

        public bool Leer(string archivo, out T datos)
        {
            string informacionRecuperada = String.Empty;
            datos = default;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Archivos-Serializacion\";
            try
            {
                if(Directory.Exists(path))
                {
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string paths in archivosEnElPath)
                    {
                        if (paths.Contains(archivo))
                        {
                            archivo = paths;
                            break;
                        }
                    }

                    if(archivo!=null)
                    {
                        datos = JsonSerializer.Deserialize<T>(File.ReadAllText(archivo));
                    }
                }
                datos = JsonSerializer.Deserialize<T>(archivo);
                return true;
            }

            catch(ArchivoException e)
            {
                throw new ArchivoException("Error al intentar leer archivo json", e);
            }
        }
    }
}
