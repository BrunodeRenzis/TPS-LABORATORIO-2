using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Cliente:Persona
    {
        int idCliente;
        string direccion;

        /// <summary>
        /// Constructor por defecto de la clase cliente
        /// </summary>
        public Cliente():base()
        {
        }

        /// <summary>
        /// Constructor parametrizado de la clase Cliente.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="sexo"></param>
        /// <param name="direccion"></param>
        /// <param name="idCliente"></param>
        public Cliente(string nombre, string apellido, ESexo sexo, string direccion,int idCliente):base(idCliente,nombre, apellido, sexo)
        {
            this.IdCliente = idCliente;
            this.Direccion = direccion;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="cliente"></param>
        /// <returns>Retorna true si el cliente ya existe, caso contrario retorna false</returns>
        public static bool operator ==(List<Cliente> clientes, Cliente cliente)
        {
           
                foreach (Cliente clienteComp in Mensajeria.Clientes)
                {
                    if (clienteComp.Equals(cliente))
                        return true;
                }
                    return false;
        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="cliente"></param>
        /// <returns>Retorna false si el cliente ya existe, caso contrario retorna true</returns>
        public static bool operator !=(List<Cliente> clientes, Cliente cliente)
        {
            return !(clientes == cliente);
        }

        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="cliente"></param>
        /// <returns>Retorna la lista de clientes si puede agregarse, caso contrario arroja ClienteException.</returns>
        public static List<Cliente> operator +(List<Cliente> clientes, Cliente cliente)
        {
            if (Mensajeria.Clientes != cliente)
            {
                Mensajeria.Clientes.Add(cliente);
                return Mensajeria.Clientes;
            }

            throw new ClienteException("No se pudo agregar cliente");
        }
        /// <summary>
        /// Sobrecarga del operador -
        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="cliente"></param>
        /// <returns>Retorna la lista de clientes con un cliente removido si se pudo remover, caso contrario arroja excepcion</returns>
        public static List<Cliente> operator -(List<Cliente> clientes, Cliente cliente)
        {
            if (Mensajeria.Clientes == cliente)
            {
                Mensajeria.Clientes.Remove(cliente);
                return Mensajeria.Clientes;
            }
            throw new ClienteException("No se pudo eliminar el cliente");
        }

        /// <summary>
        /// Método utilizado para hardcodear la lista a serialziar de clientes.
        /// </summary>
        public static void HardcodearXmlClientes()
        {
            try
            {
                Mensajeria.Clientes.Add(new Cliente("Bruno", "de Renzis", Persona.ESexo.Hombre, "Olleros 943", 1));
                Mensajeria.Clientes.Add(new Cliente("Sergio", "Rodilan", Persona.ESexo.Hombre, "Combate de juncal 924", 2));
                Mensajeria.Clientes.Add(new Cliente("Elpana", "Dero", Persona.ESexo.Hombre, "Alsina 940", 3));
                Mensajeria.Clientes.Add(new Cliente("Silvia", "Acturi", Persona.ESexo.Mujer, "Juncal 947", 4));
                Mensajeria.Clientes.Add(new Cliente("Elsof", "Ware", Persona.ESexo.Binario, "Ottawa 945", 5));
                Mensajeria.Clientes.Add(new Cliente("Sueños", "Ramico", Persona.ESexo.Binario, "Leandro N Alem 944", 6));
                Mensajeria.Clientes.Add(new Cliente("Jose", "Caballo", Persona.ESexo.Hombre, "Italia 946", 7));
                Mensajeria.GuardarClientes(Mensajeria.Clientes);
            }

            catch (ArchivoException ex)
            {
                throw new ArchivoException("Ha ocurrido un error al serializar", ex.InnerException);
            }
        }

        /// <summary>
        /// Sobrecarga del método Mostrar para la clase cliente.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            return sb.ToString();
        }
    }
}
