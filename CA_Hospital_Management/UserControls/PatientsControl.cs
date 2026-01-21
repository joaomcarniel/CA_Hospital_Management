using CA_Hospital_Management.Models.Entities;
using CA_Hospital_Management.Models.Enums;
using CA_Hospital_Management.Repositories;
using CA_Hospital_Management.Services;
using HospitalManagement.Repositories;

namespace CA_Hospital_Management.UserControls
{
    public partial class PatientsControl : UserControl
    {
        private PatientRepository _patientRepo;
        private HospitalRepository _hospitalRepo;
        private int? _selectedPatientId = null;
        private int _currentPage = 1;
        private const int PageSize = 10;
        private int _totalPages = 0;

        public PatientsControl()
        {
            InitializeComponent();
        }

        private void PatientsControl_Load(object sender, EventArgs e)
        {
            _patientRepo = new PatientRepository();
            _hospitalRepo = new HospitalRepository();

            LoadPatients();
            ComboLoader.LoadCountyCombo(cmbCounty);
            ComboLoader.LoadGenderCombo(cmbGender);

            CenterFormPanel();
            mainDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadPatients()
        {
            var result = _patientRepo.SearchPatientsPaged(
                txtSearch.Text.Trim(),
                _currentPage,
                PageSize);

            mainDgv.DataSource = result.Items;

            _totalPages = result.TotalPages;
            lblPagination.Text = $"Page {_currentPage} of {_totalPages} ({result.TotalRecords} Patients)";

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;
        }

        private void mainDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var patient = mainDgv.Rows[e.RowIndex].DataBoundItem as Patient;
            if (patient == null) return;

            _selectedPatientId = patient.PatientId;
            txtFirstName.Text = patient.FirstName;
            txtLastName.Text = patient.LastName;
            txtPhone.Text = patient.Phone;
            txtEmail.Text = patient.Email;
            txtAddress.Text = patient.Address;
            cmbCounty.Text = patient.County;
            cmbGender.Text = patient.Gender;
            txtPatientNumber.Text = patient.PatientNumber.ToString();
            dtpDoB.Value = patient.Dob;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm())
                    return;

                var patient = new Patient
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    County = cmbCounty.Text,
                    Gender = cmbGender.Text,
                    PatientNumber = int.Parse(txtPatientNumber.Text.ToString()),
                    Dob = DateTime.Parse(dtpDoB.Text)
                };
                _patientRepo.CreatePatient(patient);
                ClearForm();
                LoadPatients();
                lblMessage.Text = $"Patient {patient.FirstName} {patient.LastName} created successfully.";
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
                if (_selectedPatientId == null) return;

                var patient = new Patient
                {
                    PatientId = _selectedPatientId.Value,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    County = cmbCounty.Text,
                    Gender = cmbGender.Text,
                    PatientNumber = int.Parse(txtPatientNumber.Text.ToString()),
                    Dob = DateTime.Parse(dtpDoB.Text)
                };

                _patientRepo.UpdatePatient(patient);
                ClearForm();
                LoadPatients();
                lblMessage.Text = $"Patient {patient.FirstName} {patient.LastName} Updated successfully.";
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
                if (_selectedPatientId == null) return;

                _patientRepo.DeletePatient(_selectedPatientId.Value);

                ClearForm();
                LoadPatients();
                lblMessage.Text = $"Patient {_selectedPatientId} Deleted successfully.";
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
            txtPatientNumber.Clear();
            _selectedPatientId = null;

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

        private bool ValidateForm()
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

            if (String.IsNullOrEmpty(txtPatientNumber.Text))
            {
                lblSalaryError.Text = "Patient Number must be defined";
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

        private void btnGetPatient_Click(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadPatients();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_totalPages > 1)
            {
                _currentPage++;
                LoadPatients();
            }
        }

        private void btnGetPatientAbove25_Click(object sender, EventArgs e)
        {
            var result = _patientRepo.SearchPatientsAbove25Paged(
                _currentPage,
                PageSize);

            mainDgv.DataSource = result.Items;

            _totalPages = result.TotalPages;
            lblPagination.Text = $"Page {_currentPage} of {_totalPages} ({result.TotalRecords} Patients)";

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;
        }
    }
}
