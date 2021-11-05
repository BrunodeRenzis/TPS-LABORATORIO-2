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
        string dni;
        string cuil;
        ESexo sexo;
        public Persona()
        {

        }
        public Persona(int id,string nombre, string apellido, string dni, string cuil, ESexo sexo):this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Cuil = cuil;
            this.Sexo = sexo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Cuil { get => cuil; set => cuil = value; }
        public ESexo Sexo { get => sexo; set => sexo = value; }

        public enum ESexo
        {
            Hombre,
            Mujer,
            Binario,
            NoBinario
        }
    }
}
