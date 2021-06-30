using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FaroLed:Faro
    {
        double leds;
        ETipoLed tipoLed;

        /// <summary>
        /// Constructor por defecto de un faroLed
        /// </summary>
        public FaroLed()
        {

        }

        /// <summary>
        /// Constructor inicializador de propiedades faroLed
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="medida"></param>
        /// <param name="stock"></param>
        /// <param name="tipoLed"></param>
        public FaroLed(int id,string nombre, EMedida medida,double stock, ETipoLed tipoLed):base(id,nombre,medida,stock)
        {
            this.TipoLed = tipoLed;
            this.Leds = leds;
        }

        public double Leds { get => leds; set => leds = value; }
        public ETipoLed TipoLed { get => tipoLed; set => tipoLed = value; }

        /// <summary>
        /// Enumerador de tipos de led
        /// </summary>
        public enum ETipoLed
        {
            Micro,
            DIP,
            SMD,
            COB
        }

        /// <summary>
        /// Método que sobreescribe la información a ser casteada a string
        /// </summary>
        /// <returns> información casteada a string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()}");
            
            sb.AppendLine($"Tipo Led: {TipoLed}");
            return sb.ToString();
        }

        /// <summary>
        /// Métoodo virtual que sobreescribe los materiales necesarios para componer un faro.
        /// </summary>
        /// <param name="medida"></param>
        protected override void DeterminarMaterialesFaro(EMedida medida)
        {
            base.DeterminarMaterialesFaro(medida);
            if (medida == EMedida.Chico)
                leds = 2;

            else if (medida == EMedida.Mediano)
                leds = 4;

            else if (medida == EMedida.Grande)
                leds = 6;
        }
       



    }
}
