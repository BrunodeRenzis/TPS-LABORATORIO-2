using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace deRenzisBruno2ETPFinal
{

    public partial class FormPrincipal : Form
    {

        static string estadistica = String.Empty;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        public static async Task<string> TaskEstadistica()
        {

            string mensaje=String.Empty;
            while(true)
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(100);
                    mensaje = estadistica.EstadisticaEnvios(Mensajeria.Pedidos);
                },Mensajeria.Cts.Token);
                return mensaje;
            }
        }

        static FormPrincipal()
        {
            try
            {
                
                List<Pedido> pedidosLeer = new List<Pedido>();
                Xml<List<Pedido>> pedidos = new Xml<List<Pedido>>();

                string pathPedidos = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Pedidos.xml");
                pedidos.Leer(pathPedidos, out pedidosLeer);
                Mensajeria.Pedidos = pedidosLeer;
               
                Task cargarDatos = Task.Run(DB.TraerListasDB);
                cargarDatos.Wait();
                

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
            lblInforme.Text = Informe.ProductoMasPedido(Mensajeria.Pedidos);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (Mensajeria.Pedidos.Count > 0)
                lblInforme.Text = Informe.SexoMasPedidos(Mensajeria.Pedidos);
            else
                MessageBox.Show("No hay pedidos para mostrar");
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            

        }

        private async void FormPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.lblEstadisticaEnvios.InvokeRequired)
                this.lblEstadisticaEnvios.Text = await TaskEstadistica();
            else
                this.lblEstadisticaEnvios.Text = await TaskEstadistica();
        }

        private void btnInformePerfumeria_Click(object sender, EventArgs e)
        {
            if (Mensajeria.Pedidos.Count > 0)
                lblInforme.Text = Informe.SexoQueMasCompraUnaCategoria(Mensajeria.Pedidos,ETipo.Perfumería);
            else
                MessageBox.Show("No hay pedidos para mostrar");
        }

        private void btnIndumentaria_Click(object sender, EventArgs e)
        {
            if (Mensajeria.Pedidos.Count > 0)
                lblInforme.Text = Informe.SexoQueMasCompraUnaCategoria(Mensajeria.Pedidos,ETipo.Indumentaria);
            else
                MessageBox.Show("No hay pedidos para mostrar");
        }

        private void btnEntretenimiento_Click(object sender, EventArgs e)
        {
            if (Mensajeria.Pedidos.Count > 0)
                lblInforme.Text = Informe.SexoQueMasCompraUnaCategoria(Mensajeria.Pedidos,ETipo.Entretenimiento);
            else
                MessageBox.Show("No hay pedidos para mostrar");
        }

        private void btnCocina_Click(object sender, EventArgs e)
        {
            if (Mensajeria.Pedidos.Count > 0)
                lblInforme.Text = Informe.SexoQueMasCompraUnaCategoria(Mensajeria.Pedidos,ETipo.Cocina);
            else
                MessageBox.Show("No hay pedidos para mostrar");
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Mensajeria.GuardarPedidos(Mensajeria.Pedidos);
            }

            catch (ArchivoException ex)
            {
                MessageBox.Show("Ha ocurrido un error al serializar", ex.InnerException.ToString());
            }

        }
    }
}
