using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace deRenzisBruno2ETPFinal
{
    public partial class FormNuevoPedido : Form
    {
        Cliente unCliente;
        List<Producto> productosPedido;
        public FormNuevoPedido()
        {
            InitializeComponent();
            productosPedido = new List<Producto>();
            unCliente = new Cliente();
        }

        static FormNuevoPedido()
        {
            
        }

        private void NuevoPedido_Load(object sender, EventArgs e)
        {
            this.dgvClientes.DataSource = Mensajeria.Clientes;
            this.dgvProductos.DataSource = Mensajeria.Productos;
        }

        

        private void ActualizarListaVenta()
        {
            this.lsProductos.DataSource = null;
            this.lsProductos.DataSource = productosPedido;
        }

        void LimpiarListaProductos()
        {
            this.lsProductos.DataSource = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (Producto producto in Mensajeria.Productos)
            {
                if (producto.IdProducto == (int)this.dgvProductos.CurrentRow.Cells["idProducto"].Value)
                {
                    productosPedido.Add(producto);
                    ActualizarListaVenta();
                }
            }
        }

        private void btnCrearPedido_Click(object sender, EventArgs e)
        {
                if (productosPedido.Count >= 1)
                {
                    unCliente.IdCliente = (int)this.dgvClientes.CurrentRow.Cells["IdCliente"].Value;
                    unCliente.Nombre = this.dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                    unCliente.Apellido = this.dgvClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                    unCliente.Sexo = (Persona.ESexo)this.dgvClientes.CurrentRow.Cells["Sexo"].Value;
                    unCliente.Direccion = this.dgvClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                    Pedido nuevoPedido = new Pedido(unCliente, productosPedido, EEstado.Generado);
                    Mensajeria.Pedidos.Add(nuevoPedido);
                    LimpiarListaProductos();
                    unCliente = new Cliente();
                    productosPedido = new List<Producto>();
                }
                else
                    MessageBox.Show("No se puede crear un pedido vacío", "Error");

            
        }
    } 
}
