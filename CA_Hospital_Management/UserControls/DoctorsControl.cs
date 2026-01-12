using CA_Hospital_Management.Models;
using CA_Hospital_Management.Repositories;
using HospitalManagement.Repositories;

namespace CA_Hospital_Management.UserControls
{
    public partial class DoctorsControl : UserControl
    {
        private DoctorRepository _doctorRepo;
        private HospitalRepository _hospitalRepo;
        private int? _selectedDoctorId = null;

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
        }

        private void LoadDoctors()
        {
            dgvDoctors.DataSource = _hospitalRepo.GetAllDoctors();
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
            numSalary.Value = doctor.Pay;
            dtpDoB.Value = doctor.Dob;
        }

        private void btnCreateDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateDoctorForm())
                    return;

                _doctorRepo.CreateDoctor(new Doctor
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    County = cmbCounty.Text,
                    Gender = cmbGender.Text,
                    Pay = numSalary.Value,
                    Dob = DateTime.Parse(dtpDoB.Text)
                });
                ClearForm();
                LoadDoctors();
                lblDocMessage.Text = $"Doctor {txtFirstName.Text} {txtLastName.Text} created successfully.";
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

                _doctorRepo.UpdateDoctor(new Doctor
                {
                    DoctorId = (int)_selectedDoctorId,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    County = cmbCounty.Text,
                    Gender = cmbGender.Text,
                    Pay = numSalary.Value,
                    Dob = DateTime.Parse(dtpDoB.Text)
                });
                ClearForm();
                LoadDoctors();
                lblDocMessage.Text = $"Doctor {txtFirstName.Text} {txtLastName.Text} Updated successfully.";
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
            cmbCounty.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            numSalary.Value = 0;
            _selectedDoctorId = null;
                
            lblDocFNameError.Text = "";
            lblDocLNameError.Text = "";
            lblDocPhoneError.Text = "";
            lblDocEmailError.Text = "";
            lblDocFNameError.Text = "";
            lblDocLNameError.Text = "";
            lblDocPhoneError.Text = "";
            lblDocEmailError.Text = "";
            lblDocAddrError.Text = "";
            lblDocCountyError.Text = "";
            lblDocGenderError.Text = "";
            lblDocSalaryError.Text = "";
            lblDocAddrError.Text = "";
            lblDocCountyError.Text = "";
            lblDocGenderError.Text = "";
            lblDocSalaryError.Text = "";
            lblDocMessage.Text = "";
        }

        private bool ValidateDoctorForm()
        {
            bool isValid = true;

            HideDoctorErrors();

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                lblDocFNameError.Text = "First name is required";
                lblDocFNameError.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                lblDocLNameError.Text = "Last name is required";
                lblDocLNameError.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                lblDocPhoneError.Text = "Phone is required";
                lblDocPhoneError.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblDocEmailError.Text = "Email is required";
                lblDocEmailError.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                lblDocAddrError.Text = "Address is required";
                lblDocAddrError.Visible = true;
                isValid = false;
            }

            if (cmbCounty.SelectedIndex == -1)
            {
                lblDocCountyError.Text = "County is required";
                lblDocCountyError.Visible = true;
                isValid = false;
            }

            if (cmbGender.SelectedIndex == -1)
            {
                lblDocGenderError.Text = "Gender is required";
                lblDocGenderError.Visible = true;
                isValid = false;
            }

            if (numSalary.Value <= 0)
            {
                lblDocSalaryError.Text = "Salary must be greater than zero";
                lblDocSalaryError.Visible = true;
                isValid = false;
            }

            return isValid;
        }

        private void HideDoctorErrors()
        {
            lblDocFNameError.Visible = false;
            lblDocLNameError.Visible = false;
            lblDocPhoneError.Visible = false;
            lblDocEmailError.Visible = false;
            lblDocAddrError.Visible = false;
            lblDocCountyError.Visible = false;
            lblDocGenderError.Visible = false;
            lblDocSalaryError.Visible = false;
            lblDocMessage.Visible = false;
        }

        private void btnListDoctors_Click(object sender, EventArgs e)
        {
            dgvDoctors.DataSource = _hospitalRepo.GetAllDoctors();
        }

        private void splitDoctors_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDocMessage_Click(object sender, EventArgs e)
        {

        }

        private void lblDocSalaryError_Click(object sender, EventArgs e)
        {

        }
    }
}
