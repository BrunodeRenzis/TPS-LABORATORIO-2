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
    public delegate Task ActualizarEstadoDelegate();
    public partial class FormPedidos : Form
    {
        public FormPedidos()
        {
            InitializeComponent();
        }

        private void ActualizarDataGrid()
        {
            this.dgvPedidos.DataSource = null;
            this.dgvPedidos.DataSource = Mensajeria.Pedidos;
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            this.dgvPedidos.DataSource = Mensajeria.Pedidos;
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            foreach (Pedido pedido in Mensajeria.Pedidos)
            {
                if(pedido.IdPedido==(int)this.dgvPedidos.CurrentRow.Cells["idPedido"].Value)
                pedido.Estado = EEstado.Entregado;
                
            }

            ActualizarDataGrid();
        }

        private void btnNoEntregado_Click(object sender, EventArgs e)
        {
            foreach (Pedido pedido in Mensajeria.Pedidos)
            {
                if (pedido.IdPedido == (int)this.dgvPedidos.CurrentRow.Cells["idPedido"].Value)
                    pedido.Estado = EEstado.NoEntregado;
            }
            ActualizarDataGrid();

        }

        private void dgvPedidos_Click(object sender, EventArgs e)
        {
            foreach (Pedido pedido in Mensajeria.Pedidos)
            {
                if (pedido.IdPedido == (int)this.dgvPedidos.CurrentRow.Cells["idPedido"].Value)
                    lsProductosPedido.DataSource = pedido.Productos;
            }
        }
    }
}
