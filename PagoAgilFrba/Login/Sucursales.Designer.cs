﻿namespace PagoAgilFrba.Login
{
    partial class Sucursales
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
            this.label1 = new System.Windows.Forms.Label();
            this.combo_Sucursales = new System.Windows.Forms.ComboBox();
            this.boton_ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la sucursal a operar:";
            // 
            // combo_Sucursales
            // 
            this.combo_Sucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Sucursales.FormattingEnabled = true;
            this.combo_Sucursales.Location = new System.Drawing.Point(43, 40);
            this.combo_Sucursales.Name = "combo_Sucursales";
            this.combo_Sucursales.Size = new System.Drawing.Size(155, 21);
            this.combo_Sucursales.TabIndex = 1;
            // 
            // boton_ingresar
            // 
            this.boton_ingresar.Location = new System.Drawing.Point(124, 75);
            this.boton_ingresar.Name = "boton_ingresar";
            this.boton_ingresar.Size = new System.Drawing.Size(120, 23);
            this.boton_ingresar.TabIndex = 4;
            this.boton_ingresar.Text = "Ingresar";
            this.boton_ingresar.UseVisualStyleBackColor = true;
            this.boton_ingresar.Click += new System.EventHandler(this.boton_ingresar_Click);
            // 
            // Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 110);
            this.Controls.Add(this.boton_ingresar);
            this.Controls.Add(this.combo_Sucursales);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Sucursales";
            this.Text = "Pago Agil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_Sucursales;
        private System.Windows.Forms.Button boton_ingresar;
    }
}