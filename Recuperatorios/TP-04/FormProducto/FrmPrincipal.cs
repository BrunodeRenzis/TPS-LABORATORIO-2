using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlConnection conexion;
        FaroDAO faroDAO;

        public FrmPrincipal()
        {
            InitializeComponent();
            Inventario.CargarInventario();

            faroDAO = new FaroDAO();
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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                conexion = new SqlConnection("Data Source=.\\sqlexpress; Initial Catalog=FaroStock; Integrated Security=True;");
                VerificarConexion();          
            }

            catch(Exception ex)
            {
                throw new ConexionException("No se pudo establecer la conexión.",ex);
            }
        }

        private void VerificarConexion()
        {
            try
            {
                conexion.Open();                
            }

            catch (ConexionException ex)
            {
                throw new Exception("No se pudo conectar", ex);
            }
        }

        private void CerrarConexion()
        {
            conexion.Close();
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
                    //formFaroLed.unFaroLed.GuardarLed();
                    this.richTxtBoxLed.Text = MostrarListaLeds();
                }          
            }

            catch(NoStockException ex)
            {
                MessageBox.Show("No hay materiales suficientes para agregar el faro");
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
                    //formFaroLampara.unFaro.GuardarLampara();
                    this.richTxtBoxLampara.Text = MostrarListaLampara();
                }

               
            }

            catch (NoStockException ex)
            {
                MessageBox.Show("No hay materiales suficientes para agregar el faro");
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
            CerrarConexion();
        }

        

        private void btnStock_Click(object sender, EventArgs e)
        {
            
        }

        private void stockLámparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string stockTotal = String.Empty;
            MessageBox.Show($"El stock total es de :{stockTotal.AveriguarStockTotalLampara()}");
        }

        private void stockLedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string stockTotal = String.Empty;
            MessageBox.Show($"El stock total es de :{stockTotal.AveriguarStockTotalLed()}");
        }
    }
}
