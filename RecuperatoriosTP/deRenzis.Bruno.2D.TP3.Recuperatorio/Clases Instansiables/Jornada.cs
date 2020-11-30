using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
namespace Clases_Instansiables
{
    public class Jornada
    {
        #region Campos
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        #endregion
        #region Propiedades
        public List<Alumno> Alumnos
        {
            get {return this.alumnos; }
            set { this.alumnos = value; }
        }

        public Universidad.EClases Clase
        {
            get { return this.clase; }
            set { this.clase = value; }
        }

        public Profesor Instructor
        {
            get { return this.instructor; }
            set { this.instructor = value; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        public Jornada(Universidad.EClases clase, Profesor instructor):this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }
        #endregion

        #region Métodos
        public static bool Guardar(Jornada jornada)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Jornada");
            Texto auxTexto = new Texto();

            return auxTexto.Guardar(path, jornada.ToString());
        }

        public static bool Leer()
        {
            string datos = String.Empty;
            bool retorno = false;
            Texto archivoTexto = new Texto();
            retorno = archivoTexto.Leer("Jornada.txt", out datos);

            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Clase dictada:{this.clase.ToString()} docente a cargo: {this.instructor.ToString()}");
            sb.AppendLine("Alumnos anotados: ");
            foreach (Alumno unAlumno in this.alumnos)
            {
                sb.AppendLine(unAlumno.ToString());
            }
            return sb.ToString();
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga el operador ==
        /// </summary>
        /// <param name="a"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator==(Jornada j, Alumno a)
        {
            foreach(Alumno unAlumno in j.alumnos)
            {
                if(unAlumno == a)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga el operador +
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Jornada operator+(Jornada j,Alumno a)
        {
                if(j!=a)
                {
                    j.alumnos.Add(a);
                }
            
            return j;
            
        }
        /// <summary>
        /// Sobrecarga el operador !=
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        #endregion
    }
}
