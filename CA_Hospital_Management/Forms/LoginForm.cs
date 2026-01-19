using CA_Hospital_Management.Forms;
using CA_Hospital_Management.Repositories;
using CA_Hospital_Management.Services;

namespace CA_Hospital_Management
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();

            var repo = new LoginRepository();

            var user = repo.ValidateLogin(username);

            if (user != null && user.LoginIsActive == 1 && PasswordHasher.VerifyPassword(password, user.LoginPassword))
            {
                this.Hide();

                var mainForm = new MainForm(user);
                mainForm.Show();
            }
            else
            {
                lblError.Text = "Invalid username or password.";
                lblError.Visible = true;
            }
        }
    }
}
