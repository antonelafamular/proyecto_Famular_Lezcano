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
            dgvVendedores = new DataGridView();
            nombre_vendedor = new DataGridViewTextBoxColumn();
            apellido_vendedor = new DataGridViewTextBoxColumn();
            acronimo_vendedor = new DataGridViewTextBoxColumn();
            email_vendedor = new DataGridViewTextBoxColumn();
            estado_vendedor = new DataGridViewTextBoxColumn();
            acciones = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).BeginInit();
            SuspendLayout();
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Location = new Point(14, 31);
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
            BAgregar.Click += BAgregar_Click;
            // 
            // dgvVendedores
            // 
            dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendedores.Columns.AddRange(new DataGridViewColumn[] { nombre_vendedor, apellido_vendedor, acronimo_vendedor, email_vendedor, estado_vendedor, acciones });
            dgvVendedores.Location = new Point(3, 139);
            dgvVendedores.Name = "dgvVendedores";
            dgvVendedores.Size = new Size(629, 164);
            dgvVendedores.TabIndex = 2;
            // 
            // nombre_vendedor
            // 
            nombre_vendedor.HeaderText = "Nombre";
            nombre_vendedor.Name = "nombre_vendedor";
            // 
            // apellido_vendedor
            // 
            apellido_vendedor.HeaderText = "Apellido";
            apellido_vendedor.Name = "apellido_vendedor";
            // 
            // acronimo_vendedor
            // 
            acronimo_vendedor.HeaderText = "Acronimo";
            acronimo_vendedor.Name = "acronimo_vendedor";
            // 
            // email_vendedor
            // 
            email_vendedor.HeaderText = "Email";
            email_vendedor.Name = "email_vendedor";
            // 
            // estado_vendedor
            // 
            estado_vendedor.HeaderText = "Estado";
            estado_vendedor.Name = "estado_vendedor";
            // 
            // acciones
            // 
            acciones.HeaderText = "Acciones";
            acciones.Name = "acciones";
            // 
            // UCVendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvVendedores);
            Controls.Add(BAgregar);
            Controls.Add(LTitulo);
            Name = "UCVendedores";
            Size = new Size(635, 490);
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LTitulo;
        private Button BAgregar;
        private DataGridView dgvVendedores;
        private DataGridViewTextBoxColumn nombre_vendedor;
        private DataGridViewTextBoxColumn apellido_vendedor;
        private DataGridViewTextBoxColumn acronimo_vendedor;
        private DataGridViewTextBoxColumn email_vendedor;
        private DataGridViewTextBoxColumn estado_vendedor;
        private DataGridViewTextBoxColumn acciones;
    }
}
