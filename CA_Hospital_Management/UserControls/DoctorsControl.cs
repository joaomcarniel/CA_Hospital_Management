using CA_Hospital_Management.Models.Entities;
using CA_Hospital_Management.Models.Enums;
using CA_Hospital_Management.Repositories;
using HospitalManagement.Repositories;

namespace CA_Hospital_Management.UserControls
{
    public partial class DoctorsControl : UserControl
    {
        private DoctorRepository _doctorRepo;
        private HospitalRepository _hospitalRepo;
        private int? _selectedDoctorId = null;
        private int _currentPage = 1;
        private const int PageSize = 10;
        private int _totalPages = 0;

        public DoctorsControl()
        {
            InitializeComponent();
        }

        private void DoctorsControl_Load(object sender, EventArgs e)
        {
            _doctorRepo = new DoctorRepository();
            _hospitalRepo = new HospitalRepository();

            LoadDoctors();
            LoadCountyCombo();
            LoadGenderCombo();
            LoadContractCombo();

            CenterFormPanel();
            dgvDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadDoctors()
        {
            var result = _doctorRepo.SearchDoctorsPaged(
                txtSearchDoctor.Text.Trim(),
                _currentPage,
                PageSize);

            dgvDoctors.DataSource = result.Items;

            _totalPages = result.TotalPages;
            lblPagination.Text = $"Page {_currentPage} of {_totalPages} ({result.TotalRecords} doctors)";

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;
        }

        private void LoadCountyCombo()
        {
            cmbCounty.DataSource = Enum.GetValues(typeof(CountiesEnum));
            cmbCounty.SelectedIndex = -1;
        }

        private void LoadGenderCombo()
        {
            cmbGender.DataSource = Enum.GetValues(typeof(GenderEnum));
            cmbGender.SelectedIndex = -1;
        }

        private void LoadContractCombo()
        {
            cmbContract.DataSource = Enum.GetValues(typeof(ContractsEnum));
            cmbContract.SelectedIndex = -1;
        }

        private void dgvDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var doctor = dgvDoctors.Rows[e.RowIndex].DataBoundItem as Doctor;
            if (doctor == null) return;

            _selectedDoctorId = doctor.DoctorId;
            txtFirstName.Text = doctor.FirstName;
            txtLastName.Text = doctor.LastName;
            txtPhone.Text = doctor.Phone;
            txtEmail.Text = doctor.Email;
            txtAddress.Text = doctor.Address;
            cmbCounty.Text = doctor.County;
            cmbGender.Text = doctor.Gender;
            cmbContract.Text = doctor.ContractType;
            txtDepartment.Text = doctor.Department;
            numSalary.Value = doctor.Pay;
            dtpDoB.Value = doctor.Dob;
        }

        private void btnCreateDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateDoctorForm())
                    return;

                var doctor = new Doctor
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    County = cmbCounty.Text,
                    Gender = cmbGender.Text,
                    Pay = numSalary.Value,
                    Department = txtDepartment.Text,
                    ContractType = cmbContract.Text,
                    Dob = DateTime.Parse(dtpDoB.Text)
                };
                _doctorRepo.CreateDoctor(doctor);
                ClearForm();
                LoadDoctors();
                lblDocMessage.Text = $"Doctor {doctor.FirstName} {doctor.LastName} created successfully.";
                lblDocMessage.ForeColor = Color.Green;
                lblDocMessage.Visible = true;
            }
            catch (Exception ex)
            {
                lblDocMessage.Text = $"Error: {ex.Message}";
                lblDocMessage.ForeColor = Color.Red;
                lblDocMessage.Visible = true;
            }
        }

        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedDoctorId == null) return;

                var doctor = new Doctor
                {
                    DoctorId = _selectedDoctorId.Value,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Department = txtDepartment.Text,
                    ContractType = cmbContract.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    County = cmbCounty.Text,
                    Gender = cmbGender.Text,
                    Pay = numSalary.Value,
                    Dob = DateTime.Parse(dtpDoB.Text)
                };

                _doctorRepo.UpdateDoctor(doctor);
                ClearForm();
                LoadDoctors();
                lblDocMessage.Text = $"Doctor {doctor.FirstName} {doctor.LastName} Updated successfully.";
                lblDocMessage.ForeColor = Color.Green;
                lblDocMessage.Visible = true;

            }
            catch (Exception ex)
            {
                lblDocMessage.Text = $"Error: {ex.Message}";
                lblDocMessage.ForeColor = Color.Red;
                lblDocMessage.Visible = true;
            }
        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedDoctorId == null) return;

                _doctorRepo.DeleteDoctor(_selectedDoctorId.Value);

                ClearForm();
                LoadDoctors();
                lblDocMessage.Text = $"Doctor {_selectedDoctorId} Deleted successfully.";
                lblDocMessage.ForeColor = Color.Green;
                lblDocMessage.Visible = true;
            }
            catch (Exception ex)
            {
                lblDocMessage.Text = $"Error: {ex.Message}";
                lblDocMessage.ForeColor = Color.Red;
                lblDocMessage.Visible = true;
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
            txtDepartment.Clear();
            cmbCounty.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            cmbContract.SelectedIndex = -1;
            numSalary.Value = 0;
            _selectedDoctorId = null;
            lblError.Text = "";
            lblError.Text = "";
            lblDocMessage.Text = "";
        }

        private bool ValidateDoctorForm()
        {
            bool isValid = true;

            HideDoctorErrors();

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                lblError.Text = "First name is required";
                lblError.Visible = true;
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                lblError.Text = "Last name is required";
                lblError.Visible = true;
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                lblError.Text = "Phone is required";
                lblError.Visible = true;
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblError.Text = "Email is required";
                lblError.Visible = true;
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                lblError.Text = "Address is required";
                lblError.Visible = true;
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDepartment.Text))
            {
                lblError.Text = "Department is required";
                lblError.Visible = true;
                return false;
            }

            if (cmbCounty.SelectedIndex == -1)
            {
                lblError.Text = "County is required";
                lblError.Visible = true;
                return false;
            }

            if (cmbContract.SelectedIndex == -1)
            {
                lblError.Text = "Contract is required";
                lblError.Visible = true;
                return false;
            }

            if (cmbGender.SelectedIndex == -1)
            {
                lblError.Text = "Gender is required";
                lblError.Visible = true;
                return false;
            }

            if (numSalary.Value <= 0)
            {
                lblError.Text = "Salary must be greater than zero";
                lblError.Visible = true;
                return false;
            }

            return isValid;
        }

        private void HideDoctorErrors()
        {
            lblError.Visible = false;
            lblDocMessage.Visible = false;
        }

        private void CenterFormPanel()
        {
            if (panelForm == null) return;

            panelForm.Left = (splitDoctors.Panel1.Width - panelForm.Width) / 2;
            panelForm.Top = (splitDoctors.Panel1.Height - panelForm.Height) / 2;
        }


        private void btnListDoctors_Click(object sender, EventArgs e)
        {
            LoadDoctors();
        }

        private void splitDoctors_Panel1_Resize(object sender, EventArgs e)
        {
            CenterFormPanel();
        }

        private void btnGetDoctor_Click(object sender, EventArgs e)
        {
            LoadDoctors();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadDoctors();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_totalPages > 1)
            {
                _currentPage++;
                LoadDoctors();
            }
        }
    }
}
