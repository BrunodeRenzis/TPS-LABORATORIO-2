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
        public Persona()
        {

        }
        public Persona(int id,string nombre, string apellido, ESexo sexo):this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Sexo = sexo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public ESexo Sexo { get => sexo; set => sexo = value; }

        public enum ESexo
        {
            Hombre,
            Mujer,
            Binario
        }

        /// <summary>
        /// Creación del método virtual Mostrar, mostrará datos básicos de cualquier persona para que luego se complete la descripción con las diferencias entre cliente o empleado.
        /// </summary>
        /// <returns></returns>
        /*public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre}");
            sb.AppendLine($"{this.Apellido}");
            return sb.ToString();
        }*/

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
