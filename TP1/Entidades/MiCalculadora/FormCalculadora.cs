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

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            OperadorBox.Text = "+";
        }

        private static double Operar(string numb1, string numb2,string operador)
        {
            Numero num1 = new Numero(numb1);
            Numero num2 = new Numero(numb2);
            return Calculadora.Operar(num1, num2, operador);
        }
        private void BtnConvertirABinario_Click(object sender, EventArgs e)
        {
            string resultado = LblResultado.Text;
            Numero resultadoDecimal = new Numero();
            LblResultado.Text = resultadoDecimal.DecimalBinario(resultado);
        }

        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string resultado = LblResultado.Text;
            Numero resultadoBinario = new Numero();
            LblResultado.Text = resultadoBinario.BinarioDecimal(resultado);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Num1Txt.Text = "";
            Num2Txt.Text = "";
            OperadorBox.Text = "";
            LblResultado.Text = "";
        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(Num1Txt.Text, Num2Txt.Text,OperadorBox.Text);
            string resultadoStr = resultado.ToString();
            LblResultado.Text = resultadoStr;
        }

        private void OperadorBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
