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
        protected int id;
        protected string nombre;
        protected EMedida medida;
        private ETipo tipo;
        protected double stock;
        protected double tornillos;
        protected double bulones;
        protected double arandelas;
        protected double tuercas;
        protected double lentes;

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
        protected Faro(string nombre, EMedida medida, double stock)
        {
            this.Medida = medida;
            DeterminarMaterialesFaro(medida);
            this.Nombre = nombre;
            this.Stock = stock;
        }

        protected Faro(int id, string nombre, EMedida medida, double stock)
        {
            this.id = id;
            this.nombre = nombre;
            DeterminarMaterialesFaro(medida);
            this.stock = stock;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public EMedida Medida { get => medida; set => medida = value; }
        public double Tornillos { get => tornillos; set => tornillos = value; }
        public double Bulones { get => bulones; set => bulones = value; }
        public double Arandelas { get => arandelas; set => arandelas = value; }
        public double Tuercas { get => tuercas; set => tuercas = value; }
        public double Lentes { get => lentes; set => lentes = value; }
        public double Stock { get => stock; set => stock = value; }
        public int Id { get => id; set => id = value; }
        public ETipo Tipo { get => tipo; set => tipo = value; }

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
                    Arandelas = 4;
                    Bulones = 4;
                    lentes = 2;
                    Tornillos = 4;
                    Tuercas = 4;
                }

                else if (Medida == EMedida.Mediano)
                {
                    Arandelas = 6;
                    Bulones = 6;
                    lentes = 3;
                    Tornillos = 6;
                    Tuercas = 6;
                }

                else if (Medida == EMedida.Grande)
                {
                    Arandelas = 8;
                    Bulones = 8;
                    lentes = 4;
                    Tornillos = 8;
                    Tuercas = 8;
                }

            }

            catch (Exception e)
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

        public enum ETipo
        {
            Lampara,
            Led
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

        public bool Guardar()
        {
            FaroDAO faro = new FaroDAO();
            return faro.InsertarFaro(this);
        }

        /// <summary>
        /// Modificar el objeto Producto en la base de datos
        /// </summary>
        /// <returns>True si se modifico, false caso contrario</returns>
        public bool Modificar()
        {
            FaroDAO faro = new FaroDAO();
            return faro.ModificarFaro(this);
        }


        /// <summary>
        /// Eliminar el objeto Producto de la base de datos
        /// </summary>
        /// <returns>True si se elimino, false caso contrario</returns>
        public bool Eliminar()
        {
            FaroDAO faro = new FaroDAO();
            return faro.EliminarFaro(this);
        }




    }
        
}
