using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
            Thread hiloLed = new Thread(Fabrica.AgregandoFarosLed);
            Thread hiloLampara = new Thread(Fabrica.AgregandoFarosLampara);
            List<FaroLed> farosLed = new List<FaroLed>();
            string stockTotal=String.Empty;
            List<FaroLampara> farosLampara = new List<FaroLampara>();
            FaroLampara fLamp = new FaroLampara("Faro prueba",Faro.EMedida.Grande,20);
            FaroLed fLed = new FaroLed("Faro Prueba led",Faro.EMedida.Chico,20,FaroLed.ETipoLed.Micro);
            FaroLampara fLamp2 = new FaroLampara("Faro prueba 2", Faro.EMedida.Grande, 20);
            FaroLed fLed2 = new FaroLed("Faro Prueba led 2", Faro.EMedida.Chico, 20, FaroLed.ETipoLed.Micro);
            FaroLampara fLamp3 = new FaroLampara("Faro prueba 3", Faro.EMedida.Grande, 20);
            FaroLed fLed3 = new FaroLed("Faro Prueba led 3", Faro.EMedida.Chico, 20, FaroLed.ETipoLed.Micro);

            Fabrica.FarosLampara.Add(fLamp);
            Fabrica.FarosLampara.Add(fLamp2);
            Fabrica.FarosLampara.Add(fLamp);
            Fabrica.FarosLampara.Add(fLamp3);

            Fabrica.FarosLed.Add(fLed);
            Fabrica.FarosLed.Add(fLed2);
            Fabrica.FarosLed.Add(fLed3);
            Fabrica.FarosLed.Add(fLed2);

            hiloLampara.Start();
            hiloLed.Start();
            Console.ReadKey();
        }


       

        

    }
}
