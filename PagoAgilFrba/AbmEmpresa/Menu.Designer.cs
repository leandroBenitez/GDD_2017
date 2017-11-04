namespace PagoAgilFrba.AbmEmpresa
{
    partial class Menu
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
            this.button_alta = new System.Windows.Forms.Button();
            this.button_mb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_alta
            // 
            this.button_alta.Location = new System.Drawing.Point(33, 62);
            this.button_alta.Name = "button_alta";
            this.button_alta.Size = new System.Drawing.Size(92, 35);
            this.button_alta.TabIndex = 0;
            this.button_alta.Text = "Alta";
            this.button_alta.UseVisualStyleBackColor = true;
            this.button_alta.Click += new System.EventHandler(this.button_alta_Click);
            // 
            // button_mb
            // 
            this.button_mb.Location = new System.Drawing.Point(167, 62);
            this.button_mb.Name = "button_mb";
            this.button_mb.Size = new System.Drawing.Size(105, 35);
            this.button_mb.TabIndex = 1;
            this.button_mb.Text = "Baja/Modificación ";
            this.button_mb.UseVisualStyleBackColor = true;
            this.button_mb.Click += new System.EventHandler(this.button_mb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ABM Empresa";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 137);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_mb);
            this.Controls.Add(this.button_alta);
            this.Name = "Menu";
            this.Text = "Pago Agil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_alta;
        private System.Windows.Forms.Button button_mb;
        private System.Windows.Forms.Label label1;
    }
}