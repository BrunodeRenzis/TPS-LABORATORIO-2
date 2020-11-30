using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas

{
    public abstract class Universitario : Persona
    {
        #region Campos
        int legajo;
        #endregion
        #region Constructores
        /// <summary>
        /// Constructor sin parámetros.
        /// </summary>
        public Universitario():base()
        {

        }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="legajo"></param>
        public Universitario(string nombre,string apellido, string dni, ENacionalidad nacionalidad, int legajo):base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion
        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns>true si el dni o legajo de 2 universitarios coinciden, false si no coinciden</returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if (pg1.Equals(pg2) && (pg1.Dni == pg2.Dni || pg1.legajo == pg2.legajo))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns>Operador == negado</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion
        #region Métodos
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Legajo {this.legajo}");
            sb.AppendLine(base.ToString());
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if(ReferenceEquals(this.GetType(),obj.GetType()))
            {
                return true;
            }
            return false;
        }

        protected abstract string ParticiparEnClase();
        #endregion

    }
}
