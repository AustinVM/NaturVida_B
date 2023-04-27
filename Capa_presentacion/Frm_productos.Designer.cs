namespace Capa_presentacion
{
    partial class Frm_productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_productos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblcodigoya = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.cmbproductos = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnConsultarMod = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcionActualizar = new System.Windows.Forms.TextBox();
            this.txtVAlorUnidadActualizar = new System.Windows.Forms.TextBox();
            this.txtCantidadActualizar = new System.Windows.Forms.TextBox();
            this.btnLimpiarmodificar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cmbeliminar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblnombref = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 95);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 357);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblcodigoya);
            this.tabPage1.Controls.Add(this.txtdescripcion);
            this.tabPage1.Controls.Add(this.txtvalor);
            this.tabPage1.Controls.Add(this.txtcantidad);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.btnlimpiar);
            this.tabPage1.Controls.Add(this.btnguardar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblvalor);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresar ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblcodigoya
            // 
            this.lblcodigoya.AutoSize = true;
            this.lblcodigoya.ForeColor = System.Drawing.Color.Red;
            this.lblcodigoya.Location = new System.Drawing.Point(461, 37);
            this.lblcodigoya.Name = "lblcodigoya";
            this.lblcodigoya.Size = new System.Drawing.Size(110, 19);
            this.lblcodigoya.TabIndex = 12;
            this.lblcodigoya.Text = "Código ya existe";
            this.lblcodigoya.Visible = false;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(356, 64);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(266, 25);
            this.txtdescripcion.TabIndex = 11;
            this.txtdescripcion.TextChanged += new System.EventHandler(this.txtdescripcion_TextChanged);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(355, 98);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 25);
            this.txtvalor.TabIndex = 10;
            this.txtvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor_KeyPress);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(355, 134);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 25);
            this.txtcantidad.TabIndex = 9;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(355, 31);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 25);
            this.txtcodigo.TabIndex = 8;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(403, 199);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(99, 33);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(298, 199);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(99, 33);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción:";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(306, 104);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(44, 19);
            this.lblvalor.TabIndex = 4;
            this.lblvalor.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnmostrar);
            this.tabPage2.Controls.Add(this.btnconsultar);
            this.tabPage2.Controls.Add(this.cmbproductos);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(600, 237);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(141, 35);
            this.btnmostrar.TabIndex = 4;
            this.btnmostrar.Text = "Mostrar productos";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(570, 43);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(99, 35);
            this.btnconsultar.TabIndex = 3;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // cmbproductos
            // 
            this.cmbproductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbproductos.FormattingEnabled = true;
            this.cmbproductos.Location = new System.Drawing.Point(176, 48);
            this.cmbproductos.Name = "cmbproductos";
            this.cmbproductos.Size = new System.Drawing.Size(388, 27);
            this.cmbproductos.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(104, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Producto:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(708, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnConsultarMod);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txtDescripcionActualizar);
            this.tabPage3.Controls.Add(this.txtVAlorUnidadActualizar);
            this.tabPage3.Controls.Add(this.txtCantidadActualizar);
            this.tabPage3.Controls.Add(this.btnLimpiarmodificar);
            this.tabPage3.Controls.Add(this.btnActualizar);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(779, 325);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnConsultarMod
            // 
            this.btnConsultarMod.Location = new System.Drawing.Point(470, 238);
            this.btnConsultarMod.Name = "btnConsultarMod";
            this.btnConsultarMod.Size = new System.Drawing.Size(90, 34);
            this.btnConsultarMod.TabIndex = 28;
            this.btnConsultarMod.Text = "Consultar";
            this.btnConsultarMod.UseVisualStyleBackColor = true;
            this.btnConsultarMod.Click += new System.EventHandler(this.btnConsultarAct_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(66, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 19);
            this.label12.TabIndex = 27;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(370, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 27);
            this.comboBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // txtDescripcionActualizar
            // 
            this.txtDescripcionActualizar.Location = new System.Drawing.Point(370, 123);
            this.txtDescripcionActualizar.Name = "txtDescripcionActualizar";
            this.txtDescripcionActualizar.Size = new System.Drawing.Size(173, 25);
            this.txtDescripcionActualizar.TabIndex = 22;
            // 
            // txtVAlorUnidadActualizar
            // 
            this.txtVAlorUnidadActualizar.Location = new System.Drawing.Point(370, 157);
            this.txtVAlorUnidadActualizar.Name = "txtVAlorUnidadActualizar";
            this.txtVAlorUnidadActualizar.Size = new System.Drawing.Size(173, 25);
            this.txtVAlorUnidadActualizar.TabIndex = 21;
            // 
            // txtCantidadActualizar
            // 
            this.txtCantidadActualizar.Location = new System.Drawing.Point(370, 194);
            this.txtCantidadActualizar.Name = "txtCantidadActualizar";
            this.txtCantidadActualizar.Size = new System.Drawing.Size(173, 25);
            this.txtCantidadActualizar.TabIndex = 20;
            // 
            // btnLimpiarmodificar
            // 
            this.btnLimpiarmodificar.Location = new System.Drawing.Point(374, 238);
            this.btnLimpiarmodificar.Name = "btnLimpiarmodificar";
            this.btnLimpiarmodificar.Size = new System.Drawing.Size(90, 34);
            this.btnLimpiarmodificar.TabIndex = 18;
            this.btnLimpiarmodificar.Text = "Limpiar";
            this.btnLimpiarmodificar.UseVisualStyleBackColor = true;
            this.btnLimpiarmodificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(247, 238);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(117, 34);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Descripción:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Valor unidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cantidad:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cmbeliminar);
            this.tabPage4.Controls.Add(this.btnEliminar);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(779, 325);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eliminar ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cmbeliminar
            // 
            this.cmbeliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbeliminar.FormattingEnabled = true;
            this.cmbeliminar.Location = new System.Drawing.Point(244, 82);
            this.cmbeliminar.Name = "cmbeliminar";
            this.cmbeliminar.Size = new System.Drawing.Size(255, 27);
            this.cmbeliminar.TabIndex = 35;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(517, 82);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 32);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(143, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "Descripción:";
            // 
            // lblnombref
            // 
            this.lblnombref.AutoSize = true;
            this.lblnombref.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombref.ForeColor = System.Drawing.Color.Olive;
            this.lblnombref.Location = new System.Drawing.Point(21, 44);
            this.lblnombref.Name = "lblnombref";
            this.lblnombref.Size = new System.Drawing.Size(207, 23);
            this.lblnombref.TabIndex = 0;
            this.lblnombref.Text = "GESTIÓN DE PRODUCTOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(645, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblnombref);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form_productos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblcodigoya;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcionActualizar;
        private System.Windows.Forms.TextBox txtVAlorUnidadActualizar;
        private System.Windows.Forms.TextBox txtCantidadActualizar;
        private System.Windows.Forms.Button btnLimpiarmodificar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.ComboBox cmbproductos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbeliminar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnConsultarMod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblnombref;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}