namespace proyecto_Famular_Lezcano
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void LoadUserControl(UserControl uc)
        {
            PanelContent.Controls.Clear();   // Limpia lo que haya antes
            uc.Dock = DockStyle.Fill;        // Que ocupe todo el panel
            PanelContent.Controls.Add(uc);   // Agrega el nuevo control
        }

    }
}
