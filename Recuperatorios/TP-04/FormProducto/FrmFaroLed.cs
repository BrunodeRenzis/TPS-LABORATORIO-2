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
    public partial class FrmFaroLed : Form
    { 
        public FaroLed unFaroLed;
        string nombre;
        FaroLed.ETipoLed tipoLed;
        FaroLed.EMedida medida;
        double stockInicial;
        public FrmFaroLed(FaroLed unFaroLed)
        {
            InitializeComponent();
            unFaroLed = new FaroLed();
        }

        /// <summary>
        /// Método para reiniciar labels formulario.
        /// </summary>
        private void ResetearLabels()
        {
            this.cmbBoxMedida.Text = "";
            this.cmbBoxTipoLed.Text = "";
            this.txtBoxNombre.Text = "";
        }

        /// <summary>
        /// Carga principal del formulario faroLed donde se inicializaran los valores a utilizar para la correcta carga del faro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFaroLed_Load(object sender, EventArgs e)
        {
            this.cmbBoxMedida.DataSource = Enum.GetValues(typeof(Faro.EMedida));
            this.cmbBoxTipoLed.DataSource = Enum.GetValues(typeof(FaroLed.ETipoLed));
        }

        /// <summary>
        /// Agrega un elemento a la lista de farosLed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                nombre = this.txtBoxNombre.Text;
                double.TryParse(txtBoxStockInicial.Text, out stockInicial);
                Enum.TryParse<Faro.EMedida>(cmbBoxMedida.SelectedValue.ToString(), out medida);
                Enum.TryParse<FaroLed.ETipoLed>(cmbBoxMedida.SelectedValue.ToString(), out tipoLed);

                Validaciones.InicializarFaroLed(unFaroLed);

                unFaroLed = new FaroLed(nombre, medida, stockInicial,tipoLed);
                

                if (Validaciones.ValidarProducto(unFaroLed) && Fabrica.FarosLed != unFaroLed)
                {
                    this.DialogResult = DialogResult.OK;
                    FaroDAO faroDAO = new FaroDAO();
                    faroDAO.InsertarFaroLed(unFaroLed);
                    Inventario.UpdateInventario();
                    this.Close();
                }

                else if (Validaciones.ValidarProducto(unFaroLed) && Fabrica.FarosLed == unFaroLed)
                {
                    MessageBox.Show("El producto ya existe.");

                }

                else if (unFaroLed.Nombre == String.Empty)
                {
                    MessageBox.Show("No se ha ingresado un nombre");
                }

                else if (unFaroLed.Stock<=0)
                {
                    MessageBox.Show("No se ha ingresado una cantidad");
                }
            }

            catch (NullReferenceException nEx)
            {
                MessageBox.Show(nEx.Message);
            }

            catch (NoStockException ex)
            {
                throw new NoStockException("No se han completado los campos para agregar el faro", ex);
            }
        }



    }
}

