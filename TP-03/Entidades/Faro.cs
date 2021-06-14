using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    
    [Serializable]
    [XmlInclude(typeof(FaroLed))]
    [XmlInclude(typeof(FaroLampara))]
    public abstract class Faro
    {
        protected string nombre;
        protected EMedida medida;
        protected double tornillos;
        protected double bulones;
        protected double arandelas;
        protected double tuercas;
        protected double lentes;
        protected double stock;

        /// <summary>
        /// Constructor por defecto de un faro
        /// </summary>
        public Faro()
        {

        }

        /// <summary>
        /// Constructor inicializador de propiedades faroLed
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="medida"></param>
        /// <param name="stock"></param>
        protected Faro(string nombre,EMedida medida, double stock)
        {
            this.Medida = medida;
            DeterminarMaterialesFaro(medida);
            this.Nombre = nombre;
            this.Stock = stock;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public EMedida Medida { get => medida; set => medida = value; }
        public double Tornillos { get => tornillos; set => tornillos = value; }
        public double Bulones { get => bulones; set => bulones = value; }
        public double Arandelas { get => arandelas; set => arandelas = value; }
        public double Tuercas { get => tuercas; set => tuercas = value; }
        public double Lentes { get => lentes; set => lentes = value; }
        public double Stock { get => stock; set => stock = value; }

        /// <summary>
        /// Método que sobreescribe la información a ser casteada a string
        /// </summary>
        /// <returns> información casteada a string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre producto: {this.Nombre}");
            sb.AppendLine($"Medida: {this.Medida}");
            sb.AppendLine($"Stock: {this.Stock}");
            return sb.ToString();
        }

        /// <summary>
        /// Métoodo virtual que sobreescribe los materiales necesarios para componer un faro.
        /// </summary>
        /// <param name="medida"></param>
        protected virtual void DeterminarMaterialesFaro(EMedida medida)
        {
            try
            {


                if (medida == EMedida.Chico)
                {
                    Arandelas = 2;
                    Bulones = 2;
                    lentes = 2;
                    Tornillos = 2;
                    Tuercas = 2;
                }

                else if (Medida == EMedida.Mediano)
                {
                    Arandelas = 4;
                    Bulones = 4;
                    lentes = 4;
                    Tornillos = 4;
                    Tuercas = 4;
                }

                else if (Medida == EMedida.Grande)
                {
                    Arandelas = 6;
                    Bulones = 6;
                    lentes = 6;
                    Tornillos = 6;
                    Tuercas = 6;
                }
                
            }

            catch(Exception e)
            {
                throw new FaroException("No se ha determinado la medida del faro", e);
            }
        }

        public enum EMedida
        {
            Chico,
            Mediano,
            Grande
        }

        
        /// <summary>
        /// Método que agrega un faro a la lista si es que este no se encuentra en ella.
        /// </summary>
        /// <param name="faros"></param>
        /// <param name="faro"></param>
        /// <returns></returns>
        public static List<Faro> operator +(List<Faro> faros, Faro faro)
        {
            foreach (Faro faroAux in faros)
            {
                if (faro.Nombre == faroAux.Nombre)
                {
                    return faros;
                }

                else
                {
                    faros.Add(faro);
                }
            }

            return faros;
        }
    }

     

        
}
