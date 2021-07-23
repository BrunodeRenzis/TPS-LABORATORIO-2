
namespace FormProducto
{
    partial class FrmFaroLed
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblMedida = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.cmbBoxMedida = new System.Windows.Forms.ComboBox();
            this.cmbBoxTipoLed = new System.Windows.Forms.ComboBox();
            this.lblTipoLed = new System.Windows.Forms.Label();
            this.txtBoxStockInicial = new System.Windows.Forms.TextBox();
            this.lblStockInicial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(72, 226);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 47);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Location = new System.Drawing.Point(12, 97);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(54, 17);
            this.lblMedida.TabIndex = 12;
            this.lblMedida.Text = "Medida";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(115, 54);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(133, 22);
            this.txtBoxNombre.TabIndex = 9;
            // 
            // cmbBoxMedida
            // 
            this.cmbBoxMedida.FormattingEnabled = true;
            this.cmbBoxMedida.Location = new System.Drawing.Point(115, 97);
            this.cmbBoxMedida.Name = "cmbBoxMedida";
            this.cmbBoxMedida.Size = new System.Drawing.Size(133, 24);
            this.cmbBoxMedida.TabIndex = 11;
            // 
            // cmbBoxTipoLed
            // 
            this.cmbBoxTipoLed.FormattingEnabled = true;
            this.cmbBoxTipoLed.Location = new System.Drawing.Point(117, 136);
            this.cmbBoxTipoLed.Name = "cmbBoxTipoLed";
            this.cmbBoxTipoLed.Size = new System.Drawing.Size(133, 24);
            this.cmbBoxTipoLed.TabIndex = 18;
            // 
            // lblTipoLed
            // 
            this.lblTipoLed.AutoSize = true;
            this.lblTipoLed.Location = new System.Drawing.Point(14, 139);
            this.lblTipoLed.Name = "lblTipoLed";
            this.lblTipoLed.Size = new System.Drawing.Size(60, 17);
            this.lblTipoLed.TabIndex = 30;
            this.lblTipoLed.Text = "TipoLed";
            // 
            // txtBoxStockInicial
            // 
            this.txtBoxStockInicial.Location = new System.Drawing.Point(117, 179);
            this.txtBoxStockInicial.Name = "txtBoxStockInicial";
            this.txtBoxStockInicial.Size = new System.Drawing.Size(132, 22);
            this.txtBoxStockInicial.TabIndex = 19;
            // 
            // lblStockInicial
            // 
            this.lblStockInicial.AutoSize = true;
            this.lblStockInicial.Location = new System.Drawing.Point(11, 179);
            this.lblStockInicial.Name = "lblStockInicial";
            this.lblStockInicial.Size = new System.Drawing.Size(82, 17);
            this.lblStockInicial.TabIndex = 32;
            this.lblStockInicial.Text = "Stock Inicial";
            // 
            // FrmFaroLed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 284);
            this.Controls.Add(this.txtBoxStockInicial);
            this.Controls.Add(this.lblStockInicial);
            this.Controls.Add(this.cmbBoxTipoLed);
            this.Controls.Add(this.lblTipoLed);
            this.Controls.Add(this.cmbBoxMedida);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblMedida);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBoxNombre);
            this.Name = "FrmFaroLed";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmFaroLed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.ComboBox cmbBoxMedida;
        private System.Windows.Forms.ComboBox cmbBoxTipoLed;
        private System.Windows.Forms.Label lblTipoLed;
        private System.Windows.Forms.TextBox txtBoxStockInicial;
        private System.Windows.Forms.Label lblStockInicial;
    }
}