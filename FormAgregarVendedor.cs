using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_Famular_Lezcano
{
    public partial class FormAgregarVendedor : Form
    {
        public Usuario? NuevoUsuario { get; private set; }

        public FormAgregarVendedor()
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
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NuevoUsuario = new Usuario
            {
                Nombre = TNombre.Text,
                Apellido = TApellido.Text,
                UsuarioLogin = TNomUsuario.Text,
                Password = TContraseña.Text,
                Email = TEmail.Text,
                Rol = null,
                Estado = null
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
