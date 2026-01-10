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
            ConfigureAccess();
        }

        private void ConfigureAccess()
        {
            if (_loggedUser.LoginRole != "Admin")
            {
                //tabAdmin.Visible = false;
            }
        }
    }
}
