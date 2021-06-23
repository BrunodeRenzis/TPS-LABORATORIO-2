
namespace FormProducto
{
    partial class FrmFaroLampara
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
            this.txtBoxStockInicial = new System.Windows.Forms.TextBox();
            this.lblStockInicial = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblMedida = new System.Windows.Forms.Label();
            this.cmbBoxMedida = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBoxStockInicial
            // 
            this.txtBoxStockInicial.Location = new System.Drawing.Point(125, 145);
            this.txtBoxStockInicial.Name = "txtBoxStockInicial";
            this.txtBoxStockInicial.Size = new System.Drawing.Size(132, 22);
            this.txtBoxStockInicial.TabIndex = 47;
            // 
            // lblStockInicial
            // 
            this.lblStockInicial.AutoSize = true;
            this.lblStockInicial.Location = new System.Drawing.Point(19, 145);
            this.lblStockInicial.Name = "lblStockInicial";
            this.lblStockInicial.Size = new System.Drawing.Size(82, 17);
            this.lblStockInicial.TabIndex = 55;
            this.lblStockInicial.Text = "Stock Inicial";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(78, 190);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 47);
            this.btnAgregar.TabIndex = 48;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(125, 46);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(133, 22);
            this.txtBoxNombre.TabIndex = 33;
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Location = new System.Drawing.Point(22, 96);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(54, 17);
            this.lblMedida.TabIndex = 38;
            this.lblMedida.Text = "Medida";
            // 
            // cmbBoxMedida
            // 
            this.cmbBoxMedida.FormattingEnabled = true;
            this.cmbBoxMedida.Location = new System.Drawing.Point(125, 96);
            this.cmbBoxMedida.Name = "cmbBoxMedida";
            this.cmbBoxMedida.Size = new System.Drawing.Size(133, 24);
            this.cmbBoxMedida.TabIndex = 37;
            // 
            // FrmFaroLampara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 254);
            this.Controls.Add(this.txtBoxStockInicial);
            this.Controls.Add(this.lblStockInicial);
            this.Controls.Add(this.cmbBoxMedida);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblMedida);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBoxNombre);
            this.Name = "FrmFaroLampara";
            this.Text = "FrmFaroLampara";
            this.Load += new System.EventHandler(this.FrmFaroLampara_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxStockInicial;
        private System.Windows.Forms.Label lblStockInicial;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.ComboBox cmbBoxMedida;
    }
}