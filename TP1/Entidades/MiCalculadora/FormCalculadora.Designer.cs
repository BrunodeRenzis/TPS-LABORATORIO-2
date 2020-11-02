namespace MiCalculadora
{
    partial class FormCalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculadora));
            this.BtnOperar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnConvertirABinario = new System.Windows.Forms.Button();
            this.BtnDecimal = new System.Windows.Forms.Button();
            this.Num1Txt = new System.Windows.Forms.RichTextBox();
            this.Num2Txt = new System.Windows.Forms.RichTextBox();
            this.OperadorBox = new System.Windows.Forms.ComboBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnOperar
            // 
            this.BtnOperar.Location = new System.Drawing.Point(32, 233);
            this.BtnOperar.Name = "BtnOperar";
            this.BtnOperar.Size = new System.Drawing.Size(170, 42);
            this.BtnOperar.TabIndex = 3;
            this.BtnOperar.Text = "Operar";
            this.BtnOperar.UseVisualStyleBackColor = true;
            this.BtnOperar.Click += new System.EventHandler(this.BtnOperar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(312, 233);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(178, 42);
            this.BtnLimpiar.TabIndex = 4;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(576, 233);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(198, 42);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnConvertirABinario
            // 
            this.BtnConvertirABinario.Location = new System.Drawing.Point(32, 347);
            this.BtnConvertirABinario.Name = "BtnConvertirABinario";
            this.BtnConvertirABinario.Size = new System.Drawing.Size(217, 42);
            this.BtnConvertirABinario.TabIndex = 6;
            this.BtnConvertirABinario.Text = "Convertir a binario";
            this.BtnConvertirABinario.UseVisualStyleBackColor = true;
            this.BtnConvertirABinario.Click += new System.EventHandler(this.BtnConvertirABinario_Click);
            // 
            // BtnDecimal
            // 
            this.BtnDecimal.Location = new System.Drawing.Point(576, 347);
            this.BtnDecimal.Name = "BtnDecimal";
            this.BtnDecimal.Size = new System.Drawing.Size(198, 42);
            this.BtnDecimal.TabIndex = 7;
            this.BtnDecimal.Text = "Convertir a decimal";
            this.BtnDecimal.UseVisualStyleBackColor = true;
            this.BtnDecimal.Click += new System.EventHandler(this.BtnConvertirADecimal_Click);
            // 
            // Num1Txt
            // 
            this.Num1Txt.Location = new System.Drawing.Point(32, 101);
            this.Num1Txt.Name = "Num1Txt";
            this.Num1Txt.Size = new System.Drawing.Size(196, 57);
            this.Num1Txt.TabIndex = 0;
            this.Num1Txt.Text = "";
            // 
            // Num2Txt
            // 
            this.Num2Txt.Location = new System.Drawing.Point(578, 101);
            this.Num2Txt.Name = "Num2Txt";
            this.Num2Txt.Size = new System.Drawing.Size(196, 57);
            this.Num2Txt.TabIndex = 2;
            this.Num2Txt.Text = "";
            // 
            // OperadorBox
            // 
            this.OperadorBox.FormattingEnabled = true;
            this.OperadorBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.OperadorBox.Location = new System.Drawing.Point(278, 116);
            this.OperadorBox.Name = "OperadorBox";
            this.OperadorBox.Size = new System.Drawing.Size(258, 28);
            this.OperadorBox.TabIndex = 1;
            this.OperadorBox.SelectedIndexChanged += new System.EventHandler(this.OperadorBox_SelectedIndexChanged);
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(687, 54);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(0, 20);
            this.LblResultado.TabIndex = 8;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.OperadorBox);
            this.Controls.Add(this.Num2Txt);
            this.Controls.Add(this.Num1Txt);
            this.Controls.Add(this.BtnDecimal);
            this.Controls.Add(this.BtnConvertirABinario);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnOperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Bruno de Renzis 2°D";
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOperar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnConvertirABinario;
        private System.Windows.Forms.Button BtnDecimal;
        private System.Windows.Forms.RichTextBox Num1Txt;
        private System.Windows.Forms.RichTextBox Num2Txt;
        private System.Windows.Forms.ComboBox OperadorBox;
        private System.Windows.Forms.Label LblResultado;
    }
}

