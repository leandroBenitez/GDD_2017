namespace PagoAgilFrba.AbmSucursal
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(122, 78);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Direccion";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(122, 122);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(100, 20);
            this.direccion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codigo Postal";
            // 
            // cp
            // 
            this.cp.Location = new System.Drawing.Point(122, 164);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(100, 20);
            this.cp.TabIndex = 4;
            this.cp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cp_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Complete los campos";
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 265);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre);
            this.Name = "Alta";
            this.Text = "Alta";
            this.Load += new System.EventHandler(this.Alta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}