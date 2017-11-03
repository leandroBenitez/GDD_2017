namespace PagoAgilFrba.RegistroPago
{
    partial class RegistroPago
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
            this.textBox_nro_fact = new System.Windows.Forms.TextBox();
            this.textBox_fecha_sistema = new System.Windows.Forms.TextBox();
            this.comboBox_empresa = new System.Windows.Forms.ComboBox();
            this.comboBox_cliente = new System.Windows.Forms.ComboBox();
            this.textBox_fecha_venc = new System.Windows.Forms.TextBox();
            this.textBox_importe = new System.Windows.Forms.TextBox();
            this.textBox_sucursal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_registro = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_nro_fact
            // 
            this.textBox_nro_fact.Location = new System.Drawing.Point(186, 79);
            this.textBox_nro_fact.Name = "textBox_nro_fact";
            this.textBox_nro_fact.Size = new System.Drawing.Size(147, 20);
            this.textBox_nro_fact.TabIndex = 0;
            // 
            // textBox_fecha_sistema
            // 
            this.textBox_fecha_sistema.Location = new System.Drawing.Point(186, 128);
            this.textBox_fecha_sistema.Name = "textBox_fecha_sistema";
            this.textBox_fecha_sistema.ReadOnly = true;
            this.textBox_fecha_sistema.Size = new System.Drawing.Size(147, 20);
            this.textBox_fecha_sistema.TabIndex = 1;
            // 
            // comboBox_empresa
            // 
            this.comboBox_empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_empresa.FormattingEnabled = true;
            this.comboBox_empresa.Location = new System.Drawing.Point(186, 178);
            this.comboBox_empresa.Name = "comboBox_empresa";
            this.comboBox_empresa.Size = new System.Drawing.Size(147, 21);
            this.comboBox_empresa.TabIndex = 2;
            // 
            // comboBox_cliente
            // 
            this.comboBox_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cliente.FormattingEnabled = true;
            this.comboBox_cliente.Location = new System.Drawing.Point(186, 226);
            this.comboBox_cliente.Name = "comboBox_cliente";
            this.comboBox_cliente.Size = new System.Drawing.Size(147, 21);
            this.comboBox_cliente.TabIndex = 3;
            // 
            // textBox_fecha_venc
            // 
            this.textBox_fecha_venc.Location = new System.Drawing.Point(186, 274);
            this.textBox_fecha_venc.Name = "textBox_fecha_venc";
            this.textBox_fecha_venc.Size = new System.Drawing.Size(147, 20);
            this.textBox_fecha_venc.TabIndex = 4;
            // 
            // textBox_importe
            // 
            this.textBox_importe.Location = new System.Drawing.Point(186, 324);
            this.textBox_importe.Name = "textBox_importe";
            this.textBox_importe.Size = new System.Drawing.Size(147, 20);
            this.textBox_importe.TabIndex = 5;
            // 
            // textBox_sucursal
            // 
            this.textBox_sucursal.Location = new System.Drawing.Point(186, 373);
            this.textBox_sucursal.Name = "textBox_sucursal";
            this.textBox_sucursal.ReadOnly = true;
            this.textBox_sucursal.Size = new System.Drawing.Size(147, 20);
            this.textBox_sucursal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nro de Factura :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cliente :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha de vencimiento :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Empresa :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de cobro :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sucursal :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Importe :";
            // 
            // button_registro
            // 
            this.button_registro.Location = new System.Drawing.Point(128, 422);
            this.button_registro.Name = "button_registro";
            this.button_registro.Size = new System.Drawing.Size(102, 35);
            this.button_registro.TabIndex = 14;
            this.button_registro.Text = "Registrar Pago";
            this.button_registro.UseVisualStyleBackColor = true;
            this.button_registro.Click += new System.EventHandler(this.button_registro_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Registro de Pago";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegistroPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 483);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_registro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_sucursal);
            this.Controls.Add(this.textBox_importe);
            this.Controls.Add(this.textBox_fecha_venc);
            this.Controls.Add(this.comboBox_cliente);
            this.Controls.Add(this.comboBox_empresa);
            this.Controls.Add(this.textBox_fecha_sistema);
            this.Controls.Add(this.textBox_nro_fact);
            this.Name = "RegistroPago";
            this.Text = "Pago Agil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nro_fact;
        private System.Windows.Forms.TextBox textBox_fecha_sistema;
        private System.Windows.Forms.ComboBox comboBox_empresa;
        private System.Windows.Forms.ComboBox comboBox_cliente;
        private System.Windows.Forms.TextBox textBox_fecha_venc;
        private System.Windows.Forms.TextBox textBox_importe;
        private System.Windows.Forms.TextBox textBox_sucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_registro;
        private System.Windows.Forms.Label label8;
    }
}