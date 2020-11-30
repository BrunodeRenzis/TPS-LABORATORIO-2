using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.IO;
using Archivos;
namespace Clases_Instansiables
{
    public class Universidad
    {
        #region Campos
        List<Alumno> alumnos;
        List<Jornada> jornada;
        List<Profesor> profesores;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor
        /// </summary>
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.profesores = new List<Profesor>();
            this.jornada = new List<Jornada>();
        }
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }

            set
            {
                this.profesores = value;
            }
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }

            set
            {
                this.jornada = value;
            }
        }

        public Jornada this[int i]
        {
            get
            {
                if (i >= 0 && i < this.jornada.Count)
                {
                    return this.jornada[i];
                }
                else
                {
                    throw new ArchivosException("índice no válido");
                }

            }

            set
            {
                if (i >= 0 && i < this.jornada.Count)
                {
                    this.jornada[i] = value;
                }
                else
                {
                    throw new ArchivosException("índice no válido");
                }

            }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Guarda los datos obtenidos como un Xml
        /// </summary>
        /// <param name="uni"></param>
        /// <returns>Datos guardados</returns>
        public static bool Guardar(Universidad uni)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "universidad.xml");
            Xml<Universidad> universidad = new Xml<Universidad>();

            return universidad.Guardar(path, uni);
        }

        /// <summary>
        /// Lee los datos obtenidos y los desserializa
        /// </summary>
        /// <returns>Datos a leer</returns>

        public static Universidad Leer ()
        {
            Universidad datosALeer = new Universidad();
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "universidad.xml");
            Xml<Universidad> datosUniversidad = new Xml<Universidad>();
            datosUniversidad.Leer(path, out datosALeer);
            return datosALeer;
        }

        /// <summary>
        /// Muestra datos de la universidad
        /// </summary>
        /// <param name="uni"></param>
        /// <returns>Datos jornadas alumnos y profesores</returns>
        private string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--------------JORADAS------------");
            foreach (Jornada jornada in uni.Jornadas)
            {
                sb.AppendLine(jornada.ToString());
            }

            sb.AppendLine("--------------ALUMNOS------------");
            foreach (Alumno alumno in uni.Alumnos)
            {
                sb.AppendLine(alumno.ToString());
            }

            sb.AppendLine("--------------PROFESORES------------");
            foreach (Profesor profesor in uni.Instructores)
            {
                sb.AppendLine(profesor.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Convierte a string datos
        /// </summary>
        /// <returns>Datos convertidos a string</returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }


        #endregion

        #region Sobrecarga Operadores
        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns>true si se encuentra el alumno en la universidad, false si no</returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno alu in g.alumnos)
            {
                if(alu == a)
                {
                    return true;
                }
            }
               return false;
        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns>retorna el == negado</returns>
        public static bool operator !=(Universidad g,Alumno a)
        {
            return !(g==a);
        }

        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns>true si se encuentra la clase del profesor en la universidad, false si no se encuentra</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (var clase in g.jornada)
            {
                if(clase.Instructor == i)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns>Retorna el == negado</returns>
        public static bool operator !=(Universidad g,Profesor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns> unProfesor si el profesor coincide con la clase de la universidad, excepción SinProfesorException si no se ha encontrado</returns>
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (Profesor unProfesor in u.Instructores)
            {
                if(unProfesor == clase)
                {
                    return unProfesor;
                }
            }
            throw new SinProfesorException("No hay profesor para la materia solicitada!");
        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns>unProfesor si no se ha encontrado el profesor en la clase, mensaje SinProfesorException</returns>
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            foreach (Profesor unProfesor in u.profesores)
            {
                if (unProfesor != clase)
                {
                    return unProfesor;
                }
            }

            throw new SinProfesorException();
        }



        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns>Retorna una instancia de Universidad con todos los alumnos que coincidan con una clase seleccionada.</returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Profesor profesorDisponible = (g == clase);
            Jornada jornada = new Jornada(clase, profesorDisponible);

            foreach (Alumno a in g.alumnos)
            {
                if (a == clase)
                {
                    jornada.Alumnos.Add(a);
                }
            }

            g.jornada.Add(jornada);
            return g;
        }

        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns>Lista de alumnos que fueron agregados a la universidad, excepción en el caso de queel alumno ya exista.</returns>
        public static Universidad operator +(Universidad u,Alumno a)
        {
            if (u != a)
            {
                u.alumnos.Add(a);

            }
            else
            {
                throw new AlumnoRepetidoException("El alumno que intenta cargar, ya fue agregado a la lista previamente");
            }

            return u;
        }

        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="u"></param>
        /// <param name="i"></param>
        /// <returns>Retorna todos los profesores cargados en la universidad</returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
            {

                u.profesores.Add(i);
            }

            return u;
        }

        #endregion

        #region Enumerados
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
        #endregion
    }
}
