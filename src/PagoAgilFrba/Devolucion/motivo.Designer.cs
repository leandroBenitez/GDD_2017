﻿namespace PagoAgilFrba.Devolucion
{
    partial class motivo
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
            this.motivos = new System.Windows.Forms.Button();
            this.nuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el motivo devolución";
            // 
            // motivos
            // 
            this.motivos.Location = new System.Drawing.Point(60, 76);
            this.motivos.Name = "motivos";
            this.motivos.Size = new System.Drawing.Size(129, 39);
            this.motivos.TabIndex = 1;
            this.motivos.Text = "Existente";
            this.motivos.UseVisualStyleBackColor = true;
            this.motivos.Click += new System.EventHandler(this.motivos_Click);
            // 
            // nuevo
            // 
            this.nuevo.AllowDrop = true;
            this.nuevo.Location = new System.Drawing.Point(59, 133);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(129, 40);
            this.nuevo.TabIndex = 2;
            this.nuevo.Text = "Nuevo";
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // motivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 247);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.motivos);
            this.Controls.Add(this.label1);
            this.Name = "motivo";
            this.Text = "Devolver Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button motivos;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Button button1;
    }
}