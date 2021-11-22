
namespace deRenzisBruno2ETPFinal
{
    partial class FormPedidos
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
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnNoEntregado = new System.Windows.Forms.Button();
            this.lsProductosPedido = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(12, 19);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowTemplate.Height = 25;
            this.dgvPedidos.Size = new System.Drawing.Size(524, 368);
            this.dgvPedidos.TabIndex = 0;
            this.dgvPedidos.Click += new System.EventHandler(this.dgvPedidos_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(57, 437);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(154, 45);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar entrega";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnNoEntregado
            // 
            this.btnNoEntregado.BackColor = System.Drawing.Color.Red;
            this.btnNoEntregado.Location = new System.Drawing.Point(328, 437);
            this.btnNoEntregado.Name = "btnNoEntregado";
            this.btnNoEntregado.Size = new System.Drawing.Size(154, 45);
            this.btnNoEntregado.TabIndex = 6;
            this.btnNoEntregado.Text = "Cancelar pedido";
            this.btnNoEntregado.UseVisualStyleBackColor = false;
            this.btnNoEntregado.Click += new System.EventHandler(this.btnNoEntregado_Click);
            // 
            // lsProductosPedido
            // 
            this.lsProductosPedido.FormattingEnabled = true;
            this.lsProductosPedido.ItemHeight = 15;
            this.lsProductosPedido.Location = new System.Drawing.Point(12, 500);
            this.lsProductosPedido.Name = "lsProductosPedido";
            this.lsProductosPedido.Size = new System.Drawing.Size(524, 169);
            this.lsProductosPedido.TabIndex = 8;
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 677);
            this.Controls.Add(this.lsProductosPedido);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnNoEntregado);
            this.Controls.Add(this.dgvPedidos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnNoEntregado;
        private System.Windows.Forms.ListBox lsProductosPedido;
    }
}