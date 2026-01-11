using CA_Hospital_Management.Models;

namespace CA_Hospital_Management.Forms
{
    public partial class MainForm : Form
    {
        private readonly Login _loggedUser;

        public MainForm(Login user)
        {
            InitializeComponent();
            _loggedUser = user;

            HideTabHeaders();
            ConfigureAccess();
        }

        private void HideTabHeaders()
        {
            tabControlMain.Appearance = TabAppearance.FlatButtons;
            tabControlMain.ItemSize = new Size(0, 1);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
        }

        private void ConfigureAccess()
        {
            if (_loggedUser.LoginRole != "Admin")
            {
                //tabAdmin.Visible = false;
            }
        }

        private void menuDoctors_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabDoctors;
        }

        private void tabControlMain_Click(object sender, EventArgs e)
        {

        }

        private void menuNurses_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabNurses;
        }
    }
}
