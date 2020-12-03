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

namespace FormVentas
{
    public partial class NuevaVenta : Form
    {
        public NuevaVenta()
        {
            InitializeComponent();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NuevaVenta_Load(object sender, EventArgs e)
        {
            this.comboBoxProducto.DataSource = DB.LeerNombreProductos();
        }
    }
}
