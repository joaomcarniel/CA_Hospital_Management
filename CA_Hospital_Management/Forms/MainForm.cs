using CA_Hospital_Management.Models;
using CA_Hospital_Management.Services;
using HospitalManagement.Repositories;
using System.Diagnostics.Metrics;
using System.Net;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CA_Hospital_Management.Forms
{
    public partial class MainForm : Form
    {
        private readonly Login _loggedUser;
        private readonly DoctorRepository _doctorRepo;
        private readonly HospitalRepository _hospitalRepo;
        private int? _selectedDoctorId = null;

        public MainForm(Login user)
        {
            InitializeComponent();
            _loggedUser = user;

            HideTabHeaders();
            ConfigureAccess();
            _doctorRepo = new DoctorRepository();
            _hospitalRepo = new HospitalRepository();
        }

        private void HideTabHeaders()
        {
            tabControlMain.Appearance = TabAppearance.FlatButtons;
            tabControlMain.ItemSize = new Size(0, 1);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
        }

        private void ConfigureAccess()
        {
            if (_loggedUser.LoginRole != "Admin")
            {
                tabAdmin.Visible = false;
            }
        }

        private void LoadDoctors()
        {
            dgvDoctors.DataSource = _hospitalRepo.GetAllDoctors();

            foreach (DataGridViewColumn col in dgvDoctors.Columns)
            {
                Console.WriteLine(col.Name);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDoctors();
            LoadCountyCombo();
            LoadGenderCombo();
        }

        private void LoadCountyCombo()
        {
            cmbCounty.Items.Clear();

            string[] counties =
            {
                "Carlow",
                "Cavan",
                "Clare",
                "Cork",
                "Donegal",
                "Dublin",
                "Galway",
                "Kerry",
                "Kildare",
                "Kilkenny",
                "Laois",
                "Leitrim",
                "Limerick",
                "Longford",
                "Louth",
                "Mayo",
                "Meath",
                "Monaghan",
                "Offaly",
                "Roscommon",
                "Sligo",
                "Tipperary",
                "Waterford",
                "Westmeath",
                "Wexford",
                "Wicklow"
            };

            cmbCounty.Items.AddRange(counties);
            cmbCounty.SelectedIndex = -1; // nenhum selecionado
        }

        private void LoadGenderCombo()
        {
            cmbGender.Items.Clear();

            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");
            cmbGender.Items.Add("Prefer not to say");

            cmbGender.SelectedIndex = -1;
        }



        private void menuDoctors_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabDoctors;
        }

        private void tabControlMain_Click(object sender, EventArgs e)
        {

        }

        private void menuNurses_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabNurses;
        }

        private void txtIdUpdateDoctor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListDoctors_Click(object sender, EventArgs e)
        {
            dgvDoctors.DataSource = _hospitalRepo.GetAllDoctors();
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
                lblDocMessage.Text = $"Doctor {txtFirstName.Text} {txtLastName.Text} created successfully.";
                lblDocMessage.ForeColor = Color.Green;
                lblDocMessage.Visible = true;
                ClearForm();
                LoadDoctors();
            }
            catch (Exception ex)
            {
                lblDocMessage.Text = $"Error: {ex.Message}";
                lblDocMessage.ForeColor = Color.Red;
                lblDocMessage.Visible = true;
            }
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
                lblDocMessage.Text = $"Doctor {txtFirstName.Text} {txtLastName.Text} Updated successfully.";
                lblDocMessage.ForeColor = Color.Green;
                lblDocMessage.Visible = true;
                ClearForm();
                LoadDoctors();
            }
            catch (Exception ex)
            {
                lblDocMessage.Text = $"Error: {ex.Message}";
                lblDocMessage.ForeColor = Color.Red;
                lblDocMessage.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedDoctorId == null) return;

                _doctorRepo.DeleteDoctor(_selectedDoctorId.Value);

                lblDocMessage.Text = $"Doctor {_selectedDoctorId} Deleted successfully.";
                lblDocMessage.ForeColor = Color.Green;
                lblDocMessage.Visible = true;
                ClearForm();
                LoadDoctors();
            }
            catch (Exception ex)
            {
                lblDocMessage.Text = $"Error: {ex.Message}";
                lblDocMessage.ForeColor = Color.Red;
                lblDocMessage.Visible = true;
            }

        }

        private bool ValidateDoctorForm()
        {
            bool isValid = true;

            // Reset errors
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

        private void dgvDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvDoctors.Rows[e.RowIndex];

            _selectedDoctorId = Convert.ToInt32(row.Cells["DoctorId"].Value);
            txtFirstName.Text = row.Cells["FirstName"].Value?.ToString();
            txtLastName.Text = row.Cells["LastName"].Value?.ToString();
            txtPhone.Text = row.Cells["Phone"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            txtAddress.Text = row.Cells["Address"].Value?.ToString();
            cmbCounty.Text = row.Cells["County"].Value?.ToString();
            cmbGender.Text = row.Cells["Gender"].Value?.ToString();
            numSalary.Value = Convert.ToDecimal(row.Cells["Pay"].Value);
            dtpDoB.Value = Convert.ToDateTime(row.Cells["Dob"].Value);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
