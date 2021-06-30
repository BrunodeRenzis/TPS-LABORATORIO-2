using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FaroLampara:Faro
    {
        

        double portalamparas;


        /// <summary>
        /// Constructor por defecto de un faroLampara
        /// </summary>
        public FaroLampara()
        {

        }

        /// <summary>
        /// Constructor inicializador de propiedades faroLed
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="medida"></param>
        /// <param name="stock"></param>
        
        public FaroLampara(int id,string nombre, EMedida medida, double stock):base(id,nombre,medida,stock)
        {
            this.Portalamparas = portalamparas;
        }

        public double Portalamparas { get => portalamparas; set => portalamparas = value; }

        /// <summary>
        /// Método que sobreescribe la información a ser casteada a string
        /// </summary>
        /// <returns> información casteada a string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
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
                portalamparas = 2;

            else if (medida == EMedida.Mediano)
                portalamparas = 4;

            else if (medida == EMedida.Grande)
                portalamparas = 6;
        }

        
    }
}
