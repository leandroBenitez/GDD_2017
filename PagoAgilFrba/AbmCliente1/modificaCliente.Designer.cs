namespace PagoAgilFrba.AbmCliente1
{
    partial class modificaCliente
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
            this.label11 = new System.Windows.Forms.Label();
            this.fechaNac = new System.Windows.Forms.TextBox();
            this.dniBuscado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.comboHabilitado = new System.Windows.Forms.ComboBox();
            this.codPostal = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botLimpiar = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(283, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 70;
            this.label11.Text = "label11";
            // 
            // fechaNac
            // 
            this.fechaNac.Location = new System.Drawing.Point(59, 223);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(114, 20);
            this.fechaNac.TabIndex = 69;
            // 
            // dniBuscado
            // 
            this.dniBuscado.Location = new System.Drawing.Point(461, 217);
            this.dniBuscado.Name = "dniBuscado";
            this.dniBuscado.Size = new System.Drawing.Size(114, 20);
            this.dniBuscado.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(458, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "DNI de cliente a modificar";
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(473, 165);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(92, 24);
            this.botonModificar.TabIndex = 66;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click_1);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(473, 120);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(92, 24);
            this.botonBuscar.TabIndex = 65;
            this.botonBuscar.Text = "Limpiar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click_1);
            // 
            // comboHabilitado
            // 
            this.comboHabilitado.FormattingEnabled = true;
            this.comboHabilitado.Items.AddRange(new object[] {
            "Habilitado",
            "Deshabilitado"});
            this.comboHabilitado.Location = new System.Drawing.Point(256, 189);
            this.comboHabilitado.Name = "comboHabilitado";
            this.comboHabilitado.Size = new System.Drawing.Size(112, 21);
            this.comboHabilitado.TabIndex = 64;
            // 
            // codPostal
            // 
            this.codPostal.Location = new System.Drawing.Point(255, 142);
            this.codPostal.Name = "codPostal";
            this.codPostal.Size = new System.Drawing.Size(114, 20);
            this.codPostal.TabIndex = 63;
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(255, 99);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(114, 20);
            this.direccion.TabIndex = 62;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(255, 58);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(114, 20);
            this.mail.TabIndex = 61;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(59, 181);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(114, 20);
            this.telefono.TabIndex = 60;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(59, 142);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(114, 20);
            this.nombre.TabIndex = 59;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(59, 99);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(114, 20);
            this.apellido.TabIndex = 58;
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(59, 58);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(114, 20);
            this.dni.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Habilitado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Codigo Postal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "DNI";
            // 
            // botLimpiar
            // 
            this.botLimpiar.Location = new System.Drawing.Point(473, 72);
            this.botLimpiar.Name = "botLimpiar";
            this.botLimpiar.Size = new System.Drawing.Size(92, 24);
            this.botLimpiar.TabIndex = 47;
            this.botLimpiar.Text = "Buscar";
            this.botLimpiar.UseVisualStyleBackColor = true;
            this.botLimpiar.Click += new System.EventHandler(this.botLimpiar_Click_1);
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
            this.dataGridView1.Location = new System.Drawing.Point(28, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 127);
            this.dataGridView1.TabIndex = 46;
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
            // modificaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 457);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fechaNac);
            this.Controls.Add(this.dniBuscado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.comboHabilitado);
            this.Controls.Add(this.codPostal);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botLimpiar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "modificaCliente";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox fechaNac;
        private System.Windows.Forms.TextBox dniBuscado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.ComboBox comboHabilitado;
        private System.Windows.Forms.TextBox codPostal;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botLimpiar;
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
    }
}