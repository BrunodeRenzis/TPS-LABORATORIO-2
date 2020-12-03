using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormVentas
{
    public partial class FormPpal : Form
    {
        public FormPpal()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarProducto formProd = new AgregarProducto();
            formProd.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaVenta nuevaVenta = new NuevaVenta();
            nuevaVenta.Show();
        }
    }
}
