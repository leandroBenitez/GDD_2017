﻿namespace PagoAgilFrba.AbmRol
{
    partial class Alta
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
            this.dataGridView_funcionalidades = new System.Windows.Forms.DataGridView();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_alta = new System.Windows.Forms.Button();
            this.button_atras = new System.Windows.Forms.Button();
            this.funcionalidad_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_funcionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_funcionalidades
            // 
            this.dataGridView_funcionalidades.AllowUserToAddRows = false;
            this.dataGridView_funcionalidades.AllowUserToDeleteRows = false;
            this.dataGridView_funcionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_funcionalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.funcionalidad_id,
            this.Funcionalidad,
            this.Agregada});
            this.dataGridView_funcionalidades.Location = new System.Drawing.Point(27, 95);
            this.dataGridView_funcionalidades.Name = "dataGridView_funcionalidades";
            this.dataGridView_funcionalidades.Size = new System.Drawing.Size(243, 150);
            this.dataGridView_funcionalidades.TabIndex = 0;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(95, 57);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(175, 20);
            this.textBox_nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alta Rol";
            // 
            // button_alta
            // 
            this.button_alta.Location = new System.Drawing.Point(195, 265);
            this.button_alta.Name = "button_alta";
            this.button_alta.Size = new System.Drawing.Size(75, 23);
            this.button_alta.TabIndex = 4;
            this.button_alta.Text = "Alta";
            this.button_alta.UseVisualStyleBackColor = true;
            this.button_alta.Click += new System.EventHandler(this.button_alta_Click);
            // 
            // button_atras
            // 
            this.button_atras.Location = new System.Drawing.Point(27, 265);
            this.button_atras.Name = "button_atras";
            this.button_atras.Size = new System.Drawing.Size(75, 23);
            this.button_atras.TabIndex = 5;
            this.button_atras.Text = "Atras";
            this.button_atras.UseVisualStyleBackColor = true;
            this.button_atras.Click += new System.EventHandler(this.button_atras_Click);
            // 
            // funcionalidad_id
            // 
            this.funcionalidad_id.HeaderText = "funcionalidad_id";
            this.funcionalidad_id.Name = "funcionalidad_id";
            this.funcionalidad_id.Visible = false;
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.HeaderText = "Funcionalidad";
            this.Funcionalidad.Name = "Funcionalidad";
            // 
            // Agregada
            // 
            this.Agregada.HeaderText = "Agregada";
            this.Agregada.Name = "Agregada";
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 315);
            this.Controls.Add(this.button_atras);
            this.Controls.Add(this.button_alta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.dataGridView_funcionalidades);
            this.Name = "Alta";
            this.Text = "Pago Agil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_funcionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_funcionalidades;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_alta;
        private System.Windows.Forms.Button button_atras;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionalidad_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionalidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Agregada;
    }
}