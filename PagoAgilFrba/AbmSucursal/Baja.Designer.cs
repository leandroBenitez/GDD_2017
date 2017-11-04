namespace PagoAgilFrba.AbmSucursal
{
    partial class Baja
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.buscarsuc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sucursal_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal_Codigo_Postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nombre = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.cp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo Postal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Filtros";
            // 
            // limpiar
            // 
            this.limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.limpiar.Location = new System.Drawing.Point(524, 20);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(79, 33);
            this.limpiar.TabIndex = 4;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // buscarsuc
            // 
            this.buscarsuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buscarsuc.Location = new System.Drawing.Point(524, 72);
            this.buscarsuc.Name = "buscarsuc";
            this.buscarsuc.Size = new System.Drawing.Size(79, 33);
            this.buscarsuc.TabIndex = 5;
            this.buscarsuc.Text = "Buscar";
            this.buscarsuc.UseVisualStyleBackColor = true;
            this.buscarsuc.Click += new System.EventHandler(this.buscarsuc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sucursal_Nombre,
            this.Sucursal_Direccion,
            this.Sucursal_Codigo_Postal,
            this.Sucursal_Estado,
            this.Seleccionar});
            this.dataGridView1.Location = new System.Drawing.Point(15, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(629, 137);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Sucursal_Nombre
            // 
            this.Sucursal_Nombre.HeaderText = "Sucursal_Nombre";
            this.Sucursal_Nombre.Name = "Sucursal_Nombre";
            this.Sucursal_Nombre.ReadOnly = true;
            this.Sucursal_Nombre.Width = 116;
            // 
            // Sucursal_Direccion
            // 
            this.Sucursal_Direccion.HeaderText = "Sucursal_Direccion";
            this.Sucursal_Direccion.Name = "Sucursal_Direccion";
            this.Sucursal_Direccion.ReadOnly = true;
            this.Sucursal_Direccion.Width = 124;
            // 
            // Sucursal_Codigo_Postal
            // 
            this.Sucursal_Codigo_Postal.FillWeight = 150F;
            this.Sucursal_Codigo_Postal.HeaderText = "Sucursal_Codigo_Postal";
            this.Sucursal_Codigo_Postal.Name = "Sucursal_Codigo_Postal";
            this.Sucursal_Codigo_Postal.ReadOnly = true;
            this.Sucursal_Codigo_Postal.Width = 147;
            // 
            // Sucursal_Estado
            // 
            this.Sucursal_Estado.HeaderText = "Sucursal_Estado";
            this.Sucursal_Estado.Name = "Sucursal_Estado";
            this.Sucursal_Estado.ReadOnly = true;
            this.Sucursal_Estado.Width = 112;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Width = 69;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(24, 69);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(211, 20);
            this.nombre.TabIndex = 7;
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(24, 125);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(211, 20);
            this.direccion.TabIndex = 8;
            // 
            // cp
            // 
            this.cp.Location = new System.Drawing.Point(292, 72);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(100, 20);
            this.cp.TabIndex = 9;
            this.cp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cp_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(368, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Seleccione uno de los elementos que desea dar de baja";
            // 
            // estado
            // 
            this.estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estado.FormattingEnabled = true;
            this.estado.Location = new System.Drawing.Point(293, 125);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(98, 21);
            this.estado.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estado";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(524, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cp);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buscarsuc);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Baja";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button buscarsuc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox cp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal_Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal_Codigo_Postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal_Estado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}