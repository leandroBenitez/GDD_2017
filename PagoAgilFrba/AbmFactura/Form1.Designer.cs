namespace PagoAgilFrba.AbmFactura
{
    partial class Form1
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
            this.additem = new System.Windows.Forms.Button();
            this.cancelitem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.canitem = new System.Windows.Forms.TextBox();
            this.precioittotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // additem
            // 
            this.additem.Location = new System.Drawing.Point(133, 152);
            this.additem.Name = "additem";
            this.additem.Size = new System.Drawing.Size(75, 23);
            this.additem.TabIndex = 0;
            this.additem.Text = "Agregar";
            this.additem.UseVisualStyleBackColor = true;
            // 
            // cancelitem
            // 
            this.cancelitem.Location = new System.Drawing.Point(27, 152);
            this.cancelitem.Name = "cancelitem";
            this.cancelitem.Size = new System.Drawing.Size(75, 23);
            this.cancelitem.TabIndex = 1;
            this.cancelitem.Text = "Cancelar";
            this.cancelitem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio (Total)";
            // 
            // canitem
            // 
            this.canitem.Location = new System.Drawing.Point(126, 44);
            this.canitem.Name = "canitem";
            this.canitem.Size = new System.Drawing.Size(82, 20);
            this.canitem.TabIndex = 4;
            // 
            // precioittotal
            // 
            this.precioittotal.Location = new System.Drawing.Point(126, 87);
            this.precioittotal.Name = "precioittotal";
            this.precioittotal.Size = new System.Drawing.Size(82, 20);
            this.precioittotal.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 199);
            this.Controls.Add(this.precioittotal);
            this.Controls.Add(this.canitem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelitem);
            this.Controls.Add(this.additem);
            this.Name = "Form1";
            this.Text = "Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button additem;
        private System.Windows.Forms.Button cancelitem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox canitem;
        private System.Windows.Forms.TextBox precioittotal;
    }
}