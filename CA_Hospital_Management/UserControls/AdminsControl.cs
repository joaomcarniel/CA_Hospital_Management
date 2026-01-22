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

                var login = BuildLogin(false);
                _adminRepo.CreateLogin(login);
                ClearForm();
                LoadAdmins();
                FrontMessager.BuildSuccessMessage(lblMessage, "Login", "Created");
            }
            catch (Exception ex)
            {
                FrontMessager.BuildExceptionMessage(lblMessage, ex.Message);
            }
        }

        private bool ValidateForm()
        {
            Dictionary<string, String> fields = new Dictionary<string, String>();

            fields.Add("Username", txtUsername.Text);
            fields.Add("Password", txtPassword.Text);
            fields.Add("Active", cmbActive.Text);
            fields.Add("Role", cmbRole.Text);
            return FormsValidator.ValidateForm(fields, lblError);
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

                var consultation = BuildLogin(true, false);

                _adminRepo.UpdateLogin(consultation);
                ClearForm();
                LoadAdmins();
                FrontMessager.BuildSuccessMessage(lblMessage, "Login", "Updated");

            }
            catch (Exception ex)
            {
                FrontMessager.BuildExceptionMessage(lblMessage, ex.Message);
            }
        }

        private Login BuildLogin(bool useId = true, bool usePassword = true)
        {
            return new Login
            {
                LoginId = useId ? _selectedAdminId.Value : 0,
                LoginUserName = txtUsername.Text,
                LoginPassword = usePassword ? PasswordHasher.HashPassword(txtPassword.Text) : string.Empty,
                LoginIsActive = cmbActive.Text.Equals("Yes") ? 1 : 0,
                LoginRole = cmbRole.Text
            };
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedAdminId == null) return;

                _adminRepo.DeleteLogin(_selectedAdminId.Value);

                ClearForm();
                LoadAdmins();
                FrontMessager.BuildSuccessMessage(lblMessage, "Login", "Deleted");
            }
            catch (Exception ex)
            {
                FrontMessager.BuildExceptionMessage(lblMessage, ex.Message);
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

                var login = BuildLogin(true, true);

                _adminRepo.UpdatePasswordLogin(login);
                ClearForm();
                LoadAdmins();
                FrontMessager.BuildSuccessMessage(lblMessage, "Login", "Updated");

            }
            catch (Exception ex)
            {
                FrontMessager.BuildExceptionMessage(lblMessage, ex.Message);
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
