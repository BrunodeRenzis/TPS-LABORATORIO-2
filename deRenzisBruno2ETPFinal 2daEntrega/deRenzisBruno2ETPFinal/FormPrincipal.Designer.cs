
namespace deRenzisBruno2ETPFinal
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEstadisticaEnvios = new System.Windows.Forms.Label();
            this.btnInformePerfumeria = new System.Windows.Forms.Button();
            this.btnIndumentaria = new System.Windows.Forms.Button();
            this.btnEntretenimiento = new System.Windows.Forms.Button();
            this.btnCocina = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.lblInforme = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirToolStripMenuItem,
            this.nuevoPedidoToolStripMenuItem,
            this.verPedidosToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.todosToolStripMenuItem});
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.todosToolStripMenuItem.Text = "Pedidos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // nuevoPedidoToolStripMenuItem
            // 
            this.nuevoPedidoToolStripMenuItem.Name = "nuevoPedidoToolStripMenuItem";
            this.nuevoPedidoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.nuevoPedidoToolStripMenuItem.Text = "Nuevo Pedido";
            this.nuevoPedidoToolStripMenuItem.Click += new System.EventHandler(this.nuevoPedidoToolStripMenuItem_Click);
            // 
            // verPedidosToolStripMenuItem
            // 
            this.verPedidosToolStripMenuItem.Name = "verPedidosToolStripMenuItem";
            this.verPedidosToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.verPedidosToolStripMenuItem.Text = "Ver Pedidos";
            this.verPedidosToolStripMenuItem.Click += new System.EventHandler(this.verPedidosToolStripMenuItem_Click);
            // 
            // lblEstadisticaEnvios
            // 
            this.lblEstadisticaEnvios.AutoSize = true;
            this.lblEstadisticaEnvios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstadisticaEnvios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEstadisticaEnvios.Location = new System.Drawing.Point(60, 520);
            this.lblEstadisticaEnvios.Name = "lblEstadisticaEnvios";
            this.lblEstadisticaEnvios.Size = new System.Drawing.Size(0, 20);
            this.lblEstadisticaEnvios.TabIndex = 7;
            // 
            // btnInformePerfumeria
            // 
            this.btnInformePerfumeria.BackColor = System.Drawing.Color.Black;
            this.btnInformePerfumeria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInformePerfumeria.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInformePerfumeria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInformePerfumeria.Location = new System.Drawing.Point(13, 92);
            this.btnInformePerfumeria.Name = "btnInformePerfumeria";
            this.btnInformePerfumeria.Size = new System.Drawing.Size(154, 136);
            this.btnInformePerfumeria.TabIndex = 0;
            this.btnInformePerfumeria.Text = "PERFUMERÍA";
            this.btnInformePerfumeria.UseVisualStyleBackColor = false;
            this.btnInformePerfumeria.Click += new System.EventHandler(this.btnInformePerfumeria_Click);
            // 
            // btnIndumentaria
            // 
            this.btnIndumentaria.BackColor = System.Drawing.Color.Black;
            this.btnIndumentaria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIndumentaria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIndumentaria.Location = new System.Drawing.Point(326, 92);
            this.btnIndumentaria.Name = "btnIndumentaria";
            this.btnIndumentaria.Size = new System.Drawing.Size(154, 136);
            this.btnIndumentaria.TabIndex = 1;
            this.btnIndumentaria.Text = "INDUMENTARIA";
            this.btnIndumentaria.UseVisualStyleBackColor = false;
            this.btnIndumentaria.Click += new System.EventHandler(this.btnIndumentaria_Click);
            // 
            // btnEntretenimiento
            // 
            this.btnEntretenimiento.BackColor = System.Drawing.Color.Black;
            this.btnEntretenimiento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntretenimiento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEntretenimiento.Location = new System.Drawing.Point(635, 92);
            this.btnEntretenimiento.Name = "btnEntretenimiento";
            this.btnEntretenimiento.Size = new System.Drawing.Size(154, 136);
            this.btnEntretenimiento.TabIndex = 2;
            this.btnEntretenimiento.Text = "ENTRETENIMIENTO";
            this.btnEntretenimiento.UseVisualStyleBackColor = false;
            this.btnEntretenimiento.Click += new System.EventHandler(this.btnEntretenimiento_Click);
            // 
            // btnCocina
            // 
            this.btnCocina.BackColor = System.Drawing.Color.Black;
            this.btnCocina.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCocina.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCocina.Location = new System.Drawing.Point(13, 340);
            this.btnCocina.Name = "btnCocina";
            this.btnCocina.Size = new System.Drawing.Size(154, 136);
            this.btnCocina.TabIndex = 3;
            this.btnCocina.Text = "COCINA";
            this.btnCocina.UseVisualStyleBackColor = false;
            this.btnCocina.Click += new System.EventHandler(this.btnCocina_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.Black;
            this.btnPedidos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPedidos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPedidos.Location = new System.Drawing.Point(326, 340);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(154, 136);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.Text = "PEDIDOS";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Black;
            this.btnCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCliente.Location = new System.Drawing.Point(635, 340);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(154, 136);
            this.btnCliente.TabIndex = 5;
            this.btnCliente.Text = "CLIENTES";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // lblInforme
            // 
            this.lblInforme.AutoSize = true;
            this.lblInforme.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInforme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInforme.Location = new System.Drawing.Point(13, 692);
            this.lblInforme.Name = "lblInforme";
            this.lblInforme.Size = new System.Drawing.Size(0, 25);
            this.lblInforme.TabIndex = 8;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(814, 730);
            this.Controls.Add(this.lblInforme);
            this.Controls.Add(this.lblEstadisticaEnvios);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnCocina);
            this.Controls.Add(this.btnEntretenimiento);
            this.Controls.Add(this.btnIndumentaria);
            this.Controls.Add(this.btnInformePerfumeria);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadística Envios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormPrincipal_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPedidosToolStripMenuItem;
        private System.Windows.Forms.Label lblEstadisticaEnvios;
        private System.Windows.Forms.Button btnInformePerfumeria;
        private System.Windows.Forms.Button btnIndumentaria;
        private System.Windows.Forms.Button btnEntretenimiento;
        private System.Windows.Forms.Button btnCocina;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label lblInforme;
    }
}

