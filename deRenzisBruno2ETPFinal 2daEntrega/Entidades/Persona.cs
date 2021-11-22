using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Cliente))]
    public abstract class Persona
    {
        string nombre;
        string apellido;
        ESexo sexo;
        
        /// <summary>
        /// Constructor por defecto de la clase Persona
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// Constructor con parámetros de la clase Persona
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        public Persona(int id,string nombre, string apellido, ESexo sexo):this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Sexo = sexo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public ESexo Sexo { get => sexo; set => sexo = value; }

        /// <summary>
        /// Enumerado de sexo de personas
        /// </summary>
        public enum ESexo
        {
            Hombre,
            Mujer,
            Binario
        }

        /// <summary>
        /// sobrecarga del método ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre}");
            sb.AppendLine($"{this.Apellido}");
            return sb.ToString();
        }


    }
}
