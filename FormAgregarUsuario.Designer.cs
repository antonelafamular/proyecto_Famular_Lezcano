namespace proyecto_Famular_Lezcano
{
    partial class FormAgregarUsuario
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
            TNombre = new TextBox();
            TApellido = new TextBox();
            TNomUsuario = new TextBox();
            TEmail = new TextBox();
            LNombre = new Label();
            LApellido = new Label();
            LNombreUsuario = new Label();
            LEmail = new Label();
            label1 = new Label();
            BAgregar = new Button();
            LContraseña = new Label();
            TContraseña = new TextBox();
            SuspendLayout();
            // 
            // TNombre
            // 
            TNombre.Location = new Point(123, 56);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(267, 23);
            TNombre.TabIndex = 0;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(123, 97);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(267, 23);
            TApellido.TabIndex = 1;
            // 
            // TNomUsuario
            // 
            TNomUsuario.Location = new Point(123, 168);
            TNomUsuario.Name = "TNomUsuario";
            TNomUsuario.Size = new Size(267, 23);
            TNomUsuario.TabIndex = 2;
            // 
            // TEmail
            // 
            TEmail.Location = new Point(123, 205);
            TEmail.Name = "TEmail";
            TEmail.Size = new Size(267, 23);
            TEmail.TabIndex = 3;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(12, 59);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(54, 15);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(12, 100);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 5;
            LApellido.Text = "Apellido";
            // 
            // LNombreUsuario
            // 
            LNombreUsuario.AutoSize = true;
            LNombreUsuario.Location = new Point(4, 171);
            LNombreUsuario.Name = "LNombreUsuario";
            LNombreUsuario.Size = new Size(113, 15);
            LNombreUsuario.TabIndex = 6;
            LNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.Location = new Point(12, 208);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(39, 15);
            LEmail.TabIndex = 7;
            LEmail.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 18);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 8;
            label1.Text = "Agregar Vendedor";
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(154, 236);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(75, 23);
            BAgregar.TabIndex = 9;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Location = new Point(12, 142);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(70, 15);
            LContraseña.TabIndex = 11;
            LContraseña.Text = "Contraseña:";
            // 
            // TContraseña
            // 
            TContraseña.Location = new Point(123, 134);
            TContraseña.Name = "TContraseña";
            TContraseña.Size = new Size(267, 23);
            TContraseña.TabIndex = 10;
            // 
            // FormAgregarVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 274);
            Controls.Add(LContraseña);
            Controls.Add(TContraseña);
            Controls.Add(BAgregar);
            Controls.Add(label1);
            Controls.Add(LEmail);
            Controls.Add(LNombreUsuario);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(TEmail);
            Controls.Add(TNomUsuario);
            Controls.Add(TApellido);
            Controls.Add(TNombre);
            Name = "FormAgregarVendedor";
            Text = "Agregar Vendedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TNombre;
        private TextBox TApellido;
        private TextBox TNomUsuario;
        private TextBox TEmail;
        private Label LNombre;
        private Label LApellido;
        private Label LNombreUsuario;
        private Label LEmail;
        private Label label1;
        private Button BAgregar;
        private Label LContraseña;
        private TextBox TContraseña;
    }
}