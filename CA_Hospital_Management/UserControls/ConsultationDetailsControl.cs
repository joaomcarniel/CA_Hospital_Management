using CA_Hospital_Management.Models.DTOs;
using CA_Hospital_Management.Models.Entities;
using CA_Hospital_Management.Repositories;
using CA_Hospital_Management.Services;

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

            UpdateDataGrid(result);
        }

        private void UpdateDataGrid(ListPaginated<ConsultationDetailsDto> result)
        {
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

                var consultation = BuildDetails(false);
                _consultationRepo.CreateConsultationDetails(consultation);
                ClearForm();
                LoadConsultation();
                FrontMessager.BuildSuccessMessage(lblMessage, "Details", "Created");
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
                if (_selectedConsultationId == null) return;

                var consultation = BuildDetails();

                _consultationRepo.UpdateConsultation(consultation);
                ClearForm();
                LoadConsultation();
                FrontMessager.BuildSuccessMessage(lblMessage, "Details", "Updated");

            }
            catch (Exception ex)
            {
                FrontMessager.BuildExceptionMessage(lblMessage, ex.Message);
            }
        }

        private ConsultationDetails BuildDetails(bool useId = true)
        {
            return new ConsultationDetails
            {
                ConsultDetailsId = useId ? _selectedConsultationId.Value : 0,
                PatientId = int.Parse(txtPatientId.Text),
                ConsultationId = int.Parse(txtConsultationId.Text),
                NurseId = int.Parse(txtNurseId.Text),
                Reason = txtReason.Text,
                Notes = txtNotes.Text,
                ConsultationDate = DateTime.Parse(dtpConsultationDate.Text)
            };
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedConsultationId == null) return;

                _consultationRepo.DeleteConsultation(_selectedConsultationId.Value);

                ClearForm();
                LoadConsultation();
                FrontMessager.BuildSuccessMessage(lblMessage, "Details", "Deleted");
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
            txtPatientId.Clear();
            txtConsultationId.Clear();
            txtNurseId.Clear();
            txtReason.Clear();
            txtDiagnosis.Clear();
            txtNotes.Clear();
            _selectedConsultationId = null;
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