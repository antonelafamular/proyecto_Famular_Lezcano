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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        List<Usuario> usuarios = new List<Usuario>()
        {
            new Usuario() { Nombre = "vendedor1", Password = "123", Rol = "Vendedor" },
            new Usuario() { Nombre = "gerente1", Password = "123", Rol = "Gerente" }
        };
        private void BLogin_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = TUsuario.Text;
            string passIngresado = TPassword.Text;

            var usuario = usuarios.FirstOrDefault(u => u.Nombre == usuarioIngresado && u.Password == passIngresado);

            if (usuario != null)
            {
                // Abrir el FormMain y pasar el rol
                FormMain formMain = new FormMain(usuario.Rol);
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}

public class Usuario
{
    public string? Nombre { get; set; }
    public string? Password { get; set; }
    public string? Rol { get; set; } // "Vendedor" o "Gerente"
}
