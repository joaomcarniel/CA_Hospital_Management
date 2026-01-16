using CA_Hospital_Management.Models;
using CA_Hospital_Management.Repositories;
using HospitalManagement.Repositories;

namespace CA_Hospital_Management.UserControls
{
    public partial class NursesControl : UserControl
    {
        private NurseRepository _nurseRepo;
        private HospitalRepository _hospitalRepo;
        private int? _selectedNurseId = null;
        private int _currentPage = 1;
        private const int PageSize = 10;
        private int _totalPages = 0;

        public NursesControl()
        {
            InitializeComponent();
        }

        private void NursesControl_Load(object sender, EventArgs e)
        {
            _nurseRepo = new NurseRepository();
            _hospitalRepo = new HospitalRepository();

            LoadNurses();
            LoadCountyCombo();
            LoadGenderCombo();

            CenterFormPanel();
            mainDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadNurses()
        {
            var result = _nurseRepo.SearchNursesPaged(
                txtSearch.Text.Trim(),
                _currentPage,
                PageSize);

            mainDgv.DataSource = result.Items;

            _totalPages = result.TotalPages;
            lblPagination.Text = $"Page {_currentPage} of {_totalPages} ({result.TotalRecords} nurses)";

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;
        }

        private void LoadCountyCombo()
        {
            cmbCounty.Items.Clear();
            cmbCounty.Items.AddRange(new string[]
            {
                "Carlow","Cavan","Clare","Cork","Donegal","Dublin","Galway","Kerry",
                "Kildare","Kilkenny","Laois","Leitrim","Limerick","Longford","Louth",
                "Mayo","Meath","Monaghan","Offaly","Roscommon","Sligo","Tipperary",
                "Waterford","Westmeath","Wexford","Wicklow"
            });
            cmbCounty.SelectedIndex = -1;
        }

        private void LoadGenderCombo()
        {
            cmbGender.Items.Clear();
            cmbGender.Items.AddRange(new string[]
            {
                "Male", "Female", "Other", "Prefer not to say"
            });
            cmbGender.SelectedIndex = -1;
        }

        private void mainDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var nurse = mainDgv.Rows[e.RowIndex].DataBoundItem as Nurse;
            if (nurse == null) return;

            _selectedNurseId = nurse.NurseId;
            txtFirstName.Text = nurse.FirstName;
            txtLastName.Text = nurse.LastName;
            txtPhone.Text = nurse.Phone;
            txtEmail.Text = nurse.Email;
            txtAddress.Text = nurse.Address;
            cmbCounty.Text = nurse.County;
            cmbGender.Text = nurse.Gender;
            hoursWorked.Value = nurse.HoursWorked;
            dtpDoB.Value = nurse.Dob;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateNurseForm())
                    return;

                var nurse = new Nurse
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    County = cmbCounty.Text,
                    Gender = cmbGender.Text,
                    HoursWorked = int.Parse(hoursWorked.Value.ToString()),
                    Dob = DateTime.Parse(dtpDoB.Text)
                };
                _nurseRepo.CreateNurse(nurse);
                ClearForm();
                LoadNurses();
                lblMessage.Text = $"Nurse {nurse.FirstName} {nurse.LastName} created successfully.";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedNurseId == null) return;

                var nurse = new Nurse
                {
                    NurseId = _selectedNurseId.Value,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    County = cmbCounty.Text,
                    Gender = cmbGender.Text,
                    HoursWorked = int.Parse(hoursWorked.Value.ToString()),
                    Dob = DateTime.Parse(dtpDoB.Text)
                };

                _nurseRepo.UpdateNurse(nurse);
                ClearForm();
                LoadNurses();
                lblMessage.Text = $"Nurse {nurse.FirstName} {nurse.LastName} Updated successfully.";
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
                if (_selectedNurseId == null) return;

                _nurseRepo.DeleteNurse(_selectedNurseId.Value);

                ClearForm();
                LoadNurses();
                lblMessage.Text = $"Nurse {_selectedNurseId} Deleted successfully.";
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            cmbCounty.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            hoursWorked.Value = 0;
            _selectedNurseId = null;

            lblFNameError.Text = "";
            lblLNameError.Text = "";
            lblPhoneError.Text = "";
            lblEmailError.Text = "";
            lblFNameError.Text = "";
            lblLNameError.Text = "";
            lblPhoneError.Text = "";
            lblEmailError.Text = "";
            lblAddrError.Text = "";
            lblCountyError.Text = "";
            lblGenderError.Text = "";
            lblSalaryError.Text = "";
            lblAddrError.Text = "";
            lblCountyError.Text = "";
            lblGenderError.Text = "";
            lblSalaryError.Text = "";
            lblMessage.Text = "";
        }

        private bool ValidateNurseForm()
        {
            bool isValid = true;

            HideErrors();

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                lblFNameError.Text = "First name is required";
                lblFNameError.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                lblLNameError.Text = "Last name is required";
                lblLNameError.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                lblPhoneError.Text = "Phone is required";
                lblPhoneError.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblEmailError.Text = "Email is required";
                lblEmailError.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                lblAddrError.Text = "Address is required";
                lblAddrError.Visible = true;
                isValid = false;
            }

            if (cmbCounty.SelectedIndex == -1)
            {
                lblCountyError.Text = "County is required";
                lblCountyError.Visible = true;
                isValid = false;
            }

            if (cmbGender.SelectedIndex == -1)
            {
                lblGenderError.Text = "Gender is required";
                lblGenderError.Visible = true;
                isValid = false;
            }

            if (hoursWorked.Value <= 0)
            {
                lblSalaryError.Text = "Salary must be greater than zero";
                lblSalaryError.Visible = true;
                isValid = false;
            }

            return isValid;
        }

        private void HideErrors()
        {
            lblFNameError.Visible = false;
            lblLNameError.Visible = false;
            lblPhoneError.Visible = false;
            lblEmailError.Visible = false;
            lblAddrError.Visible = false;
            lblCountyError.Visible = false;
            lblGenderError.Visible = false;
            lblSalaryError.Visible = false;
            lblMessage.Visible = false;
        }

        private void CenterFormPanel()
        {
            if (panelForm == null) return;

            panelForm.Left = (splitCont.Panel1.Width - panelForm.Width) / 2;
            panelForm.Top = (splitCont.Panel1.Height - panelForm.Height) / 2;
        }

        private void splitCont_Panel1_Resize(object sender, EventArgs e)
        {
            CenterFormPanel();
        }

        private void btnGetNurse_Click(object sender, EventArgs e)
        {
            LoadNurses();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadNurses();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_totalPages > 1)
            {
                _currentPage++;
                LoadNurses();
            }
        }

        private void btnMaleNurses_Click(object sender, EventArgs e)
        {
            var result = _nurseRepo.SearchMaleNursesPaged(
                txtSearch.Text.Trim(),
                _currentPage,
                PageSize);

            mainDgv.DataSource = result.Items;

            _totalPages = result.TotalPages;
            lblPagination.Text = $"Page {_currentPage} of {_totalPages} ({result.TotalRecords} nurses)";

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;
        }
    }
}
