using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instansiables
{
    public sealed class Alumno : Universitario
    {
        #region Campos
        EEstadoCuenta estadoCuenta;
        Universidad.EClases claseQueToma;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor
        /// </summary>
        public Alumno():base()
        {

        }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma): base(nombre,apellido,dni,nacionalidad,id)
        {
            this.claseQueToma = claseQueToma;
        }
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta):this(id,nombre,apellido,dni,nacionalidad,claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        


        #endregion

        #region Métodos

        /// <summary>
        /// Muestra los datos de los alumnos
        /// </summary>
        /// <returns>Datos convertidos a string </returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Estado de cuenta: {this.estadoCuenta}");
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }
        /// <summary>
        /// Muestra en que clases participa cada estudiante
        /// </summary>
        /// <returns>Datos convertidos a string</returns>
        protected override string ParticiparEnClase()
        {
            return String.Format($"Clase que toma: {this.claseQueToma}");
        }

        /// <summary>
        /// Convierte datos a string
        /// </summary>
        /// <returns>Datos a string</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

        #region Enumerado
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga el operador ==
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator==(Alumno a,Universidad.EClases clase)
        {
            if(a.estadoCuenta!= EEstadoCuenta.Deudor && a.claseQueToma == clase)
            {
                return true;
            }
            
            return false;
        }

        /// <summary>
        /// Sobrecarga el operador !=
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            if(a.claseQueToma!=clase)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
