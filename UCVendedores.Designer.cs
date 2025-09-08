namespace proyecto_Famular_Lezcano
{
    partial class UCVendedores
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            LTitulo = new Label();
            BAgregar = new Button();
            SuspendLayout();
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Location = new Point(24, 31);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(146, 15);
            LTitulo.TabIndex = 0;
            LTitulo.Text = "GESTION DE VENDEDORES";
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(467, 31);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(152, 23);
            BAgregar.TabIndex = 1;
            BAgregar.Text = "Agregar Vendedor";
            BAgregar.UseVisualStyleBackColor = true;
            // 
            // UCVendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BAgregar);
            Controls.Add(LTitulo);
            Name = "UCVendedores";
            Size = new Size(635, 490);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LTitulo;
        private Button BAgregar;
    }
}
