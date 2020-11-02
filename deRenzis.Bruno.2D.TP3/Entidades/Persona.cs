using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
namespace Clases_Abstractas
{
    public abstract class Persona
    {
        #region campos
        string apellido;
        int dni;
        ENacionalidad nacionalidad;
        string nombre;
        #endregion

        #region Constructores
        public Persona()
        {

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido,int dni, ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.Dni = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {

            this.StringToDNI = dni;

        }
        #endregion

        #region Propiedades
        public string Apellido
        {
            get {return this.apellido;}

            set { this.apellido = ValidarNombreApellido(value); }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = ValidarNombreApellido(value); }
        }

        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = ValidarDni(this.nacionalidad,value); }
        }

        public string StringToDNI
        {
            set { this.dni = ValidarDni(this.nacionalidad, value); }
        }
        #endregion

        #region Enumerado
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        #endregion

        #region Métodos
        private int ValidarDni(ENacionalidad nacionalidad, int dni)
        {
            if(dni<1 || dni>99999999)
            {
                throw new DniInvalidoException("El dni ingresado no es válido");
            }

            switch(nacionalidad)
            {
                case ENacionalidad.Argentino:
                    if(dni<1 || dni>89999999)
                    {
                        dni = 0;
                        throw new NacionalidadInvalidaException("El dni no es argentino");
                    }
                    
                break;

                case ENacionalidad.Extranjero:
                    if(dni<90000000 || dni>99999999)
                    {
                        dni = 0;
                        throw new NacionalidadInvalidaException("El dni no es extranjero");
                    }
                break;
            }
            return dni;
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dni)
        {
            int dniAux;
            if (string.IsNullOrEmpty(dni) || !int.TryParse(dni, out dniAux))
            {
                dniAux = 0;
                throw new DniInvalidoException("El dni ingresado no es válido");
            }

            return this.ValidarDni(nacionalidad,dniAux);
        }

        private string ValidarNombreApellido(string nombreCompleto)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(nombreCompleto, "^[a-zA-Z ]"))
            {
                nombreCompleto = string.Empty;
            }
            return nombreCompleto;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El nombre es: {this.Nombre}");
            sb.AppendLine($"El apellido es: {this.Apellido}");
            sb.AppendLine($"El dni es: {this.Dni}");
            sb.AppendLine($"La nacionalidad es: {this.Nacionalidad}");

            return sb.ToString();
        }
        #endregion
    }
}
