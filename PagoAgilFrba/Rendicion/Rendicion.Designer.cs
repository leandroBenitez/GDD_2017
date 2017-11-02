namespace PagoAgilFrba.Rendicion
{
    partial class Rendicion
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
            this.button_buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_rendido = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_cuit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facturas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_rendir = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_comision = new System.Windows.Forms.ComboBox();
            this.button_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(369, 51);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(122, 23);
            this.button_buscar.TabIndex = 13;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Rendida:";
            // 
            // combo_rendido
            // 
            this.combo_rendido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_rendido.FormattingEnabled = true;
            this.combo_rendido.Location = new System.Drawing.Point(108, 53);
            this.combo_rendido.Name = "combo_rendido";
            this.combo_rendido.Size = new System.Drawing.Size(169, 21);
            this.combo_rendido.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CUIT:";
            // 
            // textBox_cuit
            // 
            this.textBox_cuit.Location = new System.Drawing.Point(340, 16);
            this.textBox_cuit.Name = "textBox_cuit";
            this.textBox_cuit.Size = new System.Drawing.Size(169, 20);
            this.textBox_cuit.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(108, 16);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(169, 20);
            this.textBox_nombre.TabIndex = 7;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_empresa,
            this.Empresa,
            this.CUIT,
            this.Periodo,
            this.Facturas,
            this.MontoTotal,
            this.Rendida});
            this.dataGridView.Location = new System.Drawing.Point(23, 93);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(624, 150);
            this.dataGridView.TabIndex = 14;
            // 
            // Id_empresa
            // 
            this.Id_empresa.HeaderText = "Id_empresa";
            this.Id_empresa.Name = "Id_empresa";
            this.Id_empresa.ReadOnly = true;
            this.Id_empresa.Visible = false;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            // 
            // CUIT
            // 
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            // 
            // Periodo
            // 
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            // 
            // Facturas
            // 
            this.Facturas.HeaderText = "Facturas";
            this.Facturas.Name = "Facturas";
            this.Facturas.ReadOnly = true;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // Rendida
            // 
            this.Rendida.HeaderText = "Rendida";
            this.Rendida.Name = "Rendida";
            this.Rendida.ReadOnly = true;
            // 
            // button_rendir
            // 
            this.button_rendir.Location = new System.Drawing.Point(530, 292);
            this.button_rendir.Name = "button_rendir";
            this.button_rendir.Size = new System.Drawing.Size(117, 23);
            this.button_rendir.TabIndex = 15;
            this.button_rendir.Text = "Rendir";
            this.button_rendir.UseVisualStyleBackColor = true;
            this.button_rendir.Click += new System.EventHandler(this.button_rendir_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(23, 292);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(117, 23);
            this.button_cancelar.TabIndex = 16;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(223, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ingrese la comision a cobrar (%):";
            // 
            // comboBox_comision
            // 
            this.comboBox_comision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_comision.FormattingEnabled = true;
            this.comboBox_comision.Location = new System.Drawing.Point(388, 255);
            this.comboBox_comision.Name = "comboBox_comision";
            this.comboBox_comision.Size = new System.Drawing.Size(49, 21);
            this.comboBox_comision.TabIndex = 18;
            // 
            // button_limpiar
            // 
            this.button_limpiar.Location = new System.Drawing.Point(265, 292);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(117, 23);
            this.button_limpiar.TabIndex = 19;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // Rendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 327);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.comboBox_comision);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_rendir);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_rendido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_cuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nombre);
            this.Name = "Rendicion";
            this.Text = "Pago Agil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_rendido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_cuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button_rendir;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rendida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_comision;
        private System.Windows.Forms.Button button_limpiar;
    }
}