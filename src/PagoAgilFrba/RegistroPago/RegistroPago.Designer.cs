namespace PagoAgilFrba.RegistroPago
{
    partial class RegistroPago
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
            this.textBox_fecha_sistema = new System.Windows.Forms.TextBox();
            this.comboBox_empresa = new System.Windows.Forms.ComboBox();
            this.textBox_sucursal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_confirmar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button_agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_cant = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_forma = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_cliente = new System.Windows.Forms.ComboBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.textBox_cliente = new System.Windows.Forms.TextBox();
            this.textBox_empresa = new System.Windows.Forms.TextBox();
            this.button_buscar_cliente = new System.Windows.Forms.Button();
            this.button_buscar_empresa = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView_total = new System.Windows.Forms.DataGridView();
            this.dataGridView_confirmados = new System.Windows.Forms.DataGridView();
            this.button_buscar = new System.Windows.Forms.Button();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_bruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_bruto_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_confirmados)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_fecha_sistema
            // 
            this.textBox_fecha_sistema.Location = new System.Drawing.Point(127, 453);
            this.textBox_fecha_sistema.Name = "textBox_fecha_sistema";
            this.textBox_fecha_sistema.ReadOnly = true;
            this.textBox_fecha_sistema.Size = new System.Drawing.Size(147, 20);
            this.textBox_fecha_sistema.TabIndex = 1;
            // 
            // comboBox_empresa
            // 
            this.comboBox_empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_empresa.FormattingEnabled = true;
            this.comboBox_empresa.Location = new System.Drawing.Point(122, 60);
            this.comboBox_empresa.Name = "comboBox_empresa";
            this.comboBox_empresa.Size = new System.Drawing.Size(147, 21);
            this.comboBox_empresa.TabIndex = 2;
            // 
            // textBox_sucursal
            // 
            this.textBox_sucursal.Location = new System.Drawing.Point(127, 427);
            this.textBox_sucursal.Name = "textBox_sucursal";
            this.textBox_sucursal.ReadOnly = true;
            this.textBox_sucursal.Size = new System.Drawing.Size(147, 20);
            this.textBox_sucursal.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Empresa :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de cobro :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sucursal :";
            // 
            // button_confirmar
            // 
            this.button_confirmar.Location = new System.Drawing.Point(493, 493);
            this.button_confirmar.Name = "button_confirmar";
            this.button_confirmar.Size = new System.Drawing.Size(102, 35);
            this.button_confirmar.TabIndex = 14;
            this.button_confirmar.Text = "Confirmar Pago";
            this.button_confirmar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Registro de Pago";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_agregar
            // 
            this.button_agregar.Location = new System.Drawing.Point(493, 242);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(102, 24);
            this.button_agregar.TabIndex = 16;
            this.button_agregar.Text = "Agregar Factura";
            this.button_agregar.UseVisualStyleBackColor = true;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cantidad de Facturas cargadas: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Importe Total:";
            // 
            // label_cant
            // 
            this.label_cant.AutoSize = true;
            this.label_cant.Location = new System.Drawing.Point(204, 402);
            this.label_cant.Name = "label_cant";
            this.label_cant.Size = new System.Drawing.Size(41, 13);
            this.label_cant.TabIndex = 19;
            this.label_cant.Text = "label10";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(374, 402);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(41, 13);
            this.label_total.TabIndex = 20;
            this.label_total.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Forma de Pago:";
            // 
            // comboBox_forma
            // 
            this.comboBox_forma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_forma.FormattingEnabled = true;
            this.comboBox_forma.Location = new System.Drawing.Point(421, 426);
            this.comboBox_forma.Name = "comboBox_forma";
            this.comboBox_forma.Size = new System.Drawing.Size(147, 21);
            this.comboBox_forma.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Cliente :";
            // 
            // comboBox_cliente
            // 
            this.comboBox_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cliente.FormattingEnabled = true;
            this.comboBox_cliente.Location = new System.Drawing.Point(122, 33);
            this.comboBox_cliente.Name = "comboBox_cliente";
            this.comboBox_cliente.Size = new System.Drawing.Size(147, 21);
            this.comboBox_cliente.TabIndex = 21;
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(14, 493);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(102, 35);
            this.button_cancelar.TabIndex = 25;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // textBox_cliente
            // 
            this.textBox_cliente.Location = new System.Drawing.Point(284, 33);
            this.textBox_cliente.Name = "textBox_cliente";
            this.textBox_cliente.Size = new System.Drawing.Size(116, 20);
            this.textBox_cliente.TabIndex = 26;
            // 
            // textBox_empresa
            // 
            this.textBox_empresa.Location = new System.Drawing.Point(284, 60);
            this.textBox_empresa.Name = "textBox_empresa";
            this.textBox_empresa.Size = new System.Drawing.Size(116, 20);
            this.textBox_empresa.TabIndex = 27;
            // 
            // button_buscar_cliente
            // 
            this.button_buscar_cliente.Location = new System.Drawing.Point(416, 32);
            this.button_buscar_cliente.Name = "button_buscar_cliente";
            this.button_buscar_cliente.Size = new System.Drawing.Size(102, 22);
            this.button_buscar_cliente.TabIndex = 28;
            this.button_buscar_cliente.Text = "Buscar cliente";
            this.button_buscar_cliente.UseVisualStyleBackColor = true;
            this.button_buscar_cliente.Click += new System.EventHandler(this.button_buscar_cliente_Click);
            // 
            // button_buscar_empresa
            // 
            this.button_buscar_empresa.Location = new System.Drawing.Point(416, 58);
            this.button_buscar_empresa.Name = "button_buscar_empresa";
            this.button_buscar_empresa.Size = new System.Drawing.Size(102, 22);
            this.button_buscar_empresa.TabIndex = 29;
            this.button_buscar_empresa.Text = "Buscar empresa";
            this.button_buscar_empresa.UseVisualStyleBackColor = true;
            this.button_buscar_empresa.Click += new System.EventHandler(this.button_buscar_empresa_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Facturas añadidas";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView_total
            // 
            this.dataGridView_total.AllowUserToAddRows = false;
            this.dataGridView_total.AllowUserToDeleteRows = false;
            this.dataGridView_total.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_total.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Cliente,
            this.Empresa,
            this.Factura,
            this.Vencimiento,
            this.Importe,
            this.importe_bruto});
            this.dataGridView_total.Location = new System.Drawing.Point(14, 127);
            this.dataGridView_total.Name = "dataGridView_total";
            this.dataGridView_total.ReadOnly = true;
            this.dataGridView_total.Size = new System.Drawing.Size(581, 109);
            this.dataGridView_total.TabIndex = 32;
            // 
            // dataGridView_confirmados
            // 
            this.dataGridView_confirmados.AllowUserToAddRows = false;
            this.dataGridView_confirmados.AllowUserToDeleteRows = false;
            this.dataGridView_confirmados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_confirmados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.importe_bruto_});
            this.dataGridView_confirmados.Location = new System.Drawing.Point(14, 272);
            this.dataGridView_confirmados.Name = "dataGridView_confirmados";
            this.dataGridView_confirmados.ReadOnly = true;
            this.dataGridView_confirmados.Size = new System.Drawing.Size(581, 104);
            this.dataGridView_confirmados.TabIndex = 33;
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(493, 99);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(102, 22);
            this.button_buscar.TabIndex = 34;
            this.button_buscar.Text = "Buscar facturas";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_limpiar
            // 
            this.button_limpiar.Location = new System.Drawing.Point(248, 493);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(102, 35);
            this.button_limpiar.TabIndex = 35;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            // 
            // Factura
            // 
            this.Factura.HeaderText = "Nro Factura";
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            // 
            // Vencimiento
            // 
            this.Vencimiento.HeaderText = "Fecha vencimiento";
            this.Vencimiento.Name = "Vencimiento";
            this.Vencimiento.ReadOnly = true;
            this.Vencimiento.Width = 125;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // importe_bruto
            // 
            this.importe_bruto.HeaderText = "importe_bruto";
            this.importe_bruto.Name = "importe_bruto";
            this.importe_bruto.ReadOnly = true;
            this.importe_bruto.Visible = false;
            // 
            // id_
            // 
            this.id_.HeaderText = "id_";
            this.id_.Name = "id_";
            this.id_.ReadOnly = true;
            this.id_.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Empresa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nro Factura";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha vencimiento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Importe";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // importe_bruto_
            // 
            this.importe_bruto_.HeaderText = "importe_bruto";
            this.importe_bruto_.Name = "importe_bruto_";
            this.importe_bruto_.ReadOnly = true;
            this.importe_bruto_.Visible = false;
            // 
            // RegistroPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 548);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.dataGridView_confirmados);
            this.Controls.Add(this.dataGridView_total);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button_buscar_empresa);
            this.Controls.Add(this.button_buscar_cliente);
            this.Controls.Add(this.textBox_empresa);
            this.Controls.Add(this.textBox_cliente);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_forma);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox_cliente);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label_cant);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_confirmar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_sucursal);
            this.Controls.Add(this.comboBox_empresa);
            this.Controls.Add(this.textBox_fecha_sistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegistroPago";
            this.Text = "Pago Agil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_confirmados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_fecha_sistema;
        private System.Windows.Forms.ComboBox comboBox_empresa;
        private System.Windows.Forms.TextBox textBox_sucursal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_confirmar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_cant;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_forma;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_cliente;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.TextBox textBox_cliente;
        private System.Windows.Forms.TextBox textBox_empresa;
        private System.Windows.Forms.Button button_buscar_cliente;
        private System.Windows.Forms.Button button_buscar_empresa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView_total;
        private System.Windows.Forms.DataGridView dataGridView_confirmados;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_bruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_bruto_;
    }
}