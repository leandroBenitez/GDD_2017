namespace PagoAgilFrba.AbmRol
{
    partial class BuscadorRol
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_resultados = new System.Windows.Forms.DataGridView();
            this.Id_Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habilitado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label = new System.Windows.Forms.Label();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_baja = new System.Windows.Forms.Button();
            this.button_atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Búsqueda Rol";
            // 
            // dataGridView_resultados
            // 
            this.dataGridView_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_resultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Rol,
            this.Nombre,
            this.Habilitado});
            this.dataGridView_resultados.Location = new System.Drawing.Point(24, 53);
            this.dataGridView_resultados.Name = "dataGridView_resultados";
            this.dataGridView_resultados.Size = new System.Drawing.Size(243, 185);
            this.dataGridView_resultados.TabIndex = 10;
            // 
            // Id_Rol
            // 
            this.Id_Rol.HeaderText = "Id_Rol";
            this.Id_Rol.Name = "Id_Rol";
            this.Id_Rol.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 10;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Habilitado
            // 
            this.Habilitado.HeaderText = "Habilitado";
            this.Habilitado.Name = "Habilitado";
            this.Habilitado.ReadOnly = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(21, 37);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(37, 13);
            this.label.TabIndex = 11;
            this.label.Text = "Roles:";
            // 
            // button_modificar
            // 
            this.button_modificar.Location = new System.Drawing.Point(192, 256);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(75, 23);
            this.button_modificar.TabIndex = 13;
            this.button_modificar.Text = "Modificar";
            this.button_modificar.UseVisualStyleBackColor = true;
            this.button_modificar.Click += new System.EventHandler(this.button_modificar_Click);
            // 
            // button_baja
            // 
            this.button_baja.Location = new System.Drawing.Point(111, 256);
            this.button_baja.Name = "button_baja";
            this.button_baja.Size = new System.Drawing.Size(75, 23);
            this.button_baja.TabIndex = 14;
            this.button_baja.Text = "Dar de Baja";
            this.button_baja.UseVisualStyleBackColor = true;
            this.button_baja.Click += new System.EventHandler(this.button_baja_Click);
            // 
            // button_atras
            // 
            this.button_atras.Location = new System.Drawing.Point(24, 256);
            this.button_atras.Name = "button_atras";
            this.button_atras.Size = new System.Drawing.Size(75, 23);
            this.button_atras.TabIndex = 15;
            this.button_atras.Text = "Atras";
            this.button_atras.UseVisualStyleBackColor = true;
            this.button_atras.Click += new System.EventHandler(this.button_atras_Click);
            // 
            // BuscadorRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 291);
            this.Controls.Add(this.button_atras);
            this.Controls.Add(this.button_baja);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataGridView_resultados);
            this.Controls.Add(this.label2);
            this.Name = "BuscadorRol";
            this.Text = "Pago Agil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_resultados;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_baja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Habilitado;
        private System.Windows.Forms.Button button_atras;
    }
}