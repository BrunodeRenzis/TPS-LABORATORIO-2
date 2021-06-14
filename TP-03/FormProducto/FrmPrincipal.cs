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
    public partial class FrmPrincipal : Form
    {
        
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para mostrar la lsita de faros lámpara
        /// </summary>
        /// <returns></returns>
        private string MostrarListaLeds()
        {
            StringBuilder sb = new StringBuilder();
            foreach (FaroLed item in Fabrica.FarosLed)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
        
        /// <summary>
        /// Método para mostrar la lsita de faros lámpara
        /// </summary>
        /// <returns></returns>
        private string MostrarListaLampara()
        {
            StringBuilder sb = new StringBuilder();
            foreach (FaroLampara item in Fabrica.FarosLampara)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Método para agregar faros de lámpara a la lista farosLampara.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarFaroLed_Click(object sender, EventArgs e)
        {
            try
            {
                FaroLed faroLed = new FaroLed();
                FrmFaroLed formFaroLed = new FrmFaroLed(faroLed);
                if (formFaroLed.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show($"Producto cargado con exito {formFaroLed.unFaroLed.Nombre}");
                    Fabrica.FarosLed.Add(formFaroLed.unFaroLed);
                    this.richTxtBoxProductos.Text = MostrarListaLeds();
                }          
            }

            catch(Exception ex)
            {
                throw new FaroException("No se pudo agregar el faro",ex);
            }
            
        }

        /// <summary>
        /// Método para agregar faros de lámpara a la lista farosLampara.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarFaroLampara_Click(object sender, EventArgs e)
        {
            try
            {
                FaroLampara faroLampara = new FaroLampara();
                FrmFaroLampara formFaroLampara = new FrmFaroLampara();
                if (formFaroLampara.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show($"Faro cargado con exito {formFaroLampara.unFaro.Nombre}");
                    Fabrica.FarosLampara.Add(formFaroLampara.unFaro);
                    this.richTxtBoxClientes.Text = MostrarListaLampara();
                }

               
            }

            catch (Exception ex)
            {
                throw new FaroException("Hubo problemas con el faro", ex);
            }
        }

        /// <summary>
        /// Serialización de listas momentos antes de cerrar la aplicación con el stock final y el consumo de materiales de cada faro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Fabrica.GuardarLampara(Fabrica.FarosLampara);
            Fabrica.GuardarLeds(Fabrica.FarosLed);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
