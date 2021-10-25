
namespace deRenzisBruno2ETPFinal
{
    partial class NuevoPedido
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lvProductos = new System.Windows.Forms.ListView();
            this.lvClientes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(402, 315);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(154, 45);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Crear Pedido";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // lvProductos
            // 
            this.lvProductos.HideSelection = false;
            this.lvProductos.Location = new System.Drawing.Point(12, 12);
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(263, 271);
            this.lvProductos.TabIndex = 1;
            this.lvProductos.UseCompatibleStateImageBehavior = false;
            // 
            // lvClientes
            // 
            this.lvClientes.HideSelection = false;
            this.lvClientes.Location = new System.Drawing.Point(674, 12);
            this.lvClientes.Name = "lvClientes";
            this.lvClientes.Size = new System.Drawing.Size(263, 271);
            this.lvClientes.TabIndex = 2;
            this.lvClientes.UseCompatibleStateImageBehavior = false;
            // 
            // NuevoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 374);
            this.Controls.Add(this.lvClientes);
            this.Controls.Add(this.lvProductos);
            this.Controls.Add(this.btnEnviar);
            this.Name = "NuevoPedido";
            this.Text = "NuevoPedido";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ListView lvProductos;
        private System.Windows.Forms.ListView lvClientes;
    }
}