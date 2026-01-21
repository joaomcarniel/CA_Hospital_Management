using CA_Hospital_Management.Models.DTOs;
using CA_Hospital_Management.Models.Entities;
using CA_Hospital_Management.Repositories;
using CA_Hospital_Management.Services;

namespace CA_Hospital_Management.UserControls
{
    public partial class DoctorsControl : UserControl
    {
        private DoctorRepository _doctorRepo;
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

            LoadDoctors();
            ComboLoader.LoadCountyCombo(cmbCounty);
            ComboLoader.LoadGenderCombo(cmbGender);
            ComboLoader.LoadContractCombo(cmbContract);

            CenterFormPanel();
            dgvDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadDoctors()
        {
            var result = _doctorRepo.SearchDoctorsPaged(
                txtSearchDoctor.Text.Trim(),
                _currentPage,
                PageSize);

            UpdateDataGrid(result);
        }

        private void UpdateDataGrid(ListPaginated<Doctor> result)
        {
            dgvDoctors.DataSource = result.Items;

            _totalPages = result.TotalPages;
            lblPagination.Text = $"Page {_currentPage} of {_totalPages} ({result.TotalRecords} doctors)";

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;
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
                if (!ValidateForm())
                    return;

                var doctor = BuildDoctor(false);
                _doctorRepo.CreateDoctor(doctor);
                ClearForm();
                LoadDoctors();
                FrontMessager.BuildSuccessMessage(lblMessage, "Doctor", "Created");
            }
            catch (Exception ex)
            {
                FrontMessager.BuildExceptionMessage(lblMessage, ex.Message);
            }
        }

        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedDoctorId == null) return;

                var doctor = BuildDoctor();

                _doctorRepo.UpdateDoctor(doctor);
                ClearForm();
                LoadDoctors();
                FrontMessager.BuildSuccessMessage(lblMessage, "Doctor", "Updated");

            }
            catch (Exception ex)
            {
                FrontMessager.BuildExceptionMessage(lblMessage, ex.Message);
            }
        }

        private Doctor BuildDoctor(bool useId = true)
        {
            return new Doctor
            {
                DoctorId = useId ? _selectedDoctorId.Value : 0,
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
        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedDoctorId == null) return;

                _doctorRepo.DeleteDoctor(_selectedDoctorId.Value);

                ClearForm();
                LoadDoctors();
                FrontMessager.BuildSuccessMessage(lblMessage, "Doctor", "Deleted");
            }
            catch (Exception ex)
            {
                FrontMessager.BuildExceptionMessage(lblMessage, ex.Message);
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
            lblMessage.Text = "";
        }

        private bool ValidateForm()
        {
            Dictionary<string, String> fields = new Dictionary<string, String>();
            string countyValidator = cmbCounty.SelectedIndex == -1 ? "" : "County";
            string contractValidator = cmbContract.SelectedIndex == -1 ? "" : "Contract";
            string genderValidator = cmbGender.SelectedIndex == -1 ? "" : "Gender";
            string salaryValidator = numSalary.Value <= 0 ? "" : "Salary";

            fields.Add("First Name", txtFirstName.Text);
            fields.Add("Last Name", txtLastName.Text);
            fields.Add("Phone", txtPhone.Text);
            fields.Add("Email", txtEmail.Text);
            fields.Add("Department", txtDepartment.Text);
            fields.Add("Address", txtAddress.Text);
            fields.Add("County", countyValidator);
            fields.Add("Contract", contractValidator);
            fields.Add("Gender", genderValidator);
            fields.Add("Salary", salaryValidator);
            return FormsValidator.ValidateForm(fields, lblError);
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