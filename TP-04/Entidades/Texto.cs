using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Texto
    {
        public void Escribir(string path, string dato)
        {
            StreamWriter escritor = new StreamWriter(path, true);

            using (escritor)
            {
                escritor.WriteLine(dato);
            }
        }
    }
}
