namespace PagoAgilFrba.ListadoEstadistico
{
    partial class estadisticas
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
            this.dataGridCantPagos = new System.Windows.Forms.DataGridView();
            this.Cliente_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_pagos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonTopPagos = new System.Windows.Forms.Button();
            this.botonTopFacturasEmpresa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridMontoRendido = new System.Windows.Forms.DataGridView();
            this.Empresa_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_rendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridPorcentajePago = new System.Windows.Forms.DataGridView();
            this.DNI_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentaje_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCantPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMontoRendido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPorcentajePago)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCantPagos
            // 
            this.dataGridCantPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCantPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente_Nombre,
            this.Cliente_Apellido,
            this.Cliente_Dni,
            this.cantidad_pagos});
            this.dataGridCantPagos.Location = new System.Drawing.Point(39, 221);
            this.dataGridCantPagos.Name = "dataGridCantPagos";
            this.dataGridCantPagos.Size = new System.Drawing.Size(443, 130);
            this.dataGridCantPagos.TabIndex = 0;
            this.dataGridCantPagos.Visible = false;
            // 
            // Cliente_Nombre
            // 
            this.Cliente_Nombre.HeaderText = "Cliente_Nombre";
            this.Cliente_Nombre.Name = "Cliente_Nombre";
            // 
            // Cliente_Apellido
            // 
            this.Cliente_Apellido.HeaderText = "Cliente_Apellido";
            this.Cliente_Apellido.Name = "Cliente_Apellido";
            // 
            // Cliente_Dni
            // 
            this.Cliente_Dni.HeaderText = "Cliente_Dni";
            this.Cliente_Dni.Name = "Cliente_Dni";
            // 
            // cantidad_pagos
            // 
            this.cantidad_pagos.HeaderText = "cantidad_pagos";
            this.cantidad_pagos.Name = "cantidad_pagos";
            // 
            // botonTopPagos
            // 
            this.botonTopPagos.Location = new System.Drawing.Point(39, 82);
            this.botonTopPagos.Name = "botonTopPagos";
            this.botonTopPagos.Size = new System.Drawing.Size(148, 55);
            this.botonTopPagos.TabIndex = 1;
            this.botonTopPagos.Text = "Top 5 pagos por cliente";
            this.botonTopPagos.UseVisualStyleBackColor = true;
            this.botonTopPagos.Click += new System.EventHandler(this.botonTopPagos_Click);
            // 
            // botonTopFacturasEmpresa
            // 
            this.botonTopFacturasEmpresa.Location = new System.Drawing.Point(193, 82);
            this.botonTopFacturasEmpresa.Name = "botonTopFacturasEmpresa";
            this.botonTopFacturasEmpresa.Size = new System.Drawing.Size(148, 55);
            this.botonTopFacturasEmpresa.TabIndex = 2;
            this.botonTopFacturasEmpresa.Text = "Top 5 factruras cobradas por empresa";
            this.botonTopFacturasEmpresa.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "Top 5 empresas con mayor monto rendido";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(193, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 55);
            this.button3.TabIndex = 4;
            this.button3.Text = "Top 5 clientes con mayor porcentaje de pago";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(389, 95);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "Primer trimestre";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(389, 120);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "Segundo trimestre";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(389, 143);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(98, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.Text = "Tercer trimestre";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(389, 166);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(98, 17);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.Text = "Cuarto trimestre";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006"});
            this.comboBox1.Location = new System.Drawing.Point(390, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // dataGridMontoRendido
            // 
            this.dataGridMontoRendido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMontoRendido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Empresa_Nombre,
            this.rubro,
            this.monto_rendido});
            this.dataGridMontoRendido.Location = new System.Drawing.Point(39, 221);
            this.dataGridMontoRendido.Name = "dataGridMontoRendido";
            this.dataGridMontoRendido.Size = new System.Drawing.Size(445, 132);
            this.dataGridMontoRendido.TabIndex = 13;
            this.dataGridMontoRendido.Visible = false;
            // 
            // Empresa_Nombre
            // 
            this.Empresa_Nombre.HeaderText = "Empresa_Nombre";
            this.Empresa_Nombre.Name = "Empresa_Nombre";
            // 
            // rubro
            // 
            this.rubro.HeaderText = "rubro";
            this.rubro.Name = "rubro";
            // 
            // monto_rendido
            // 
            this.monto_rendido.HeaderText = "monto_rendido";
            this.monto_rendido.Name = "monto_rendido";
            // 
            // dataGridPorcentajePago
            // 
            this.dataGridPorcentajePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPorcentajePago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI_Cliente,
            this.ApellidoCliente,
            this.NombreCliente,
            this.porcentaje_pago});
            this.dataGridPorcentajePago.Location = new System.Drawing.Point(40, 218);
            this.dataGridPorcentajePago.Name = "dataGridPorcentajePago";
            this.dataGridPorcentajePago.Size = new System.Drawing.Size(444, 137);
            this.dataGridPorcentajePago.TabIndex = 14;
            this.dataGridPorcentajePago.Visible = false;
            // 
            // DNI_Cliente
            // 
            this.DNI_Cliente.HeaderText = "DNI_Cliente";
            this.DNI_Cliente.Name = "DNI_Cliente";
            // 
            // ApellidoCliente
            // 
            this.ApellidoCliente.HeaderText = "ApellidoCliente";
            this.ApellidoCliente.Name = "ApellidoCliente";
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "NombreCliente";
            this.NombreCliente.Name = "NombreCliente";
            // 
            // porcentaje_pago
            // 
            this.porcentaje_pago.HeaderText = "porcentaje_pago";
            this.porcentaje_pago.Name = "porcentaje_pago";
            // 
            // estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 407);
            this.Controls.Add(this.dataGridPorcentajePago);
            this.Controls.Add(this.dataGridMontoRendido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botonTopFacturasEmpresa);
            this.Controls.Add(this.botonTopPagos);
            this.Controls.Add(this.dataGridCantPagos);
            this.Name = "estadisticas";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCantPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMontoRendido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPorcentajePago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCantPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_pagos;
        private System.Windows.Forms.Button botonTopPagos;
        private System.Windows.Forms.Button botonTopFacturasEmpresa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridMontoRendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_rendido;
        private System.Windows.Forms.DataGridView dataGridPorcentajePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentaje_pago;
    }
}