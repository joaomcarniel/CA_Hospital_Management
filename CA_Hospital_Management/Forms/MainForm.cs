using CA_Hospital_Management.Models;
using CA_Hospital_Management.UserControls;

namespace CA_Hospital_Management.Forms
{
    public partial class MainForm : Form
    {
        private readonly Login _loggedUser;

        public MainForm(Login user)
        {
            InitializeComponent();
            _loggedUser = user;

            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            HideTabHeaders();
            ConfigureAccess();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }


        private void menuDoctors_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabDoctors;
        }

        private void menuNurses_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabNurses;
        }

        private void HideTabHeaders()
        {
            tabControlMain.Appearance = TabAppearance.FlatButtons;
            tabControlMain.ItemSize = new System.Drawing.Size(0, 1);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
        }

        private void ConfigureAccess()
        {
            if (_loggedUser.LoginRole != "Admin")
            {
                tabAdmin.Parent = null;
            }
        }

        private void doctorsControl1_Load(object sender, EventArgs e)
        {

        }

        private void menuPatients_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPatients;
        }
    }
}
