using System;
using System.Linq;
using System.Windows.Forms;
using proyecto_Famular_Lezcano.Models; // 👈 para acceder al DbContext y Usuario

namespace proyecto_Famular_Lezcano
{
    public partial class UCVendedores : UserControl
    {
        private ProyectoFamularLezcanoContext _context;

        public UCVendedores()
        {
            InitializeComponent();

            _context = new ProyectoFamularLezcanoContext();

            dgvVendedores.AutoGenerateColumns = false;
            dgvVendedores.Columns.Clear();

            // Agrego columnas en el orden correcto
            dgvVendedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "Nombre"
            });
            dgvVendedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Apellido",
                DataPropertyName = "Apellido"
            });
            dgvVendedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Usuario",
                DataPropertyName = "NombreUsuario"   // 👈 propiedad real
            });
            dgvVendedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Password (Hash)",
                DataPropertyName = "Contrasena"      // 👈 guardamos hash
            });
            dgvVendedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                DataPropertyName = "Email"
            });
            dgvVendedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Rol",
                DataPropertyName = "Rol"
            });

            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            var usuarios = _context.Usuarios.ToList();
            dgvVendedores.DataSource = usuarios;
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            using (FormAgregarUsuario form = new FormAgregarUsuario())
            {
                if (form.ShowDialog() == DialogResult.OK && form.NuevoUsuario != null)
                {
                    _context.Usuarios.Add(form.NuevoUsuario);
                    _context.SaveChanges();
                    CargarUsuarios(); // refrescar el grid
                }
            }
        }
    }
}
