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

            HideTabHeaders();
            ConfigureAccess();
        }

        // ================= FORM LOAD =================

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Nada obrigatório aqui por enquanto
        }

        // ================= MENU EVENTS =================

        private void menuDoctors_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabDoctors;
        }

        private void menuNurses_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabNurses;
        }

        // ================= UI HELPERS =================

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

        private void LoadTabs()
        {
            var doctorsControl = new DoctorsControl { Dock = DockStyle.Fill };
            tabDoctors.Controls.Add(doctorsControl);

            // futuramente:
            // tabNurses.Controls.Add(new NursesControl { Dock = DockStyle.Fill });
            // tabPatients.Controls.Add(new PatientsControl { Dock = DockStyle.Fill });
        }

        private void doctorsControl2_Load(object sender, EventArgs e)
        {

        }

        private void doctorsControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
