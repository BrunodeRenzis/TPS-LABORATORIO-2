
namespace FormProducto
{
    partial class FrmAgregarMateriales
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
            this.lblArandelas = new System.Windows.Forms.Label();
            this.lblBulones = new System.Windows.Forms.Label();
            this.lblLentes = new System.Windows.Forms.Label();
            this.lblTornillos = new System.Windows.Forms.Label();
            this.lblTuercas = new System.Windows.Forms.Label();
            this.textBoxArandelas = new System.Windows.Forms.TextBox();
            this.textBoxBulones = new System.Windows.Forms.TextBox();
            this.textBoxLentes = new System.Windows.Forms.TextBox();
            this.textBoxTornillos = new System.Windows.Forms.TextBox();
            this.textBoxTuercas = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(46, 227);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 42);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblArandelas
            // 
            this.lblArandelas.AutoSize = true;
            this.lblArandelas.Location = new System.Drawing.Point(12, 38);
            this.lblArandelas.Name = "lblArandelas";
            this.lblArandelas.Size = new System.Drawing.Size(54, 13);
            this.lblArandelas.TabIndex = 1;
            this.lblArandelas.Text = "Arandelas";
            // 
            // lblBulones
            // 
            this.lblBulones.AutoSize = true;
            this.lblBulones.Location = new System.Drawing.Point(12, 74);
            this.lblBulones.Name = "lblBulones";
            this.lblBulones.Size = new System.Drawing.Size(45, 13);
            this.lblBulones.TabIndex = 2;
            this.lblBulones.Text = "Bulones";
            // 
            // lblLentes
            // 
            this.lblLentes.AutoSize = true;
            this.lblLentes.Location = new System.Drawing.Point(12, 110);
            this.lblLentes.Name = "lblLentes";
            this.lblLentes.Size = new System.Drawing.Size(39, 13);
            this.lblLentes.TabIndex = 3;
            this.lblLentes.Text = "Lentes";
            // 
            // lblTornillos
            // 
            this.lblTornillos.AutoSize = true;
            this.lblTornillos.Location = new System.Drawing.Point(11, 147);
            this.lblTornillos.Name = "lblTornillos";
            this.lblTornillos.Size = new System.Drawing.Size(46, 13);
            this.lblTornillos.TabIndex = 4;
            this.lblTornillos.Text = "Tornillos";
            // 
            // lblTuercas
            // 
            this.lblTuercas.AutoSize = true;
            this.lblTuercas.Location = new System.Drawing.Point(12, 178);
            this.lblTuercas.Name = "lblTuercas";
            this.lblTuercas.Size = new System.Drawing.Size(46, 13);
            this.lblTuercas.TabIndex = 5;
            this.lblTuercas.Text = "Tuercas";
            // 
            // textBoxArandelas
            // 
            this.textBoxArandelas.Location = new System.Drawing.Point(109, 35);
            this.textBoxArandelas.Name = "textBoxArandelas";
            this.textBoxArandelas.Size = new System.Drawing.Size(100, 20);
            this.textBoxArandelas.TabIndex = 6;
            // 
            // textBoxBulones
            // 
            this.textBoxBulones.Location = new System.Drawing.Point(109, 71);
            this.textBoxBulones.Name = "textBoxBulones";
            this.textBoxBulones.Size = new System.Drawing.Size(100, 20);
            this.textBoxBulones.TabIndex = 7;
            // 
            // textBoxLentes
            // 
            this.textBoxLentes.Location = new System.Drawing.Point(109, 110);
            this.textBoxLentes.Name = "textBoxLentes";
            this.textBoxLentes.Size = new System.Drawing.Size(100, 20);
            this.textBoxLentes.TabIndex = 8;
            // 
            // textBoxTornillos
            // 
            this.textBoxTornillos.Location = new System.Drawing.Point(109, 144);
            this.textBoxTornillos.Name = "textBoxTornillos";
            this.textBoxTornillos.Size = new System.Drawing.Size(100, 20);
            this.textBoxTornillos.TabIndex = 9;
            // 
            // textBoxTuercas
            // 
            this.textBoxTuercas.Location = new System.Drawing.Point(109, 175);
            this.textBoxTuercas.Name = "textBoxTuercas";
            this.textBoxTuercas.Size = new System.Drawing.Size(100, 20);
            this.textBoxTuercas.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(285, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(435, 208);
            this.dataGridView1.TabIndex = 11;
            // 
            // FrmAgregarMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 357);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxTuercas);
            this.Controls.Add(this.textBoxTornillos);
            this.Controls.Add(this.textBoxLentes);
            this.Controls.Add(this.textBoxBulones);
            this.Controls.Add(this.textBoxArandelas);
            this.Controls.Add(this.lblTuercas);
            this.Controls.Add(this.lblTornillos);
            this.Controls.Add(this.lblLentes);
            this.Controls.Add(this.lblBulones);
            this.Controls.Add(this.lblArandelas);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FrmAgregarMateriales";
            this.Text = "FrmAgregarMateriales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblArandelas;
        private System.Windows.Forms.Label lblBulones;
        private System.Windows.Forms.Label lblLentes;
        private System.Windows.Forms.Label lblTornillos;
        private System.Windows.Forms.Label lblTuercas;
        private System.Windows.Forms.TextBox textBoxArandelas;
        private System.Windows.Forms.TextBox textBoxBulones;
        private System.Windows.Forms.TextBox textBoxLentes;
        private System.Windows.Forms.TextBox textBoxTornillos;
        private System.Windows.Forms.TextBox textBoxTuercas;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}