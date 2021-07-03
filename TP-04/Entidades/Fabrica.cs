using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Fabrica
    {
        static List<FaroLampara> farosLampara;
        static List<FaroLed> farosLed;

        /// <summary>
        /// Constructor estático que inicializa las listas.
        /// </summary>
        static Fabrica()
        {
            farosLampara = new List<FaroLampara>();
            farosLed = new List<FaroLed>();
        }

        public static List<FaroLampara> FarosLampara { get => farosLampara; set => farosLampara = value; }
        public static List<FaroLed> FarosLed { get => farosLed; set => farosLed = value; }
        
        /// <summary>
        /// Método estático que guarda y serializa los leds.
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>True si pudo crear el archivo, false si no pudo</returns>
        public static bool GuardarLeds(List<FaroLed> lista)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "FarosLed.xml");
            Xml<List<FaroLed>> leds = new Xml<List<FaroLed>>();
            
            return leds.Guardar(path, lista);
        }

        /// <summary>
        /// Método estático que guarda y serializa los faros lámpara.
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>True si pudo crear el archivo, false si no pudo</returns>
        public static bool GuardarLampara(List<FaroLampara> lista)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "FarosLampara.xml");
            Xml<List<FaroLampara>> lampara = new Xml<List<FaroLampara>>();

            return lampara.Guardar(path, lista);
        }

        /// <summary>
        /// Método estático que lee y devuelve leds
        /// </summary>
        /// <returns>La lista de leds a ser serialziada para leer</returns>
        public static List<FaroLed> LeerLeds()
        {
            List<FaroLed> datos = new List<FaroLed>();
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "FarosLed.xml");
            Xml<List<FaroLed>> inv = new Xml<List<FaroLed>>();

            inv.Leer(path, out datos);

            return datos;

        }

        /// <summary>
        /// Método estático que lee y devuelve leds
        /// </summary>
        /// <returns>La lista de faros lámpara a ser serialziada para leer</returns>
        public static List<FaroLampara> LeerLampara()
        {
            List<FaroLampara> datos = new List<FaroLampara>();
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "FarosLampara.xml");
            Xml<List<FaroLampara>> inv = new Xml<List<FaroLampara>>();

            inv.Leer(path, out datos);

            return datos;

        }

        public static void AgregandoFarosLed()
        {
            foreach (Faro unFaro in FarosLed)
            {
                Console.WriteLine($"Agregando faro {unFaro.Nombre} desde hilo leds");
                Thread.Sleep(2000);

            }
        }

        public static void AgregandoFarosLampara()
        {
            foreach (Faro unFaro in FarosLampara)
            {
                Console.WriteLine($"Agregando faro {unFaro.Nombre} desde hilo lampara");
                Thread.Sleep(1500);
            }
        }

    }
}
