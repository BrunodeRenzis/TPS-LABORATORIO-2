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
                Mensajeria.Pedidos.Add(new Pedido(new Cliente("Carlos", "Carlin", "12121212", "20121212122", Persona.ESexo.Hombre,"Av siempreviva 222",1), "Pedido",new List<Producto>(), EEstado.NoEntregado));
                Mensajeria.GuardarPedidos(Mensajeria.Pedidos);
                MessageBox.Show("Lista de Pedidos impreso exitosamente");
            }

            catch (ArchivoException ex)
            {
                MessageBox.Show("Ha ocurrido un error al serializar");
            }
        }

        private void nuevoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoPedido nuevoPedidoForm = new NuevoPedido();
            nuevoPedidoForm.ShowDialog();
        }
    }
}
