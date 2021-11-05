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
        public Cliente():base()
        {
        }

        public Cliente(string nombre, string apellido, string dni, string cuil, ESexo sexo, string direccion,int idCliente):base(idCliente,nombre, apellido, dni, cuil, sexo)
        {
            this.IdCliente = idCliente;
            this.Direccion = direccion;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public static bool operator ==(List<Cliente> clientes, Cliente cliente)
        {
           
                foreach (Cliente clienteComp in Mensajeria.Clientes)
                {
                    if (clienteComp.Equals(cliente))
                        return true;
                }
                    return false;
        }

        public static bool operator !=(List<Cliente> clientes, Cliente cliente)
        {
            return !(clientes == cliente);
        }
        public static List<Cliente> operator +(List<Cliente> clientes, Cliente cliente)
        {
            if (Mensajeria.Clientes != cliente)
            {
                Mensajeria.Clientes.Add(cliente);
                return Mensajeria.Clientes;
            }

            throw new ClienteException("No se pudo agregar cliente");
        }

        public static List<Cliente> operator -(List<Cliente> clientes, Cliente cliente)
        {
            if (Mensajeria.Clientes == cliente)
            {
                Mensajeria.Clientes.Remove(cliente);
                return Mensajeria.Clientes;
            }
            throw new ClienteException("No se pudo eliminar el cliente");
        }

        public static void HardcodearXmlClientes()
        {
            try
            {
                Mensajeria.Clientes.Add(new Cliente("Bruno", "de Renzis", "39104689", "20391046892", Persona.ESexo.Hombre, "Olleros 943", 1));
                Mensajeria.Clientes.Add(new Cliente("Sergio", "Rodilan", "39104689", "20391046892", Persona.ESexo.Hombre, "Combate de juncal 924", 2));
                Mensajeria.Clientes.Add(new Cliente("Elpana", "Dero", "39104689", "20391046892", Persona.ESexo.Hombre, "Alsina 940", 3));
                Mensajeria.Clientes.Add(new Cliente("Silvia", "Acturi", "39104689", "20391046892", Persona.ESexo.Mujer, "Juncal 947", 4));
                Mensajeria.Clientes.Add(new Cliente("Elsof", "Ware", "39104689", "20391046892", Persona.ESexo.Binario, "Ottawa 945", 5));
                Mensajeria.Clientes.Add(new Cliente("Sueños", "Ramico", "39104689", "20391046892", Persona.ESexo.NoBinario, "Leandro N Alem 944", 6));
                Mensajeria.Clientes.Add(new Cliente("Jose", "Caballo", "39104689", "20391046892", Persona.ESexo.Hombre, "Italia 946", 7));
                Mensajeria.GuardarClientes(Mensajeria.Clientes);
            }

            catch (ArchivoException ex)
            {
                throw new ArchivoException("Ha ocurrido un error al serializar", ex.InnerException);
            }
        }
    }
}
