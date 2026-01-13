using CA_Hospital_Management.Models;
using CA_Hospital_Management.Repositories;
using HospitalManagement.Repositories;

namespace CA_Hospital_Management.UserControls
{
    public partial class ConsultationNursesControl : UserControl
    {
        private ConsultationNurseRepository _consultationRepo;
        private HospitalRepository _hospitalRepo;
        private int? _selectedConsultationId = null;
        private int _currentPage = 1;
        private const int PageSize = 10;
        private int _totalPages = 0;

        public ConsultationNursesControl()
        {
            InitializeComponent();
        }

        private void ConsultationsControl_Load(object sender, EventArgs e)
        {
            _consultationRepo = new ConsultationNurseRepository();
            _hospitalRepo = new HospitalRepository();

            LoadConsultation();

            CenterFormPanel();
            mainDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadConsultation()
        {
            var result = _consultationRepo.SearchConsultationNursePaged(
                txtSearch.Text.Trim(),
                _currentPage,
                PageSize);

            mainDgv.DataSource = result.Items;

            _totalPages = result.TotalPages;
            lblPagination.Text = $"Page {_currentPage} of {_totalPages} ({result.TotalRecords} Consultations)";

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;
        }

        private void mainDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var consultation = mainDgv.Rows[e.RowIndex].DataBoundItem as ConsultationDetails;
            if (consultation == null) return;

            _selectedConsultationId = consultation.ConsultationId;
            txtPatient.Text = $"{consultation.PatientId}";
            txtNurseId.Text = $"{consultation.PatientId}";
            txtConsultationId.Text = $"{consultation.ConsultationId}";
            txtReason.Text = consultation.Reason;
            txtNotes.Text = consultation.Notes;
            dtpConsultationDate.Value = consultation.ConsultationDate;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm())
                    return;

                var consultation = new ConsultationDetails
                {
                    PatientId = int.Parse(txtPatient.Text),
                    ConsultDetailsId = int.Parse(txtNurseId.Text),
                    ConsultationId = int.Parse(txtConsultationId.Text),
                    Notes = txtNotes.Text,
                    Reason = txtReason.Text,
                    ConsultationDate = DateTime.Parse(dtpConsultationDate.Text)
                };
                _consultationRepo.CreateConsultation(consultation);
                ClearForm();
                LoadConsultation();
                lblMessage.Text = $"Consultation details created successfully.";
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
                if (_selectedConsultationId == null) return;

                var consultation = new ConsultationDetails
                {
                    ConsultDetailsId = _selectedConsultationId.Value,
                    PatientId = int.Parse(txtPatient.Text),
                    ConsultationId = int.Parse(txtConsultationId.Text),
                    NurseId = int.Parse(txtNurseId.Text),
                    Reason = txtReason.Text,
                    Notes = txtNotes.Text,
                    ConsultationDate = DateTime.Parse(dtpConsultationDate.Text)
                };

                _consultationRepo.UpdateConsultation(consultation);
                ClearForm();
                LoadConsultation();
                lblMessage.Text = $"Consultation Updated successfully.";
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
                if (_selectedConsultationId == null) return;

                _consultationRepo.DeleteConsultation(_selectedConsultationId.Value);

                ClearForm();
                LoadConsultation();
                lblMessage.Text = $"Consultation {_selectedConsultationId} Deleted successfully.";
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
            txtPatient.Clear();
            txtConsultationId.Clear();
            txtReason.Clear();
            txtNotes.Clear();
            _selectedConsultationId = null;

            lblNurseIdError.Text = "";
            lblConsultationError.Text = "";
            lblReasonError.Text = "";
            lblNurseIdError.Text = "";
            lblConsultationError.Text = "";
            lblReasonError.Text = "";
            lblNotesError.Text = "";
            lblNotesError.Text = "";
            lblMessage.Text = "";
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            HideErrors();

            if (string.IsNullOrWhiteSpace(txtPatient.Text))
            {
                lblPatientIdError.Text = "Patient is required";
                lblPatientIdError.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtNurseId.Text))
            {
                lblNurseIdError.Text = "Nurse is required";
                lblNurseIdError.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtConsultationId.Text))
            {
                lblConsultationError.Text = "Consultation is required";
                lblConsultationError.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                lblReasonError.Text = "Reason is required";
                lblReasonError.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtNotes.Text))
            {
                lblNotesError.Text = "Notes is required";
                lblNotesError.Visible = true;
                isValid = false;
            }

            return isValid;
        }

        private void HideErrors()
        {
            lblNurseIdError.Visible = false;
            lblConsultationError.Visible = false;
            lblReasonError.Visible = false;
            lblNotesError.Visible = false;
            lblMessage.Visible = false;
        }

        private void CenterFormPanel()
        {
            if (panelForm == null) return;

            panelForm.Left = (splitCont.Panel1.Width - panelForm.Width) / 2;
            panelForm.Top = (splitCont.Panel1.Height - panelForm.Height) / 2;
        }

        private void splitCont_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void lblSalaryError_Click(object sender, EventArgs e)
        {

        }

        private void splitCont_Panel1_Resize(object sender, EventArgs e)
        {
            CenterFormPanel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGetConsultation_Click(object sender, EventArgs e)
        {
            LoadConsultation();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadConsultation();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_totalPages > 1)
            {
                _currentPage++;
                LoadConsultation();
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
