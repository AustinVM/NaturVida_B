namespace Capa_presentacion
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.inventariosToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.vendedoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // inventariosToolStripMenuItem
            // 
            this.inventariosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventariosToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
            this.inventariosToolStripMenuItem.Size = new System.Drawing.Size(95, 23);
            this.inventariosToolStripMenuItem.Text = "Inventarios";
            this.inventariosToolStripMenuItem.Click += new System.EventHandler(this.inventariosToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturaToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendedoresToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(101, 23);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            this.vendedoresToolStripMenuItem.Click += new System.EventHandler(this.vendedoresToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 420);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

