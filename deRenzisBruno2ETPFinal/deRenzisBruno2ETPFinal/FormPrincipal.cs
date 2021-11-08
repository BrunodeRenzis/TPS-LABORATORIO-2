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
            try
            {
                List<Cliente> clientesLeer = new List<Cliente>();
                List<Producto> productosLeer = new List<Producto>();
                List<Pedido> pedidosLeer = new List<Pedido>();

                Xml<List<Cliente>> clientes = new Xml<List<Cliente>>();
                Xml<List<Producto>> productos = new Xml<List<Producto>>();
                Xml<List<Pedido>> pedidos = new Xml<List<Pedido>>();

                string pathClientes = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Clientes.xml");
                string pathProductos = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Productos.xml");
                string pathPedidos = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Pedidos.xml");
                clientes.Leer(pathClientes, out clientesLeer);
                productos.Leer(pathProductos, out productosLeer);
                pedidos.Leer(pathPedidos, out pedidosLeer);
                Mensajeria.Clientes = clientesLeer;
                Mensajeria.Productos = productosLeer;
                Mensajeria.Pedidos = pedidosLeer;


            }

            catch (ArchivoException e)
            {
                MessageBox.Show(e.Message, e.InnerException.ToString());
            }
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


        private void verPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPedidos frmPedidos = new FormPedidos();
            frmPedidos.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Mensajeria.GuardarClientes(Mensajeria.Clientes);
                MessageBox.Show("Lista de Pedidos impreso exitosamente");
            }

            catch (ArchivoException ex)
            {
                MessageBox.Show("Ha ocurrido un error al serializar", ex.InnerException.ToString());
            }
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Informe.ProductoMasPedido(Mensajeria.Pedidos));
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (Mensajeria.Pedidos.Count > 0)
                MessageBox.Show(Informe.SexoMasPedidos(Mensajeria.Pedidos));
            else
                MessageBox.Show("No hay pedidos para mostrar");
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.lblEstadisticaEnvios.Text = Informe.EstadisticaEnvios(Mensajeria.Pedidos);
        }

        private void FormPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblEstadisticaEnvios.Text = Informe.EstadisticaEnvios(Mensajeria.Pedidos);
        }

        private void btnInformePerfumeria_Click(object sender, EventArgs e)
        {
            if (Mensajeria.Pedidos.Count > 0)
                MessageBox.Show(Informe.SexoQueMasCompraUnaCategoria(Mensajeria.Pedidos,ETipo.Perfumería));
            else
                MessageBox.Show("No hay pedidos para mostrar");
        }

        private void btnIndumentaria_Click(object sender, EventArgs e)
        {
            if (Mensajeria.Pedidos.Count > 0)
                MessageBox.Show(Informe.SexoQueMasCompraUnaCategoria(Mensajeria.Pedidos,ETipo.Indumentaria));
            else
                MessageBox.Show("No hay pedidos para mostrar");
        }

        private void btnEntretenimiento_Click(object sender, EventArgs e)
        {
            if (Mensajeria.Pedidos.Count > 0)
                MessageBox.Show(Informe.SexoQueMasCompraUnaCategoria(Mensajeria.Pedidos,ETipo.Entretenimiento));
            else
                MessageBox.Show("No hay pedidos para mostrar");
        }

        private void btnCocina_Click(object sender, EventArgs e)
        {
            if (Mensajeria.Pedidos.Count > 0)
                MessageBox.Show(Informe.SexoQueMasCompraUnaCategoria(Mensajeria.Pedidos,ETipo.Cocina));
            else
                MessageBox.Show("No hay pedidos para mostrar");
        }
    }
}
