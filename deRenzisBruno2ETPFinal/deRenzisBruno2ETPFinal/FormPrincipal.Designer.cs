
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
            this.btnInformePerfumeria = new System.Windows.Forms.Button();
            this.btnIndumentaria = new System.Windows.Forms.Button();
            this.btnEntretenimiento = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnCocina = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEstadisticaEnvios = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInformePerfumeria
            // 
            this.btnInformePerfumeria.Location = new System.Drawing.Point(13, 92);
            this.btnInformePerfumeria.Name = "btnInformePerfumeria";
            this.btnInformePerfumeria.Size = new System.Drawing.Size(154, 136);
            this.btnInformePerfumeria.TabIndex = 0;
            this.btnInformePerfumeria.Text = "Perfumería";
            this.btnInformePerfumeria.UseVisualStyleBackColor = true;
            this.btnInformePerfumeria.Click += new System.EventHandler(this.btnInformePerfumeria_Click);
            // 
            // btnIndumentaria
            // 
            this.btnIndumentaria.Location = new System.Drawing.Point(326, 92);
            this.btnIndumentaria.Name = "btnIndumentaria";
            this.btnIndumentaria.Size = new System.Drawing.Size(154, 136);
            this.btnIndumentaria.TabIndex = 1;
            this.btnIndumentaria.Text = "Indumentaria";
            this.btnIndumentaria.UseVisualStyleBackColor = true;
            this.btnIndumentaria.Click += new System.EventHandler(this.btnIndumentaria_Click);
            // 
            // btnEntretenimiento
            // 
            this.btnEntretenimiento.Location = new System.Drawing.Point(635, 92);
            this.btnEntretenimiento.Name = "btnEntretenimiento";
            this.btnEntretenimiento.Size = new System.Drawing.Size(154, 136);
            this.btnEntretenimiento.TabIndex = 2;
            this.btnEntretenimiento.Text = "Entretenimiento";
            this.btnEntretenimiento.UseVisualStyleBackColor = true;
            this.btnEntretenimiento.Click += new System.EventHandler(this.btnEntretenimiento_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(635, 340);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(154, 136);
            this.btnCliente.TabIndex = 5;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Location = new System.Drawing.Point(326, 340);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(154, 136);
            this.btnPedidos.TabIndex = 4;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnCocina
            // 
            this.btnCocina.Location = new System.Drawing.Point(13, 340);
            this.btnCocina.Name = "btnCocina";
            this.btnCocina.Size = new System.Drawing.Size(154, 136);
            this.btnCocina.TabIndex = 3;
            this.btnCocina.Text = "Cocina";
            this.btnCocina.UseVisualStyleBackColor = true;
            this.btnCocina.Click += new System.EventHandler(this.btnCocina_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.todosToolStripMenuItem.Text = "Pedidos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // nuevoPedidoToolStripMenuItem
            // 
            this.nuevoPedidoToolStripMenuItem.Name = "nuevoPedidoToolStripMenuItem";
            this.nuevoPedidoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoPedidoToolStripMenuItem.Text = "Nuevo Pedido";
            this.nuevoPedidoToolStripMenuItem.Click += new System.EventHandler(this.nuevoPedidoToolStripMenuItem_Click);
            // 
            // verPedidosToolStripMenuItem
            // 
            this.verPedidosToolStripMenuItem.Name = "verPedidosToolStripMenuItem";
            this.verPedidosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verPedidosToolStripMenuItem.Text = "Ver Pedidos";
            this.verPedidosToolStripMenuItem.Click += new System.EventHandler(this.verPedidosToolStripMenuItem_Click);
            // 
            // lblEstadisticaEnvios
            // 
            this.lblEstadisticaEnvios.AutoSize = true;
            this.lblEstadisticaEnvios.Location = new System.Drawing.Point(60, 520);
            this.lblEstadisticaEnvios.Name = "lblEstadisticaEnvios";
            this.lblEstadisticaEnvios.Size = new System.Drawing.Size(0, 15);
            this.lblEstadisticaEnvios.TabIndex = 7;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
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
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormPrincipal_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInformePerfumeria;
        private System.Windows.Forms.Button btnIndumentaria;
        private System.Windows.Forms.Button btnEntretenimiento;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnCocina;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPedidosToolStripMenuItem;
        private System.Windows.Forms.Label lblEstadisticaEnvios;
    }
}

