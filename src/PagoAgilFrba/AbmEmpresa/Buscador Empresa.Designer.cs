namespace PagoAgilFrba.AbmEmpresa
{
    partial class Buscador_Empresa
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
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_rubro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_buscar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habilitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_baja = new System.Windows.Forms.Button();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_cuit_medio = new System.Windows.Forms.TextBox();
            this.textBox_cuit_fin = new System.Windows.Forms.TextBox();
            this.textBox_cuit_in = new System.Windows.Forms.TextBox();
            this.button_atras = new System.Windows.Forms.Button();
            this.diaCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(98, 28);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(169, 20);
            this.textBox_nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CUIT:";
            // 
            // combo_rubro
            // 
            this.combo_rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_rubro.FormattingEnabled = true;
            this.combo_rubro.Location = new System.Drawing.Point(98, 65);
            this.combo_rubro.Name = "combo_rubro";
            this.combo_rubro.Size = new System.Drawing.Size(169, 21);
            this.combo_rubro.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rubro:";
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(292, 63);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(87, 23);
            this.button_buscar.TabIndex = 6;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_empresa,
            this.Nombre,
            this.CUIT,
            this.Direccion,
            this.Rubro,
            this.Habilitada,
            this.diaCobro});
            this.dataGridView.Location = new System.Drawing.Point(21, 115);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(539, 150);
            this.dataGridView.TabIndex = 7;
            // 
            // Id_empresa
            // 
            this.Id_empresa.HeaderText = "Id_empresa";
            this.Id_empresa.Name = "Id_empresa";
            this.Id_empresa.ReadOnly = true;
            this.Id_empresa.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // CUIT
            // 
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Rubro
            // 
            this.Rubro.HeaderText = "Rubro";
            this.Rubro.Name = "Rubro";
            this.Rubro.ReadOnly = true;
            // 
            // Habilitada
            // 
            this.Habilitada.HeaderText = "Habilitada";
            this.Habilitada.Name = "Habilitada";
            this.Habilitada.ReadOnly = true;
            // 
            // button_modificar
            // 
            this.button_modificar.Location = new System.Drawing.Point(249, 283);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(75, 37);
            this.button_modificar.TabIndex = 8;
            this.button_modificar.Text = "Modificar";
            this.button_modificar.UseVisualStyleBackColor = true;
            this.button_modificar.Click += new System.EventHandler(this.button_modificar_Click);
            // 
            // button_baja
            // 
            this.button_baja.Location = new System.Drawing.Point(476, 283);
            this.button_baja.Name = "button_baja";
            this.button_baja.Size = new System.Drawing.Size(75, 37);
            this.button_baja.TabIndex = 9;
            this.button_baja.Text = "Dar de Baja";
            this.button_baja.UseVisualStyleBackColor = true;
            this.button_baja.Click += new System.EventHandler(this.button_baja_Click);
            // 
            // button_limpiar
            // 
            this.button_limpiar.Location = new System.Drawing.Point(415, 63);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(99, 23);
            this.button_limpiar.TabIndex = 10;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "-";
            // 
            // textBox_cuit_medio
            // 
            this.textBox_cuit_medio.Location = new System.Drawing.Point(377, 28);
            this.textBox_cuit_medio.Name = "textBox_cuit_medio";
            this.textBox_cuit_medio.Size = new System.Drawing.Size(92, 20);
            this.textBox_cuit_medio.TabIndex = 17;
            // 
            // textBox_cuit_fin
            // 
            this.textBox_cuit_fin.Location = new System.Drawing.Point(488, 28);
            this.textBox_cuit_fin.Name = "textBox_cuit_fin";
            this.textBox_cuit_fin.Size = new System.Drawing.Size(26, 20);
            this.textBox_cuit_fin.TabIndex = 16;
            // 
            // textBox_cuit_in
            // 
            this.textBox_cuit_in.Location = new System.Drawing.Point(329, 28);
            this.textBox_cuit_in.Name = "textBox_cuit_in";
            this.textBox_cuit_in.Size = new System.Drawing.Size(26, 20);
            this.textBox_cuit_in.TabIndex = 15;
            // 
            // button_atras
            // 
            this.button_atras.Location = new System.Drawing.Point(12, 283);
            this.button_atras.Name = "button_atras";
            this.button_atras.Size = new System.Drawing.Size(75, 37);
            this.button_atras.TabIndex = 20;
            this.button_atras.Text = "Atras";
            this.button_atras.UseVisualStyleBackColor = true;
            this.button_atras.Click += new System.EventHandler(this.button_atras_Click);
            // 
            // diaCobro
            // 
            this.diaCobro.HeaderText = "Día de Cobro";
            this.diaCobro.Name = "diaCobro";
            this.diaCobro.ReadOnly = true;
            // 
            // Buscador_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 332);
            this.Controls.Add(this.button_atras);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_cuit_medio);
            this.Controls.Add(this.textBox_cuit_fin);
            this.Controls.Add(this.textBox_cuit_in);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.button_baja);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_rubro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nombre);
            this.Name = "Buscador_Empresa";
            this.Text = "Pago Agil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_rubro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habilitada;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_baja;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_cuit_medio;
        private System.Windows.Forms.TextBox textBox_cuit_fin;
        private System.Windows.Forms.TextBox textBox_cuit_in;
        private System.Windows.Forms.Button button_atras;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaCobro;
    }
}