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
        /// <summary>
        /// Constructor sin parámetros
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        /// <summary>
        /// Constructor con oarámetros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido,int dni, ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.Dni = dni;
        }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {

            this.StringToDNI = dni;

        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Prop Apellido
        /// </summary>
        public string Apellido
        {
            get {return this.apellido;}

            set { this.apellido = ValidarNombreApellido(value); }
        }

        /// <summary>
        /// Prop Nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = ValidarNombreApellido(value); }
        }

        /// <summary>
        /// Prop Nacionalidad
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        /// <summary>
        /// Prop DNI
        /// </summary>
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = ValidarDni(this.nacionalidad,value); }
        }

        /// <summary>
        /// Pror StringToDni
        /// </summary>
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
        /// <summary>
        /// Valida que el dni ingresado sea válido tanto como para argentino o extranjero
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dni"></param>
        /// <returns>Retorna el valor validado</returns>
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

        /// <summary>
        /// Convierte el string a int del número de dni
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dni"></param>
        /// <returns>retorna el número de dni validado o una excepcion si el dni es incorrecto</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dni)
        {
            int dniAux;
            if (!int.TryParse(dni, out dniAux))
            {
                dniAux = 0;
                throw new DniInvalidoException("El dni ingresado no es válido");
            }

            return this.ValidarDni(nacionalidad,dniAux);
        }

        /// <summary>
        /// Valida el nombre y apellido de una persona
        /// </summary>
        /// <param name="nombreCompleto"></param>
        /// <returns>retorna el nombre completo validado</returns>
        private string ValidarNombreApellido(string nombreCompleto)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(nombreCompleto, "^[a-zA-Z ]"))
            {
                nombreCompleto = string.Empty;
            }
            return nombreCompleto;
        }

        /// <summary>
        /// Retorna una persona convertida a string.
        /// </summary>
        /// <returns>sb.ToString</returns>
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
