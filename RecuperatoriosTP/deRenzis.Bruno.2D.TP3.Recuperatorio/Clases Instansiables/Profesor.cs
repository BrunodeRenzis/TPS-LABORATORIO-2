using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instansiables
{
    public class Profesor:Universitario
    {
        #region Campos
        Queue<Universidad.EClases> clasesDelDia= new Queue <Universidad.EClases>();
        static Random random;
        #endregion
        #region Constructores
        /// <summary>
        /// Constructor
        /// </summary>
        public Profesor():base()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        static Profesor()
        {
            random = new Random();
        }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public Profesor(int id,string nombre,string apellido,string dni,ENacionalidad nacionalidad):base(nombre,apellido,dni,nacionalidad,id)
        {
            this._randomClases();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Muestra en que clase participa el profesor seleccionado
        /// </summary>
        /// <returns>Datos de la clase en la que participa</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CLASES DEL DIA: ");
            foreach (Universidad.EClases clase in this.clasesDelDia)
            {
                sb.AppendLine(clase.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Asignación de clases random
        /// </summary>
        private void _randomClases()
        {
            for(int i=0;i<2;i++)
            {
                int clase = random.Next(0, 3);

                switch (clase)
                {
                    case 0:
                        clasesDelDia.Enqueue(Universidad.EClases.Laboratorio);
                        break;
                    case 1:
                        clasesDelDia.Enqueue(Universidad.EClases.Legislacion);
                        break;
                    case 2:
                        clasesDelDia.Enqueue(Universidad.EClases.Programacion);
                        break;
                    case 3:
                        clasesDelDia.Enqueue(Universidad.EClases.SPD);
                        break;

                }

            }
        }

        /// <summary>
        /// Muestra datos de las clases
        /// </summary>
        /// <returns>Retorna datos convertidos a string</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }
        
        /// <summary>
        /// Convierte datos de MostrarDatos a string
        /// </summary>
        /// <returns>Retorna datos a string</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns>True si se encuentra la clase del profesor en la universidad, false si no se encuentra</returns>
        public static bool operator == (Profesor i,Universidad.EClases clase)
        {
            foreach (Universidad.EClases clases in i.clasesDelDia)
            {
                if(clases == clase)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns>Retorna el == negado</returns>
        public static bool operator != (Profesor i, Universidad.EClases clase)
        {
            return !(i==clase);
        }
        

        #endregion


    }
}
