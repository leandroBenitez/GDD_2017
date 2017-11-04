namespace PagoAgilFrba.Login
{
    partial class Login
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
            this.boton_validar = new System.Windows.Forms.Button();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.warning_user = new System.Windows.Forms.Label();
            this.warning_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pago Agil";
            // 
            // boton_validar
            // 
            this.boton_validar.Location = new System.Drawing.Point(137, 150);
            this.boton_validar.Name = "boton_validar";
            this.boton_validar.Size = new System.Drawing.Size(120, 23);
            this.boton_validar.TabIndex = 3;
            this.boton_validar.Text = "Ingresar";
            this.boton_validar.UseVisualStyleBackColor = true;
            this.boton_validar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_User
            // 
            this.textBox_User.Location = new System.Drawing.Point(104, 57);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(139, 20);
            this.textBox_User.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña:";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(104, 101);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(139, 20);
            this.textBox_Password.TabIndex = 7;
            // 
            // warning_user
            // 
            this.warning_user.AutoSize = true;
            this.warning_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_user.ForeColor = System.Drawing.Color.Red;
            this.warning_user.Location = new System.Drawing.Point(134, 80);
            this.warning_user.Name = "warning_user";
            this.warning_user.Size = new System.Drawing.Size(93, 13);
            this.warning_user.TabIndex = 8;
            this.warning_user.Text = "Usuario incorrecto";
            // 
            // warning_password
            // 
            this.warning_password.AutoSize = true;
            this.warning_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_password.ForeColor = System.Drawing.Color.Red;
            this.warning_password.Location = new System.Drawing.Point(118, 124);
            this.warning_password.Name = "warning_password";
            this.warning_password.Size = new System.Drawing.Size(111, 13);
            this.warning_password.TabIndex = 9;
            this.warning_password.Text = "Contraseña incorrecta";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 185);
            this.Controls.Add(this.warning_password);
            this.Controls.Add(this.warning_user);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.boton_validar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_validar;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label warning_user;
        private System.Windows.Forms.Label warning_password;
    }
}