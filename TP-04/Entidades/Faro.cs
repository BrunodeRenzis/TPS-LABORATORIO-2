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
        protected ETipo tipo;
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
        protected Faro(string nombre, EMedida medida, double stock)
        {
            this.Medida = medida;
            DeterminarMaterialesFaro(medida);
            this.Nombre = nombre;
            this.Stock = stock;
        }

        protected Faro(string nombre, double stock)
        {
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
            int arandelas=0, bulones=0, lentes=0, tornillos=0, tuercas=0;
            try
            {

                
                if (medida == EMedida.Chico)
                {
                    arandelas = 4;
                    bulones = 4;
                    lentes = 2;
                    tornillos = 4;
                    tuercas = 4;
                }

                else if (Medida == EMedida.Mediano)
                {
                    arandelas = 6;
                    bulones = 6;
                    lentes = 3;
                    tornillos = 6;
                    tuercas = 6;
                }

                else if (Medida == EMedida.Grande)
                {
                    arandelas = 8;
                    bulones = 8;
                    lentes = 4;
                    tornillos = 8;
                    tuercas = 8;
                }

                string [] materiales = new string[] { "arandelas", "bulones", "lentes", "tornillos", "tuercas" };
                int [] materialesCant = new int[] { arandelas,bulones,lentes,tornillos,tuercas };
                
                for(int i=0;i<materialesCant.Length;i++)
                {
                    if(!(Inventario.VerificarStock(materialesCant[i], materiales[i])))
                    {
                        throw new NoStockException("No hay más materiales para construir");
                    }
                    
                }
                Inventario.Arandelas -= arandelas;
                Inventario.Bulones -= bulones;
                Inventario.Lentes -= lentes;
                Inventario.Tornillos -= tornillos;
                Inventario.Tuercas -= tuercas;
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

        /*public bool Guardar()
        {
            FaroDAO faro = new FaroDAO();
            return faro.InsertarFaro(this);
        }*/

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
