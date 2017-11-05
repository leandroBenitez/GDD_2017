namespace PagoAgilFrba.AbmEmpresa
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
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_cuit_in = new System.Windows.Forms.TextBox();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.comboBox_rubro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_alta = new System.Windows.Forms.Button();
            this.textBox_cuit_fin = new System.Windows.Forms.TextBox();
            this.textBox_cuit_medio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(166, 73);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(185, 20);
            this.textBox_nombre.TabIndex = 0;
            // 
            // textBox_cuit_in
            // 
            this.textBox_cuit_in.Location = new System.Drawing.Point(166, 115);
            this.textBox_cuit_in.Name = "textBox_cuit_in";
            this.textBox_cuit_in.Size = new System.Drawing.Size(26, 20);
            this.textBox_cuit_in.TabIndex = 1;
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(166, 155);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(185, 20);
            this.textBox_direccion.TabIndex = 2;
            // 
            // comboBox_rubro
            // 
            this.comboBox_rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rubro.FormattingEnabled = true;
            this.comboBox_rubro.Location = new System.Drawing.Point(166, 193);
            this.comboBox_rubro.Name = "comboBox_rubro";
            this.comboBox_rubro.Size = new System.Drawing.Size(185, 21);
            this.comboBox_rubro.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CUIT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rubro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Empresa";
            // 
            // button_alta
            // 
            this.button_alta.Location = new System.Drawing.Point(150, 268);
            this.button_alta.Name = "button_alta";
            this.button_alta.Size = new System.Drawing.Size(78, 23);
            this.button_alta.TabIndex = 10;
            this.button_alta.Text = "Alta";
            this.button_alta.UseVisualStyleBackColor = true;
            this.button_alta.Click += new System.EventHandler(this.button_alta_Click);
            // 
            // textBox_cuit_fin
            // 
            this.textBox_cuit_fin.Location = new System.Drawing.Point(325, 115);
            this.textBox_cuit_fin.Name = "textBox_cuit_fin";
            this.textBox_cuit_fin.Size = new System.Drawing.Size(26, 20);
            this.textBox_cuit_fin.TabIndex = 11;
            // 
            // textBox_cuit_medio
            // 
            this.textBox_cuit_medio.Location = new System.Drawing.Point(214, 115);
            this.textBox_cuit_medio.Name = "textBox_cuit_medio";
            this.textBox_cuit_medio.Size = new System.Drawing.Size(92, 20);
            this.textBox_cuit_medio.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "-";
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 335);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_cuit_medio);
            this.Controls.Add(this.textBox_cuit_fin);
            this.Controls.Add(this.button_alta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_rubro);
            this.Controls.Add(this.textBox_direccion);
            this.Controls.Add(this.textBox_cuit_in);
            this.Controls.Add(this.textBox_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Alta";
            this.Text = "Pago Agil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_cuit_in;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.ComboBox comboBox_rubro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_alta;
        private System.Windows.Forms.TextBox textBox_cuit_fin;
        private System.Windows.Forms.TextBox textBox_cuit_medio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}