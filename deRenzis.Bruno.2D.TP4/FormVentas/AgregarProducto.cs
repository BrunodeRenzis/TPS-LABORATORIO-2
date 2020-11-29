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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }



        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            this.comboBoxTipo.DataSource = Enum.GetValues(typeof(Producto.ETipoProducto));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                Producto auxProd;

                if((Producto.ETipoProducto)this.comboBoxTipo.SelectedValue == Producto.ETipoProducto.CadenaFrio)
                {
                    auxProd = new ProductoCadenaFrio(this.textBoxNombre.Text, double.Parse(this.textBoxPrecio.Text), Producto.ETipoProducto.CadenaFrio,int.Parse(this.textBoxCantidad.Text));

                    if(auxProd+Comercio.ListaProductos)
                    {
                        MessageBox.Show("Producto cargado");
                    }
                }

                else
                {
                    auxProd = new ProductoSinCadenaFrio(this.textBoxNombre.Text, double.Parse(this.textBoxPrecio.Text), Producto.ETipoProducto.SinCadenaFrio, int.Parse(this.textBoxCantidad.Text));
                    
                    if(auxProd+Comercio.ListaProductos)
                    {
                        MessageBox.Show("Producto agregado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
