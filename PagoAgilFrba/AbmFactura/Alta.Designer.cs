namespace PagoAgilFrba.AbmFactura
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
            this.label1 = new System.Windows.Forms.Label();
            this.clientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.empresas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.factnro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.factfechaalta = new System.Windows.Forms.TextBox();
            this.factvenc = new System.Windows.Forms.DateTimePicker();
            this.items = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.itemcount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.facttotal = new System.Windows.Forms.TextBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complete los campos";
            // 
            // clientes
            // 
            this.clientes.FormattingEnabled = true;
            this.clientes.Location = new System.Drawing.Point(151, 56);
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(121, 21);
            this.clientes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Empresa";
            // 
            // empresas
            // 
            this.empresas.FormattingEnabled = true;
            this.empresas.Location = new System.Drawing.Point(151, 94);
            this.empresas.Name = "empresas";
            this.empresas.Size = new System.Drawing.Size(121, 21);
            this.empresas.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nro Factura";
            // 
            // factnro
            // 
            this.factnro.Location = new System.Drawing.Point(152, 134);
            this.factnro.Name = "factnro";
            this.factnro.Size = new System.Drawing.Size(119, 20);
            this.factnro.TabIndex = 6;
            this.factnro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.factnro_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha Alta Factura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha Vencimiento";
            // 
            // factfechaalta
            // 
            this.factfechaalta.Location = new System.Drawing.Point(151, 177);
            this.factfechaalta.Name = "factfechaalta";
            this.factfechaalta.ReadOnly = true;
            this.factfechaalta.Size = new System.Drawing.Size(119, 20);
            this.factfechaalta.TabIndex = 9;
            // 
            // factvenc
            // 
            this.factvenc.Location = new System.Drawing.Point(151, 214);
            this.factvenc.Name = "factvenc";
            this.factvenc.Size = new System.Drawing.Size(200, 20);
            this.factvenc.TabIndex = 10;
            // 
            // items
            // 
            this.items.Location = new System.Drawing.Point(152, 250);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(94, 28);
            this.items.TabIndex = 11;
            this.items.Text = "Agregar Item";
            this.items.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Items ";
            // 
            // itemcount
            // 
            this.itemcount.AutoSize = true;
            this.itemcount.Location = new System.Drawing.Point(69, 258);
            this.itemcount.Name = "itemcount";
            this.itemcount.Size = new System.Drawing.Size(19, 13);
            this.itemcount.TabIndex = 13;
            this.itemcount.Text = "(0)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "TOTAL ($)";
            // 
            // facttotal
            // 
            this.facttotal.Location = new System.Drawing.Point(153, 296);
            this.facttotal.Name = "facttotal";
            this.facttotal.ReadOnly = true;
            this.facttotal.Size = new System.Drawing.Size(119, 20);
            this.facttotal.TabIndex = 15;
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(30, 344);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(94, 28);
            this.cancelar.TabIndex = 16;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // agregar
            // 
            this.agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(222, 344);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(94, 28);
            this.agregar.TabIndex = 17;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 395);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.facttotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.itemcount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.items);
            this.Controls.Add(this.factvenc);
            this.Controls.Add(this.factfechaalta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.factnro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.empresas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientes);
            this.Controls.Add(this.label1);
            this.Name = "Alta";
            this.Text = "Alta Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox clientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox empresas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox factnro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox factfechaalta;
        private System.Windows.Forms.DateTimePicker factvenc;
        private System.Windows.Forms.Button items;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label itemcount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox facttotal;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button agregar;
    }
}