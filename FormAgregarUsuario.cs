using System;
using System.Windows.Forms;
using BCrypt.Net;
using proyecto_Famular_Lezcano.Models;

namespace proyecto_Famular_Lezcano
{
    public partial class FormAgregarUsuario : Form
    {
        public Usuario? NuevoUsuario { get; private set; }

        public FormAgregarUsuario()
        {
            InitializeComponent();
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TNomUsuario.Text) ||
                string.IsNullOrWhiteSpace(TContraseña.Text) ||
                string.IsNullOrWhiteSpace(TEmail.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Encriptar la contraseña
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(TContraseña.Text);

            NuevoUsuario = new Usuario
            {
                Nombre = TNombre.Text,
                Apellido = TApellido.Text,
                NombreUsuario = TNomUsuario.Text,   // 👈 propiedad real en tu modelo
                Contrasena = hashedPassword,        // 👈 guardamos el hash
                Email = TEmail.Text,
                Rol = "Vendedor", 
                Estado = 1
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
