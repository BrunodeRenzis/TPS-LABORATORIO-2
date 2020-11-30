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
            this.txtBoxNro1 = new System.Windows.Forms.TextBox();
            this.comboBoxOperador = new System.Windows.Forms.ComboBox();
            this.txtBoxNro2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCnvABin = new System.Windows.Forms.Button();
            this.btnCnvADec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxNro1
            // 
            this.txtBoxNro1.Location = new System.Drawing.Point(23, 147);
            this.txtBoxNro1.Name = "txtBoxNro1";
            this.txtBoxNro1.Size = new System.Drawing.Size(145, 22);
            this.txtBoxNro1.TabIndex = 0;
            // 
            // comboBoxOperador
            // 
            this.comboBoxOperador.FormattingEnabled = true;
            this.comboBoxOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxOperador.Location = new System.Drawing.Point(319, 147);
            this.comboBoxOperador.Name = "comboBoxOperador";
            this.comboBoxOperador.Size = new System.Drawing.Size(121, 24);
            this.comboBoxOperador.TabIndex = 1;
            this.comboBoxOperador.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperador_SelectedIndexChanged);
            // 
            // txtBoxNro2
            // 
            this.txtBoxNro2.Location = new System.Drawing.Point(579, 147);
            this.txtBoxNro2.Name = "txtBoxNro2";
            this.txtBoxNro2.Size = new System.Drawing.Size(145, 22);
            this.txtBoxNro2.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(709, 60);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 17);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(37, 233);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(113, 54);
            this.btnOperar.TabIndex = 4;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(319, 233);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(113, 54);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(579, 233);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(113, 54);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCnvABin
            // 
            this.btnCnvABin.Location = new System.Drawing.Point(108, 362);
            this.btnCnvABin.Name = "btnCnvABin";
            this.btnCnvABin.Size = new System.Drawing.Size(226, 54);
            this.btnCnvABin.TabIndex = 7;
            this.btnCnvABin.Text = "Convertir a binario";
            this.btnCnvABin.UseVisualStyleBackColor = true;
            this.btnCnvABin.Click += new System.EventHandler(this.btnCnvABin_Click);
            // 
            // btnCnvADec
            // 
            this.btnCnvADec.Location = new System.Drawing.Point(383, 362);
            this.btnCnvADec.Name = "btnCnvADec";
            this.btnCnvADec.Size = new System.Drawing.Size(252, 54);
            this.btnCnvADec.TabIndex = 8;
            this.btnCnvADec.Text = "Convertir a decimal";
            this.btnCnvADec.UseVisualStyleBackColor = true;
            this.btnCnvADec.Click += new System.EventHandler(this.btnCnvADec_Click);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 477);
            this.Controls.Add(this.btnCnvADec);
            this.Controls.Add(this.btnCnvABin);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtBoxNro2);
            this.Controls.Add(this.comboBoxOperador);
            this.Controls.Add(this.txtBoxNro1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Bruno de Renzis 2D";
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNro1;
        private System.Windows.Forms.ComboBox comboBoxOperador;
        private System.Windows.Forms.TextBox txtBoxNro2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCnvABin;
        private System.Windows.Forms.Button btnCnvADec;
    }
}

