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
    public partial class UCVendedores : UserControl
    {
        private BindingList<Usuario> listaUsuarios;
        public UCVendedores()
        {
            InitializeComponent();
            listaUsuarios = new BindingList<Usuario>();

            dgvVendedores.DataSource = listaUsuarios;

            // Opcional: configurar columnas
            dgvVendedores.AutoGenerateColumns = true;
        }


        private void BAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarVendedor? form = new FormAgregarVendedor();
            if (form.ShowDialog() == DialogResult.OK && form.NuevoUsuario != null)
            {
                listaUsuarios.Add(form.NuevoUsuario);
            }
        }
    }

    public class Usuario
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? UsuarioLogin { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Rol { get; set; }
        public string? Estado { get; set; }
    }
}
