namespace PagoAgilFrba.AbmSucursal
{
    partial class auxiliarModificacion
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
            this.modificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.habilitar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(111, 221);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(100, 30);
            this.modificar.TabIndex = 15;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Codigo Postal";
            // 
            // cp
            // 
            this.cp.Location = new System.Drawing.Point(111, 133);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(100, 20);
            this.cp.TabIndex = 13;
            this.cp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cp_Click);
            this.cp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cp_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Direccion";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(84, 91);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(197, 20);
            this.direccion.TabIndex = 11;
            this.direccion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.direccion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(84, 44);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(197, 20);
            this.nombre.TabIndex = 9;
            this.nombre.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nombre_Click);
       
            // 
            // habilitar
            // 
            this.habilitar.Location = new System.Drawing.Point(111, 178);
            this.habilitar.Name = "habilitar";
            this.habilitar.Size = new System.Drawing.Size(75, 23);
            this.habilitar.TabIndex = 16;
            this.habilitar.Text = "Habilitar";
            this.habilitar.UseVisualStyleBackColor = true;
            this.habilitar.Click += new System.EventHandler(this.habilitar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Estado";
            // 
            // auxiliarModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 274);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.habilitar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre);
            this.Name = "auxiliarModificacion";
            this.Text = "Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button habilitar;
        private System.Windows.Forms.Label label4;
    }
}