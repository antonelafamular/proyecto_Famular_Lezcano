namespace proyecto_Famular_Lezcano
{
    public partial class FormMain : Form
    {
        private string rolUsuario;
        public FormMain(string rol)
        {
            InitializeComponent();

            rolUsuario = rol;
        }

        private void LoadUserControl(UserControl uc)
        {
            PanelContent.Controls.Clear();   // Limpia lo que haya antes
            uc.Dock = DockStyle.Fill;        // Que ocupe todo el panel
            PanelContent.Controls.Add(uc);   // Agrega el nuevo control
        }

    }
}
