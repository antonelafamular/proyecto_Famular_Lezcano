namespace proyecto_Famular_Lezcano
{
    partial class FormLogin
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
            LUsuario = new Label();
            LPassword = new Label();
            TUsuario = new TextBox();
            TPassword = new TextBox();
            BLogin = new Button();
            SuspendLayout();
            // 
            // LUsuario
            // 
            LUsuario.AutoSize = true;
            LUsuario.Location = new Point(110, 9);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(47, 15);
            LUsuario.TabIndex = 0;
            LUsuario.Text = "Usuario";
            // 
            // LPassword
            // 
            LPassword.AutoSize = true;
            LPassword.Location = new Point(99, 80);
            LPassword.Name = "LPassword";
            LPassword.Size = new Size(67, 15);
            LPassword.TabIndex = 1;
            LPassword.Text = "Contraseña";
            // 
            // TUsuario
            // 
            TUsuario.Location = new Point(84, 38);
            TUsuario.Name = "TUsuario";
            TUsuario.Size = new Size(100, 23);
            TUsuario.TabIndex = 2;
            // 
            // TPassword
            // 
            TPassword.Location = new Point(84, 113);
            TPassword.Name = "TPassword";
            TPassword.Size = new Size(100, 23);
            TPassword.TabIndex = 3;
            // 
            // BLogin
            // 
            BLogin.Location = new Point(99, 151);
            BLogin.Name = "BLogin";
            BLogin.Size = new Size(75, 23);
            BLogin.TabIndex = 4;
            BLogin.Text = "Ingresar";
            BLogin.UseVisualStyleBackColor = true;
            BLogin.Click += BLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 195);
            Controls.Add(BLogin);
            Controls.Add(TPassword);
            Controls.Add(TUsuario);
            Controls.Add(LPassword);
            Controls.Add(LUsuario);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LUsuario;
        private Label LPassword;
        private TextBox TUsuario;
        private TextBox TPassword;
        private Button BLogin;
    }
}