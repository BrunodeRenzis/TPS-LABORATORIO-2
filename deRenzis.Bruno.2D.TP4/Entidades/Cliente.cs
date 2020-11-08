using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        #region Atributos
        bool clienteHabitual;
        int cantidadCompras;
        #endregion
        
        #region Constructores
        public Cliente(string nombre, string apellido, int dni, int edad, string sexo, bool clienteHabitual, int cantidadCompras) : base(nombre, apellido, dni, edad, sexo)
        {
            this.ClienteHabitual = clienteHabitual;
            this.cantidadCompras = cantidadCompras;
        }

        #endregion

        #region Sobrecarga de operadores
        public static bool operator +(Cliente unCliente, List<Cliente> listaClientes)
        {

           for(int i=0;i<listaClientes.Count;i++)
            {
                if (unCliente.Dni != listaClientes[i].Dni)
                {
                    listaClientes.Add(unCliente);
                    return true;
                }

            }

            return false;

        }
        #endregion
        #region Propiedades
        public bool ClienteHabitual { get => clienteHabitual; set => clienteHabitual = value; }
        public int CantidadCompras { get => cantidadCompras; set => cantidadCompras = value; }
        #endregion
    }

}

