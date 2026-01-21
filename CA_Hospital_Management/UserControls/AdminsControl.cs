using CA_Hospital_Management.Models.Entities;
using CA_Hospital_Management.Repositories;
using CA_Hospital_Management.Services;

namespace CA_Hospital_Management.UserControls
{
    public partial class AdminsControl : UserControl
    {
        private AdminRepository _adminRepo;
        private int _currentPage = 1;
        private const int PageSize = 10;
        private int _totalPages = 0;
        private int? _selectedAdminId = null;
        public AdminsControl()
        {
            InitializeComponent();
        }

        private void AdminsControl_Load(object sender, EventArgs e)
        {
            _adminRepo = new AdminRepository();
            LoadAdmins();

            ComboLoader.LoadActiveCombo(cmbActive);
            ComboLoader.LoadRoleCombo(cmbRole);
            mainDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadAdmins()
        {
            var result = _adminRepo.SearchLoginsPaged(
               _currentPage,
               PageSize);

            mainDgv.DataSource = result.Items;

            _totalPages = result.TotalPages;
            lblPagination.Text = $"Page {_currentPage} of {_totalPages} ({result.TotalRecords} Consultations)";

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm())
                    return;

                var login = new Login
                {
                    LoginUserName = txtUsername.Text,
                    LoginPassword = PasswordHasher.HashPassword(txtPassword.Text),
                    LoginIsActive = cmbActive.Text.Equals("sim") ? 1 : 0,
                    LoginRole = cmbRole.Text,
                };
                _adminRepo.CreateLogin(login);
                ClearForm();
                LoadAdmins();
                lblMessage.Text = $"Login created successfully.";
                lblMessage.ForeColor = Color.Green;
                lblMessage.Visible = true;
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Error: {ex.Message}";
                lblMessage.ForeColor = Color.Red;
                lblMessage.Visible = true;
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                lblError.Text = "Username is required";
                lblError.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblError.Text = "Password is required";
                lblError.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(cmbActive.Text))
            {
                lblError.Text = "Active is required";
                lblError.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                lblError.Text = "Role is required";
                lblError.Visible = true;
                isValid = false;
            }
            return isValid;
        }

        private void ClearForm()
        {
            txtPassword.Clear();
            txtUsername.Clear();
            _selectedAdminId = null;

            lblError.Text = "";
            lblMessage.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedAdminId == null) return;

                var consultation = new Login
                {
                    LoginId = _selectedAdminId.Value,
                    LoginUserName = txtUsername.Text,
                    LoginIsActive = cmbActive.Text.Equals("sim") ? 1 : 0,
                    LoginRole = cmbRole.Text
                };

                _adminRepo.UpdateLogin(consultation);
                ClearForm();
                LoadAdmins();
                lblMessage.Text = $"Login Updated successfully.";
                lblMessage.ForeColor = Color.Green;
                lblMessage.Visible = true;

            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Error: {ex.Message}";
                lblMessage.ForeColor = Color.Red;
                lblMessage.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedAdminId == null) return;

                _adminRepo.DeleteLogin(_selectedAdminId.Value);

                ClearForm();
                LoadAdmins();
                lblMessage.Text = $"Login {_selectedAdminId} Deleted successfully.";
                lblMessage.ForeColor = Color.Green;
                lblMessage.Visible = true;
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Error: {ex.Message}";
                lblMessage.ForeColor = Color.Red;
                lblMessage.Visible = true;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadAdmins();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_totalPages > 1)
            {
                _currentPage++;
                LoadAdmins();
            }
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedAdminId == null) return;

                var login = new Login
                {
                    LoginId = _selectedAdminId.Value,
                    LoginUserName = txtUsername.Text,
                    LoginPassword = PasswordHasher.HashPassword(txtPassword.Text),
                    LoginIsActive = cmbActive.Text.Equals("Yes") ? 1 : 0,
                    LoginRole = cmbRole.Text
                };

                _adminRepo.UpdatePasswordLogin(login);
                ClearForm();
                LoadAdmins();
                lblMessage.Text = $"Login Updated successfully.";
                lblMessage.ForeColor = Color.Green;
                lblMessage.Visible = true;

            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Error: {ex.Message}";
                lblMessage.ForeColor = Color.Red;
                lblMessage.Visible = true;
            }
        }

        private void mainDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var login = mainDgv.Rows[e.RowIndex].DataBoundItem as Login;
            if (login == null) return;

            _selectedAdminId = login.LoginId;
            txtUsername.Text = login.LoginUserName;
            txtPassword.Text = login.LoginPassword;
            cmbRole.Text = login.LoginRole;
            cmbActive.Text = login.LoginIsActive == 1 ? "Yes" : "No";
        }
    }
}
