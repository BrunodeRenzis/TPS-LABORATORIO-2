﻿using System;
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
    
    public partial class FrmFaroLampara : Form
    {
        public FaroLampara unFaro;
        string nombre;
        Faro.EMedida medida;
        double stockInicial;

        /// <summary>
        /// Inicializa
        /// </summary>
        /// <param name="faroLampara"></param>
        public FrmFaroLampara()
        {
            InitializeComponent();
            this.unFaro = new FaroLampara();
        }

        /// <summary>
        /// Carga principal del formulario faroLampara donde se inicializaran los valores a utilizar para la correcta carga del faro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFaroLampara_Load(object sender, EventArgs e)
        {
            this.cmbBoxMedida.DataSource = Enum.GetValues(typeof(Faro.EMedida));
        }

        /// <summary>
        /// Agrega un elemento a la lista de farosLampara
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                nombre = txtBoxNombre.Text;
                double.TryParse(txtBoxStockInicial.Text, out stockInicial);
                Enum.TryParse<Faro.EMedida>(cmbBoxMedida.SelectedValue.ToString(), out medida);

                Validaciones.InicializarFaroLampara(unFaro);

                unFaro = new FaroLampara(nombre, medida, stockInicial);

                if (Validaciones.ValidarProducto(unFaro) && unFaro!=nombre)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                else
                {
                    MessageBox.Show("El producto ya existe");
                }
            }

            catch (Exception ex)
            {
                throw new FaroException("No se han completado los campos para agregar el faro",ex);
            }
        }
    }
}
