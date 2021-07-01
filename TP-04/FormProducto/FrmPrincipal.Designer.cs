
namespace FormProducto
{
    partial class FrmPrincipal
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
            this.btnAgregarFaroLed = new System.Windows.Forms.Button();
            this.btnAgregarFaroLampara = new System.Windows.Forms.Button();
            this.richTxtBoxLed = new System.Windows.Forms.RichTextBox();
            this.richTxtBoxLampara = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAgregarFaroLed
            // 
            this.btnAgregarFaroLed.Location = new System.Drawing.Point(19, 35);
            this.btnAgregarFaroLed.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarFaroLed.Name = "btnAgregarFaroLed";
            this.btnAgregarFaroLed.Size = new System.Drawing.Size(135, 37);
            this.btnAgregarFaroLed.TabIndex = 0;
            this.btnAgregarFaroLed.Text = "Agregar Faro Led";
            this.btnAgregarFaroLed.UseVisualStyleBackColor = true;
            this.btnAgregarFaroLed.Click += new System.EventHandler(this.btnAgregarFaroLed_Click);
            // 
            // btnAgregarFaroLampara
            // 
            this.btnAgregarFaroLampara.Location = new System.Drawing.Point(188, 35);
            this.btnAgregarFaroLampara.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarFaroLampara.Name = "btnAgregarFaroLampara";
            this.btnAgregarFaroLampara.Size = new System.Drawing.Size(135, 37);
            this.btnAgregarFaroLampara.TabIndex = 1;
            this.btnAgregarFaroLampara.Text = "Agregar Faro Lampara";
            this.btnAgregarFaroLampara.UseVisualStyleBackColor = true;
            this.btnAgregarFaroLampara.Click += new System.EventHandler(this.btnAgregarFaroLampara_Click);
            // 
            // richTxtBoxLed
            // 
            this.richTxtBoxLed.Location = new System.Drawing.Point(16, 76);
            this.richTxtBoxLed.Margin = new System.Windows.Forms.Padding(2);
            this.richTxtBoxLed.Name = "richTxtBoxLed";
            this.richTxtBoxLed.ReadOnly = true;
            this.richTxtBoxLed.Size = new System.Drawing.Size(138, 276);
            this.richTxtBoxLed.TabIndex = 2;
            this.richTxtBoxLed.Text = "";
            // 
            // richTxtBoxLampara
            // 
            this.richTxtBoxLampara.Location = new System.Drawing.Point(188, 76);
            this.richTxtBoxLampara.Margin = new System.Windows.Forms.Padding(2);
            this.richTxtBoxLampara.Name = "richTxtBoxLampara";
            this.richTxtBoxLampara.ReadOnly = true;
            this.richTxtBoxLampara.Size = new System.Drawing.Size(138, 276);
            this.richTxtBoxLampara.TabIndex = 3;
            this.richTxtBoxLampara.Text = "";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 377);
            this.Controls.Add(this.richTxtBoxLampara);
            this.Controls.Add(this.richTxtBoxLed);
            this.Controls.Add(this.btnAgregarFaroLampara);
            this.Controls.Add(this.btnAgregarFaroLed);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPrincipal";
            this.Text = "Form Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarFaroLed;
        private System.Windows.Forms.Button btnAgregarFaroLampara;
        private System.Windows.Forms.RichTextBox richTxtBoxLed;
        private System.Windows.Forms.RichTextBox richTxtBoxLampara;
    }
}

