﻿namespace PagoAgilFrba.AbmRol
{
    partial class Modificacion
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
            this.button_mod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.dataGridView_funcionalidades = new System.Windows.Forms.DataGridView();
            this.checkBox_hab = new System.Windows.Forms.CheckBox();
            this.button_atras = new System.Windows.Forms.Button();
            this.funcionalidad_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_funcionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // button_mod
            // 
            this.button_mod.Location = new System.Drawing.Point(188, 277);
            this.button_mod.Name = "button_mod";
            this.button_mod.Size = new System.Drawing.Size(75, 23);
            this.button_mod.TabIndex = 9;
            this.button_mod.Text = "Modificar";
            this.button_mod.UseVisualStyleBackColor = true;
            this.button_mod.Click += new System.EventHandler(this.button_mod_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Modificación Rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(88, 52);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(175, 20);
            this.textBox_nombre.TabIndex = 6;
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
            this.dataGridView_funcionalidades.Location = new System.Drawing.Point(20, 90);
            this.dataGridView_funcionalidades.Name = "dataGridView_funcionalidades";
            this.dataGridView_funcionalidades.Size = new System.Drawing.Size(243, 150);
            this.dataGridView_funcionalidades.TabIndex = 5;
            // 
            // checkBox_hab
            // 
            this.checkBox_hab.AutoSize = true;
            this.checkBox_hab.Location = new System.Drawing.Point(20, 247);
            this.checkBox_hab.Name = "checkBox_hab";
            this.checkBox_hab.Size = new System.Drawing.Size(73, 17);
            this.checkBox_hab.TabIndex = 10;
            this.checkBox_hab.Text = "Habilitado";
            this.checkBox_hab.UseVisualStyleBackColor = true;
            // 
            // button_atras
            // 
            this.button_atras.Location = new System.Drawing.Point(20, 277);
            this.button_atras.Name = "button_atras";
            this.button_atras.Size = new System.Drawing.Size(75, 23);
            this.button_atras.TabIndex = 11;
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
            this.Funcionalidad.ReadOnly = true;
            // 
            // Agregada
            // 
            this.Agregada.HeaderText = "Agregada";
            this.Agregada.Name = "Agregada";
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 312);
            this.Controls.Add(this.button_atras);
            this.Controls.Add(this.checkBox_hab);
            this.Controls.Add(this.button_mod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.dataGridView_funcionalidades);
            this.Name = "Modificacion";
            this.Text = "Pago Agil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_funcionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_mod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.DataGridView dataGridView_funcionalidades;
        private System.Windows.Forms.CheckBox checkBox_hab;
        private System.Windows.Forms.Button button_atras;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionalidad_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionalidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Agregada;

    }
}