using CA_Hospital_Management.Models;
using CA_Hospital_Management.Models.DTOs;
using CA_Hospital_Management.Models.Entities;
using CA_Hospital_Management.Repositories;
using CA_Hospital_Management.Services;
using Microsoft.Data.SqlClient;

namespace CA_Hospital_Management.UserControls
{
    public partial class ConsultationDetailsControl : UserControl
    {
        private ConsultationDetailsRepository _consultationRepo;
        private int? _selectedConsultationId = null;
        private int _currentPage = 1;
        private const int PageSize = 10;
        private int _totalPages = 0;

        public ConsultationDetailsControl()
        {
            InitializeComponent();
        }

        private void ConsultationsControl_Load(object sender, EventArgs e)
        {
            _consultationRepo = new ConsultationDetailsRepository();

            LoadConsultation();

            CenterFormPanel();
            mainDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadConsultation()
        {
            var result = _consultationRepo.SearchConsultationDetailsPaged(
                txtSearch.Text.Trim(),
                _currentPage,
                PageSize);

            mainDgv.DataSource = result.Items;

            _totalPages = result.TotalPages;
            lblPagination.Text = $"Page {_currentPage} of {_totalPages} ({result.TotalRecords} Consultation Details)";

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;
        }

        private void mainDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var consultation = mainDgv.Rows[e.RowIndex].DataBoundItem as ConsultationDetailsDto;
            if (consultation == null) return;

            _selectedConsultationId = consultation.ConsultDetailsId;
            txtPatientId.Text = $"{consultation.PatientId}";
            txtNurseId.Text = $"{consultation.NurseId}";
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
                    PatientId = int.Parse(txtPatientId.Text),
                    NurseId = int.Parse(txtNurseId.Text),
                    ConsultationId = int.Parse(txtConsultationId.Text),
                    Reason = txtReason.Text,
                    Notes = txtNotes.Text,
                    ConsultationDate = dtpConsultationDate.Value
                };
                _consultationRepo.CreateConsultationDetails(consultation);
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
                    PatientId = int.Parse(txtPatientId.Text),
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
            txtPatientId.Clear();
            txtConsultationId.Clear();
            txtNurseId.Clear();
            txtReason.Clear();
            txtNotes.Clear();
            _selectedConsultationId = null;

            lblNurseIdError.Text = "";
            lblConsultationError.Text = "";
            lblReasonError.Text = "";
            lblNurseIdError.Text = "";
            lblConsultationError.Text = "";
            lblReasonError.Text = "";
            lblError.Text = "";
            lblError.Text = "";
            lblMessage.Text = "";
        }

        private bool ValidateForm()
        {
            Dictionary<string, String> fields = new Dictionary<string, String>();

            fields.Add("Patient Id", txtPatientId.Text);
            fields.Add("Nurse Id", txtNurseId.Text);
            fields.Add("Consultation Id", txtConsultationId.Text);
            fields.Add("Reason", txtReason.Text);
            fields.Add("Notes", txtNotes.Text);
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
