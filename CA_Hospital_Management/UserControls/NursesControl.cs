using CA_Hospital_Management.Models.DTOs;
using CA_Hospital_Management.Models.Entities;
using CA_Hospital_Management.Repositories;
using CA_Hospital_Management.Services;

namespace CA_Hospital_Management.UserControls
{
    public partial class NursesControl : UserControl
    {
        private NurseRepository _nurseRepo;
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

            LoadNurses();
            ComboLoader.LoadCountyCombo(cmbCounty);
            ComboLoader.LoadGenderCombo(cmbGender);
            ComboLoader.LoadContractCombo(cmbContract);

            CenterFormPanel();
            mainDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadNurses()
        {
            var result = _nurseRepo.SearchNursesPaged(
                txtSearch.Text.Trim(),
                _currentPage,
                PageSize);

            UpdateDataGrid(result);
        }

        private void UpdateDataGrid(ListPaginated<Nurse> result)
        {
            mainDgv.DataSource = result.Items;

            _totalPages = result.TotalPages;
            lblPagination.Text = $"Page {_currentPage} of {_totalPages} ({result.TotalRecords} nurses)";

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;
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
            cmbContract.Text = nurse.ContractType;
            txtDepartment.Text = nurse.Department;
            hoursWorked.Value = nurse.HoursWorked;
            dtpDoB.Value = nurse.Dob;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm())
                    return;

                var nurse = BuildNurse(false);
                _nurseRepo.CreateNurse(nurse);
                ClearForm();
                LoadNurses();
                FrontMessager.BuildSuccessMessage(lblMessage, "Nurse", "Created");
            }
            catch (Exception ex)
            {
                FrontMessager.BuildExceptionMessage(lblMessage, ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedNurseId == null) return;

                var nurse = BuildNurse();
                _nurseRepo.UpdateNurse(nurse);
                ClearForm();
                LoadNurses();
                FrontMessager.BuildSuccessMessage(lblMessage, "Nurse", "Updated");

            }
            catch (Exception ex)
            {
                FrontMessager.BuildExceptionMessage(lblMessage, ex.Message);
            }
        }

        private Nurse BuildNurse(bool useId = true)
        {
            return new Nurse
            {
                NurseId = useId == true ? _selectedNurseId.Value : 0,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Department = txtDepartment.Text,
                ContractType = cmbContract.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text,
                County = cmbCounty.Text,
                Gender = cmbGender.Text,
                HoursWorked = int.Parse(hoursWorked.Value.ToString()),
                Dob = DateTime.Parse(dtpDoB.Text)
            };
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedNurseId == null) return;

                _nurseRepo.DeleteNurse(_selectedNurseId.Value);

                ClearForm();
                LoadNurses();
                FrontMessager.BuildSuccessMessage(lblMessage, "Nurse", "Deleted");
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
            hoursWorked.Value = 0;
            _selectedNurseId = null;
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
            string hoursValidator = hoursWorked.Value <= 0 ? "" : "HoursWorked";

            fields.Add("First Name", txtFirstName.Text);
            fields.Add("Last Name", txtLastName.Text);
            fields.Add("Phone", txtPhone.Text);
            fields.Add("Email", txtEmail.Text);
            fields.Add("Department", txtDepartment.Text);
            fields.Add("Address", txtAddress.Text);
            fields.Add("County", countyValidator);
            fields.Add("Contract", contractValidator);
            fields.Add("Gender", genderValidator);
            fields.Add("Hours Worked", hoursValidator);
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
            try
            {
                var result = _nurseRepo.SearchMaleNursesPaged(
                txtSearch.Text.Trim(),
                _currentPage,
                PageSize);

                UpdateDataGrid(result);
            }
            catch(Exception ex)
            {
                FrontMessager.BuildExceptionMessage(lblMessage, ex.Message);
            }
        }
    }
}