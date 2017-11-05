namespace PagoAgilFrba.AbmRol
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
            this.button_busqueda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_alta
            // 
            this.button_alta.Location = new System.Drawing.Point(38, 45);
            this.button_alta.Name = "button_alta";
            this.button_alta.Size = new System.Drawing.Size(97, 38);
            this.button_alta.TabIndex = 0;
            this.button_alta.Text = "Dar de Alta";
            this.button_alta.UseVisualStyleBackColor = true;
            this.button_alta.Click += new System.EventHandler(this.button_alta_Click);
            // 
            // button_busqueda
            // 
            this.button_busqueda.Location = new System.Drawing.Point(153, 45);
            this.button_busqueda.Name = "button_busqueda";
            this.button_busqueda.Size = new System.Drawing.Size(107, 38);
            this.button_busqueda.TabIndex = 1;
            this.button_busqueda.Text = "Baja/Modificación";
            this.button_busqueda.UseVisualStyleBackColor = true;
            this.button_busqueda.Click += new System.EventHandler(this.button_busqueda_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.button_busqueda);
            this.Controls.Add(this.button_alta);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_alta;
        private System.Windows.Forms.Button button_busqueda;
    }
}