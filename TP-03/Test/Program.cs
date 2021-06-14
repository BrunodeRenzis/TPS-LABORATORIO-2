using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Test
{
    class Program
    {
        /// <summary>
        /// Aplicación de consola para testear la aplicación de carga de faros.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Faro> faros = new List<Faro>();
            FaroLampara fLamp = new FaroLampara("Faro prueba",Faro.EMedida.Grande,20);
            FaroLed fLed = new FaroLed("Faro Prueba led",Faro.EMedida.Chico,20,FaroLed.ETipoLed.Micro);


            try
            {
                faros.Add(fLamp);
                if (faros != fLamp)
                {
                    faros.Add(fLamp);
                }

                faros.Add(fLed);
                if(faros!=fLed)
                {
                    faros.Add(fLed);

                }
                Console.Write($"Faros Agregados: \n{MostrarFaros(faros)}");
            }

            catch(Exception e)
            {
                Console.WriteLine(new FaroException("No se ha podido mostrar la lista", e));
            }
                Console.ReadKey();
        }

        public static string MostrarFaros(List<Faro> faros)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Faro item in faros)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();

        }

    }
}
