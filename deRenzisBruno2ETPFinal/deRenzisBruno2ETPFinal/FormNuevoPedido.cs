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
        public FormNuevoPedido()
        {
            InitializeComponent();
        }

        static FormNuevoPedido()
        {
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        private void NuevoPedido_Load(object sender, EventArgs e)
        {
            this.dgvClientes.DataSource = Mensajeria.Clientes;
            this.dgvProductos.DataSource = Mensajeria.Productos;
        }
    }
}
