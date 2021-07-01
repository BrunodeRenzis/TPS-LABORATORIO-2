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

            List<FaroLed> farosLed = new List<FaroLed>();
            List<FaroLampara> farosLampara = new List<FaroLampara>();
            FaroLampara fLamp = new FaroLampara("Faro prueba",Faro.EMedida.Grande,20);
            FaroLed fLed = new FaroLed("Faro Prueba led",Faro.EMedida.Chico,20,FaroLed.ETipoLed.Micro);
            FaroLampara fLamp2 = new FaroLampara("Faro prueba 2", Faro.EMedida.Grande, 20);
            FaroLed fLed2 = new FaroLed("Faro Prueba led 2", Faro.EMedida.Chico, 20, FaroLed.ETipoLed.Micro);
            FaroLampara fLamp3 = new FaroLampara("Faro prueba 3", Faro.EMedida.Grande, 20);
            FaroLed fLed3 = new FaroLed("Faro Prueba led 3", Faro.EMedida.Chico, 20, FaroLed.ETipoLed.Micro);

            farosLampara += fLamp;
            farosLampara += fLamp2;
            farosLampara += fLamp;
            farosLampara += fLamp3;

            farosLed += fLed;
            farosLed += fLed2;
            farosLed += fLed3;
            farosLed += fLed2;

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

        public static void MostrarLeds(List<FaroLed> farosLed,FaroLed fLed)
        {
            try
            {
                farosLed.Add(fLed);
                if (fLed != fLed.Nombre)
                {
                    farosLed.Add(fLed);

                }

            }

            catch (Exception e)
            {
                Console.WriteLine(new FaroException("No se ha podido mostrar la lista", e));
            }
        }

        public static void MostrarLampara(List<FaroLampara> farosLampara, FaroLampara fLamp)
        {
            try
            {
                farosLampara.Add(fLamp);
                if (fLamp != fLamp.Nombre)
                {
                    farosLampara.Add(fLamp);

                }

            }

            catch (Exception e)
            {
                Console.WriteLine(new FaroException("No se ha podido mostrar la lista", e));
            }
        }

    }
}
