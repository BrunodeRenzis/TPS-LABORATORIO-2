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
namespace FormProducto
{
    public partial class FrmAgregarMateriales : Form
    {
        StockDAO stock = new StockDAO();
        public FrmAgregarMateriales()
        {
            InitializeComponent();
        }

        private void LimpiarTextBox()
        {
            textBoxArandelas.Text = "";
            textBoxBulones.Text = "";
            textBoxLentes.Text = "";
            textBoxTornillos.Text = "";
            textBoxTuercas.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double auxArandelas=0;
            double auxBulones=0;
            double auxLentes=0;
            double auxTornillos=0;
            double auxTuercas=0;
            try
            {
                if (double.TryParse(this.textBoxArandelas.Text, out auxArandelas) && double.TryParse(this.textBoxBulones.Text, out auxBulones) && double.TryParse(this.textBoxLentes.Text, out auxLentes) && double.TryParse(this.textBoxTornillos.Text, out auxTornillos) && double.TryParse(this.textBoxTuercas.Text, out auxTuercas))
                {
                    stock.AgregarMateriales(auxArandelas,auxBulones,auxLentes,auxTornillos,auxTuercas);
                    MessageBox.Show("Materiales agregados");
                    Inventario.ActualizarDatos();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("No se ha ingresado un valor válido, vuelva a intentar");
                    LimpiarTextBox();
                }
                
            }

            catch(FaroException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
