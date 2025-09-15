﻿namespace proyecto_Famular_Lezcano
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
            LTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LTitulo.ForeColor = Color.FromArgb(128, 64, 0);
            LTitulo.Location = new Point(16, 41);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(318, 32);
            LTitulo.TabIndex = 0;
            LTitulo.Text = "GESTION DE VENDEDORES";
            // 
            // BAgregar
            // 
            BAgregar.BackColor = Color.FromArgb(128, 64, 0);
            BAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAgregar.ForeColor = SystemColors.ButtonHighlight;
            BAgregar.Location = new Point(549, 41);
            BAgregar.Margin = new Padding(3, 4, 3, 4);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(174, 31);
            BAgregar.TabIndex = 1;
            BAgregar.Text = "Agregar Vendedor";
            BAgregar.UseVisualStyleBackColor = false;
            BAgregar.Click += BAgregar_Click;
            // 
            // dgvVendedores
            // 
            dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendedores.Columns.AddRange(new DataGridViewColumn[] { nombre_vendedor, apellido_vendedor, acronimo_vendedor, email_vendedor, estado_vendedor, acciones });
            dgvVendedores.Location = new Point(3, 125);
            dgvVendedores.Margin = new Padding(3, 4, 3, 4);
            dgvVendedores.Location = new Point(3, 100);
            dgvVendedores.Name = "dgvVendedores";
            dgvVendedores.RowHeadersWidth = 51;
            dgvVendedores.Size = new Size(719, 219);
            dgvVendedores.TabIndex = 2;
            // 
            // nombre_vendedor
            // 
            nombre_vendedor.HeaderText = "Nombre";
            nombre_vendedor.MinimumWidth = 6;
            nombre_vendedor.Name = "nombre_vendedor";
            nombre_vendedor.Width = 125;
            // 
            // apellido_vendedor
            // 
            apellido_vendedor.HeaderText = "Apellido";
            apellido_vendedor.MinimumWidth = 6;
            apellido_vendedor.Name = "apellido_vendedor";
            apellido_vendedor.Width = 125;
            // 
            // acronimo_vendedor
            // 
            acronimo_vendedor.HeaderText = "Acronimo";
            acronimo_vendedor.MinimumWidth = 6;
            acronimo_vendedor.Name = "acronimo_vendedor";
            acronimo_vendedor.Width = 125;
            // 
            // email_vendedor
            // 
            email_vendedor.HeaderText = "Email";
            email_vendedor.MinimumWidth = 6;
            email_vendedor.Name = "email_vendedor";
            email_vendedor.Width = 125;
            // 
            // estado_vendedor
            // 
            estado_vendedor.HeaderText = "Estado";
            estado_vendedor.MinimumWidth = 6;
            estado_vendedor.Name = "estado_vendedor";
            estado_vendedor.Width = 125;
            // 
            // acciones
            // 
            acciones.HeaderText = "Acciones";
            acciones.MinimumWidth = 6;
            acciones.Name = "acciones";
            acciones.Width = 125;
            // 
            // UCVendedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(dgvVendedores);
            Controls.Add(BAgregar);
            Controls.Add(LTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCVendedores";
            Size = new Size(726, 653);
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
