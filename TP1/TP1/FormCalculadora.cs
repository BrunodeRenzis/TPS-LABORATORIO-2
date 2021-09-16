using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Windows.Forms;

namespace TP1
{
    public partial class FormCalculadora : Form
    {
        

        
        
        public FormCalculadora()
        {
            InitializeComponent();
            
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }

      
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "";
            cmbOperador.Text = "";
            btnConvertirADecimal.Enabled = true;
            btnConvertirABinario.Enabled = true;
        }



        private static double Operar(string numero1, string numero2, string operador)
        {
            return Calculadora.Operar(new Operando(numero1), new Operando(numero2), operador);
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
            if (cmbOperador.Text == String.Empty) cmbOperador.Text = "+";
            if (txtNumero1.Text == String.Empty) txtNumero1.Text = "0";
            if (txtNumero2.Text == String.Empty) txtNumero2.Text = "0";

            lstOperaciones.Items.Add(($"{txtNumero1.Text}{cmbOperador.Text}{txtNumero2.Text}={lblResultado.Text}"));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operando.DecimalBinario(lblResultado.Text);

            btnConvertirADecimal.Enabled = lblResultado.Text != "Valor invalido" ? true : false;

            btnConvertirABinario.Enabled = false;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operando.BinarioDecimal(lblResultado.Text);

            btnConvertirABinario.Enabled = lblResultado.Text != "Valor invalido" ? true : false;

            btnConvertirADecimal.Enabled = false;
        }
    }
}
