﻿namespace PagoAgilFrba.AbmCliente1
{
    partial class nuevoCliente
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
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.fechaNac = new System.Windows.Forms.TextBox();
            this.botonNuevo = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(269, 308);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(167, 37);
            this.botonLimpiar.TabIndex = 59;
            this.botonLimpiar.Text = "Limpiar datos";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click_1);
            // 
            // fechaNac
            // 
            this.fechaNac.Location = new System.Drawing.Point(96, 271);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(114, 20);
            this.fechaNac.TabIndex = 58;
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(96, 308);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(167, 37);
            this.botonNuevo.TabIndex = 57;
            this.botonNuevo.Text = "Agregar cliente";
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click_1);
            // 
            // comboHabilitado
            // 
            this.comboHabilitado.FormattingEnabled = true;
            this.comboHabilitado.Items.AddRange(new object[] {
            "Habilitado",
            "Deshabilitado"});
            this.comboHabilitado.Location = new System.Drawing.Point(293, 233);
            this.comboHabilitado.Name = "comboHabilitado";
            this.comboHabilitado.Size = new System.Drawing.Size(112, 21);
            this.comboHabilitado.TabIndex = 56;
            // 
            // codPostal
            // 
            this.codPostal.Location = new System.Drawing.Point(292, 186);
            this.codPostal.Name = "codPostal";
            this.codPostal.Size = new System.Drawing.Size(114, 20);
            this.codPostal.TabIndex = 55;
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(292, 143);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(114, 20);
            this.direccion.TabIndex = 54;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(292, 102);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(114, 20);
            this.mail.TabIndex = 53;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(96, 225);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(114, 20);
            this.telefono.TabIndex = 52;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(96, 186);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(114, 20);
            this.nombre.TabIndex = 51;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(96, 143);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(114, 20);
            this.apellido.TabIndex = 50;
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(96, 102);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(114, 20);
            this.dni.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Habilitado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Codigo Postal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "DNI";
            // 
            // nuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 430);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.fechaNac);
            this.Controls.Add(this.botonNuevo);
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
            this.Name = "nuevoCliente";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.TextBox fechaNac;
        private System.Windows.Forms.Button botonNuevo;
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
    }
}