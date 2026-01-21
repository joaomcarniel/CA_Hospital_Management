using CA_Hospital_Management.Models.DTOs;
using CA_Hospital_Management.Models.Entities;
using CA_Hospital_Management.Repositories;
using CA_Hospital_Management.Services;

namespace CA_Hospital_Management.UserControls
{
    public partial class PatientsControl : UserControl
    {
        private PatientRepository _patientRepo;
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

            UpdateDataGrid(result);
        }

        private void UpdateDataGrid(ListPaginated<Patient> result)
        {
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
            lblError.Text = "";
            lblError.Text = "";
            lblMessage.Text = "";
        }

        private bool ValidateForm()
        {
            Dictionary<string, String> fields = new Dictionary<string, String>();
            string countyValidator = cmbCounty.SelectedIndex == -1 ? "" : "County";
            string genderValidator = cmbGender.SelectedIndex == -1 ? "" : "Gender";

            fields.Add("First Name", txtFirstName.Text);
            fields.Add("Last Name", txtLastName.Text);
            fields.Add("Patient Number", txtPatientNumber.Text);
            fields.Add("Phone", txtPhone.Text);
            fields.Add("Email", txtEmail.Text);
            fields.Add("Address", txtAddress.Text);
            fields.Add("County", countyValidator);
            fields.Add("Gender", genderValidator);
            return FormsValidator.ValidateForm(fields, lblError);
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
            UpdateDataGrid(result);
        }
    }
}
