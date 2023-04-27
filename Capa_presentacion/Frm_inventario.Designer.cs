
namespace Capa_presentacion
{
    partial class Frm_inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_inventario));
            this.cbo_productoIn = new System.Windows.Forms.ComboBox();
            this.btn_consultarIn = new System.Windows.Forms.Button();
            this.btn_mostrarIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_inventario = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_productoIn
            // 
            this.cbo_productoIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_productoIn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_productoIn.FormattingEnabled = true;
            this.cbo_productoIn.Location = new System.Drawing.Point(289, 66);
            this.cbo_productoIn.Name = "cbo_productoIn";
            this.cbo_productoIn.Size = new System.Drawing.Size(334, 25);
            this.cbo_productoIn.TabIndex = 0;
            // 
            // btn_consultarIn
            // 
            this.btn_consultarIn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultarIn.Location = new System.Drawing.Point(432, 97);
            this.btn_consultarIn.Name = "btn_consultarIn";
            this.btn_consultarIn.Size = new System.Drawing.Size(75, 28);
            this.btn_consultarIn.TabIndex = 1;
            this.btn_consultarIn.Text = "Consultar";
            this.btn_consultarIn.UseVisualStyleBackColor = true;
            this.btn_consultarIn.Click += new System.EventHandler(this.btn_consultarIn_Click);
            // 
            // btn_mostrarIn
            // 
            this.btn_mostrarIn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrarIn.Location = new System.Drawing.Point(609, 343);
            this.btn_mostrarIn.Name = "btn_mostrarIn";
            this.btn_mostrarIn.Size = new System.Drawing.Size(91, 33);
            this.btn_mostrarIn.TabIndex = 2;
            this.btn_mostrarIn.Text = "Mostrar";
            this.btn_mostrarIn.UseVisualStyleBackColor = true;
            this.btn_mostrarIn.Click += new System.EventHandler(this.btn_mostrarIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Producto:";
            // 
            // dtg_inventario
            // 
            this.dtg_inventario.AllowUserToAddRows = false;
            this.dtg_inventario.AllowUserToDeleteRows = false;
            this.dtg_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_inventario.Location = new System.Drawing.Point(104, 146);
            this.dtg_inventario.Name = "dtg_inventario";
            this.dtg_inventario.ReadOnly = true;
            this.dtg_inventario.Size = new System.Drawing.Size(610, 191);
            this.dtg_inventario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(573, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "GESTIÓN DE INVENTARIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtg_inventario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_mostrarIn);
            this.Controls.Add(this.btn_consultarIn);
            this.Controls.Add(this.cbo_productoIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Frm_inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_productoIn;
        private System.Windows.Forms.Button btn_consultarIn;
        private System.Windows.Forms.Button btn_mostrarIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_inventario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}