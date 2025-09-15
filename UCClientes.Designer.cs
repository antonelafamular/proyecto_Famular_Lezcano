﻿/*namespace proyecto_Famular_Lezcano
{
    partial class UCClientes
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.IBeam;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(19, 19);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 0;
            label1.Text = "CLIENTES";
            label1.Click += label1_Click;
            // 
            // UCClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImageLayout = ImageLayout.Center;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCClientes";
            Size = new Size(464, 369);
            Load += UCClientes_Load;
            ResumeLayout(false);
            PerformLayout();
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelTitulo);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Name = "UCClientes";
            Size = new Size(900, 500);
            Load += UCClientes_Load;
            */
namespace proyecto_Famular_Lezcano
{
    partial class UCClientes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // 🔹 DECLARACIÓN de controles
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;

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

        private void InitializeComponent()
        {
            labelTitulo = new Label();
            dgvUsuarios = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            btnAgregarUsuario = new Button();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitulo.ForeColor = Color.Maroon;
            labelTitulo.Location = new Point(20, 20);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(242, 32);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Gestión de Usuarios";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            dgvUsuarios.Location = new Point(30, 70);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(850, 300);
            dgvUsuarios.TabIndex = 1;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Apellido";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Usuario";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Email";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Rol";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Estado";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Acciones";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = Color.FromArgb(128, 64, 0);
            btnAgregarUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregarUsuario.ForeColor = Color.White;
            btnAgregarUsuario.Location = new Point(700, 20);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(170, 35);
            btnAgregarUsuario.TabIndex = 2;
            btnAgregarUsuario.Text = "+ Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.LightGray;
            btnAnterior.Location = new Point(20, 400);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(100, 30);
            btnAnterior.TabIndex = 3;
            btnAnterior.Text = "← Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.Maroon;
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(770, 400);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(100, 30);
            btnSiguiente.TabIndex = 4;
            btnSiguiente.Text = "Siguiente →";
            btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // UCClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelTitulo);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Name = "UCClientes";
            Size = new Size(900, 500);
            Load += UCClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

      
  
