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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducto formProd = new FormProducto();
            formProd.Show();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Validaciones.ProductosCargados())
            {
                FormNuevaVenta formVenta = new FormNuevaVenta();
                formVenta.Show();

            }

            else
            {
                MessageBox.Show("No hay productos cargados para realizar ventas");
            }
        }
    }
}
