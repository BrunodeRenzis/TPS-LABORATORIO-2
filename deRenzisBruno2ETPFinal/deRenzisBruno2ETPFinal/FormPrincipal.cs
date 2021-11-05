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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        static FormPrincipal()
        {
            Producto.HardcodearXmlProductos();
            Cliente.HardcodearXmlClientes();
            try
            {
                List<Cliente> clientesLeer = new List<Cliente>();
                List<Producto> productosSerializar = new List<Producto>();

                Xml<List<Cliente>> clientes = new Xml<List<Cliente>>();
                Xml<List<Producto>> productos = new Xml<List<Producto>>();

                string pathClientes = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Clientes.xml");
                string pathProductos = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Productos.xml");

                clientes.Leer(pathClientes, out clientesLeer);
                productos.Leer(pathProductos, out productosSerializar);


            }

            catch (ArchivoException e)
            {
                MessageBox.Show(e.Message, e.InnerException.ToString());
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            { 
                Mensajeria.GuardarPedidos(Mensajeria.Pedidos);
                MessageBox.Show("Lista de Pedidos impreso exitosamente");
            }

            catch (ArchivoException ex)
            {
                MessageBox.Show("Ha ocurrido un error al serializar",ex.InnerException.ToString());
            }
        }

        private void nuevoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNuevoPedido nuevoPedidoForm = new FormNuevoPedido();
            nuevoPedidoForm.ShowDialog();
        }

        private void cocinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInformePerfumeria_Click(object sender, EventArgs e)
        {
           
        }

        private void verPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
