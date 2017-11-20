namespace PagoAgilFrba.Login
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
            this.label_fecha = new System.Windows.Forms.Label();
            this.label_usuario = new System.Windows.Forms.Label();
            this.button_abm_rol = new System.Windows.Forms.Button();
            this.button_abm_cliente = new System.Windows.Forms.Button();
            this.button_abm_empresa = new System.Windows.Forms.Button();
            this.button_abm_sucursal = new System.Windows.Forms.Button();
            this.button_abm_facturas = new System.Windows.Forms.Button();
            this.button_estadisticas = new System.Windows.Forms.Button();
            this.button_pagar = new System.Windows.Forms.Button();
            this.button_rendir = new System.Windows.Forms.Button();
            this.button_salir = new System.Windows.Forms.Button();
            this.button_devolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Location = new System.Drawing.Point(12, 32);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(34, 13);
            this.label_fecha.TabIndex = 0;
            this.label_fecha.Text = "fecha";
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Location = new System.Drawing.Point(12, 9);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(41, 13);
            this.label_usuario.TabIndex = 1;
            this.label_usuario.Text = "usuario";
            // 
            // button_abm_rol
            // 
            this.button_abm_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_abm_rol.Location = new System.Drawing.Point(186, 125);
            this.button_abm_rol.Name = "button_abm_rol";
            this.button_abm_rol.Size = new System.Drawing.Size(140, 27);
            this.button_abm_rol.TabIndex = 4;
            this.button_abm_rol.Text = "ABM Rol";
            this.button_abm_rol.UseVisualStyleBackColor = true;
            this.button_abm_rol.Click += new System.EventHandler(this.button_abm_rol_Click);
            // 
            // button_abm_cliente
            // 
            this.button_abm_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_abm_cliente.Location = new System.Drawing.Point(25, 172);
            this.button_abm_cliente.Name = "button_abm_cliente";
            this.button_abm_cliente.Size = new System.Drawing.Size(140, 27);
            this.button_abm_cliente.TabIndex = 5;
            this.button_abm_cliente.Text = "ABM Cliente";
            this.button_abm_cliente.UseVisualStyleBackColor = true;
            this.button_abm_cliente.Click += new System.EventHandler(this.button_abm_cliente_Click);
            // 
            // button_abm_empresa
            // 
            this.button_abm_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_abm_empresa.Location = new System.Drawing.Point(186, 172);
            this.button_abm_empresa.Name = "button_abm_empresa";
            this.button_abm_empresa.Size = new System.Drawing.Size(140, 27);
            this.button_abm_empresa.TabIndex = 6;
            this.button_abm_empresa.Text = "ABM Empresa";
            this.button_abm_empresa.UseVisualStyleBackColor = true;
            this.button_abm_empresa.Click += new System.EventHandler(this.button_abm_empresa_Click);
            // 
            // button_abm_sucursal
            // 
            this.button_abm_sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_abm_sucursal.Location = new System.Drawing.Point(25, 219);
            this.button_abm_sucursal.Name = "button_abm_sucursal";
            this.button_abm_sucursal.Size = new System.Drawing.Size(140, 27);
            this.button_abm_sucursal.TabIndex = 7;
            this.button_abm_sucursal.Text = "ABM Sucursal";
            this.button_abm_sucursal.UseVisualStyleBackColor = true;
            this.button_abm_sucursal.Click += new System.EventHandler(this.button_abm_sucursal_Click);
            // 
            // button_abm_facturas
            // 
            this.button_abm_facturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_abm_facturas.Location = new System.Drawing.Point(186, 219);
            this.button_abm_facturas.Name = "button_abm_facturas";
            this.button_abm_facturas.Size = new System.Drawing.Size(140, 27);
            this.button_abm_facturas.TabIndex = 8;
            this.button_abm_facturas.Text = "ABM Facturas";
            this.button_abm_facturas.UseVisualStyleBackColor = true;
            this.button_abm_facturas.Click += new System.EventHandler(this.button_abm_facturas_Click);
            // 
            // button_estadisticas
            // 
            this.button_estadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_estadisticas.Location = new System.Drawing.Point(25, 125);
            this.button_estadisticas.Name = "button_estadisticas";
            this.button_estadisticas.Size = new System.Drawing.Size(140, 27);
            this.button_estadisticas.TabIndex = 3;
            this.button_estadisticas.Text = "Estadisticas";
            this.button_estadisticas.UseVisualStyleBackColor = true;
            this.button_estadisticas.Click += new System.EventHandler(this.button_estadisticas_Click);
            // 
            // button_pagar
            // 
            this.button_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pagar.Location = new System.Drawing.Point(25, 79);
            this.button_pagar.Name = "button_pagar";
            this.button_pagar.Size = new System.Drawing.Size(140, 27);
            this.button_pagar.TabIndex = 1;
            this.button_pagar.Text = "Registrar Pago";
            this.button_pagar.UseVisualStyleBackColor = true;
            this.button_pagar.Click += new System.EventHandler(this.button_pagar_Click);
            // 
            // button_rendir
            // 
            this.button_rendir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rendir.Location = new System.Drawing.Point(186, 79);
            this.button_rendir.Name = "button_rendir";
            this.button_rendir.Size = new System.Drawing.Size(140, 27);
            this.button_rendir.TabIndex = 2;
            this.button_rendir.Text = "Rendir Facturas";
            this.button_rendir.UseVisualStyleBackColor = true;
            this.button_rendir.Click += new System.EventHandler(this.button_rendir_Click);
            // 
            // button_salir
            // 
            this.button_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salir.ForeColor = System.Drawing.Color.DarkRed;
            this.button_salir.Location = new System.Drawing.Point(186, 267);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(140, 27);
            this.button_salir.TabIndex = 9;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // button_devolver
            // 
            this.button_devolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_devolver.Location = new System.Drawing.Point(25, 267);
            this.button_devolver.Name = "button_devolver";
            this.button_devolver.Size = new System.Drawing.Size(140, 27);
            this.button_devolver.TabIndex = 10;
            this.button_devolver.Text = "Devolver Factura";
            this.button_devolver.UseVisualStyleBackColor = true;
            this.button_devolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 306);
            this.Controls.Add(this.button_devolver);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.button_rendir);
            this.Controls.Add(this.button_pagar);
            this.Controls.Add(this.button_estadisticas);
            this.Controls.Add(this.button_abm_facturas);
            this.Controls.Add(this.button_abm_sucursal);
            this.Controls.Add(this.button_abm_empresa);
            this.Controls.Add(this.button_abm_cliente);
            this.Controls.Add(this.button_abm_rol);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.label_fecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.Text = "Pago Agil";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Button button_abm_rol;
        private System.Windows.Forms.Button button_abm_cliente;
        private System.Windows.Forms.Button button_abm_empresa;
        private System.Windows.Forms.Button button_abm_sucursal;
        private System.Windows.Forms.Button button_abm_facturas;
        private System.Windows.Forms.Button button_estadisticas;
        private System.Windows.Forms.Button button_pagar;
        private System.Windows.Forms.Button button_rendir;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.Button button_devolver;
    }
}