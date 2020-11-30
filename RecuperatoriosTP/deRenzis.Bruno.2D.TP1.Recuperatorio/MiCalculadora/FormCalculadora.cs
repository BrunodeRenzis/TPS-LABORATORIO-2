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
namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            
        }
        private void comboBoxOperador_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        
        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            this.txtBoxNro1.Text = "";
            this.txtBoxNro2.Text = "";
            this.comboBoxOperador.Text = "";
            this.lblResultado.Text = "";
        }
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if(this.comboBoxOperador.SelectedItem==null)
            {
                this.comboBoxOperador.Text = "+";
            }

            double resultado = Operar(this.txtBoxNro1.Text, this.txtBoxNro2.Text, this.comboBoxOperador.SelectedItem.ToString());
            string resultadoStr = resultado.ToString();
            lblResultado.Text = resultadoStr;
        }

        private static double Operar(string numb1, string numb2, string operador)
        {
            Numero num1 = new Numero(numb1);
            Numero num2 = new Numero(numb2);
            return Calculadora.Operar(num1, num2, char.Parse(operador));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que desea salir?", "Salir",MessageBoxButtons.YesNo) == DialogResult.Yes)
            { 
                this.Close();
            }
        }

        private void btnCnvABin_Click(object sender, EventArgs e)
        {
            string resultado = lblResultado.Text;
            Numero resultadoDecimal = new Numero();
            lblResultado.Text = resultadoDecimal.DecimalBinario(resultado);
        }

        private void btnCnvADec_Click(object sender, EventArgs e)
        {
            string resultado = lblResultado.Text;
            Numero resultadoBinario = new Numero();
            lblResultado.Text = resultadoBinario.BinarioDecimal(resultado);
        }

    }
}
