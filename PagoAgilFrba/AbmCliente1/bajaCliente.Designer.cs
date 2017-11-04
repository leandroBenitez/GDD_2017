namespace PagoAgilFrba.AbmCliente1
{
    partial class bajaCliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cliente_Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Fecha_Nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Codigo_Postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Habilitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonDeshabilitar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente_Dni,
            this.Cliente_Apellido,
            this.Cliente_Nombre,
            this.Cliente_Telefono,
            this.Cliente_Fecha_Nac,
            this.Cliente_Mail,
            this.Cliente_Direccion,
            this.Cliente_Codigo_Postal,
            this.Cliente_Habilitado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(592, 127);
            this.dataGridView1.TabIndex = 1;
            // 
            // Cliente_Dni
            // 
            this.Cliente_Dni.HeaderText = "Cliente_Dni";
            this.Cliente_Dni.Name = "Cliente_Dni";
            // 
            // Cliente_Apellido
            // 
            this.Cliente_Apellido.HeaderText = "Cliente_Apellido";
            this.Cliente_Apellido.Name = "Cliente_Apellido";
            // 
            // Cliente_Nombre
            // 
            this.Cliente_Nombre.HeaderText = "Cliente_Nombre";
            this.Cliente_Nombre.Name = "Cliente_Nombre";
            // 
            // Cliente_Telefono
            // 
            this.Cliente_Telefono.HeaderText = "Cliente_Telefono";
            this.Cliente_Telefono.Name = "Cliente_Telefono";
            // 
            // Cliente_Fecha_Nac
            // 
            this.Cliente_Fecha_Nac.HeaderText = "Cliente_Fecha_Nac";
            this.Cliente_Fecha_Nac.Name = "Cliente_Fecha_Nac";
            // 
            // Cliente_Mail
            // 
            this.Cliente_Mail.HeaderText = "Cliente_Mail";
            this.Cliente_Mail.Name = "Cliente_Mail";
            // 
            // Cliente_Direccion
            // 
            this.Cliente_Direccion.HeaderText = "Cliente_Direccion";
            this.Cliente_Direccion.Name = "Cliente_Direccion";
            // 
            // Cliente_Codigo_Postal
            // 
            this.Cliente_Codigo_Postal.HeaderText = "Cliente_Codigo_Postal";
            this.Cliente_Codigo_Postal.Name = "Cliente_Codigo_Postal";
            // 
            // Cliente_Habilitado
            // 
            this.Cliente_Habilitado.HeaderText = "Cliente_Habilitado";
            this.Cliente_Habilitado.Name = "Cliente_Habilitado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(40, 37);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(135, 20);
            this.dni.TabIndex = 4;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(40, 85);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(135, 20);
            this.apellido.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(40, 133);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(135, 20);
            this.nombre.TabIndex = 7;
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(289, 54);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(143, 31);
            this.botonBuscar.TabIndex = 8;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonDeshabilitar
            // 
            this.botonDeshabilitar.Location = new System.Drawing.Point(289, 117);
            this.botonDeshabilitar.Name = "botonDeshabilitar";
            this.botonDeshabilitar.Size = new System.Drawing.Size(143, 31);
            this.botonDeshabilitar.TabIndex = 9;
            this.botonDeshabilitar.Text = "Deshabilitar";
            this.botonDeshabilitar.UseVisualStyleBackColor = true;
            this.botonDeshabilitar.Click += new System.EventHandler(this.botonDeshabilitar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Direccion";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(40, 182);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(135, 20);
            this.direccion.TabIndex = 11;
            // 
            // bajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 364);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonDeshabilitar);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "bajaCliente";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Fecha_Nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Codigo_Postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Habilitado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonDeshabilitar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox direccion;
    }
}