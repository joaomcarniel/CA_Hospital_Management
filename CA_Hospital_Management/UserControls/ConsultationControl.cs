using CA_Hospital_Management.Models;
using CA_Hospital_Management.Repositories;
using HospitalManagement.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CA_Hospital_Management.UserControls
{
    public partial class ConsultationControl : UserControl
    {
        private ConsultationRepository _consultationRepo;
        private HospitalRepository _hospitalRepo;
        private int? _selectedConsultationId = null;
        private int _currentPage = 1;
        private const int PageSize = 10;
        private int _totalPages = 0;

        public ConsultationControl()
        {
            InitializeComponent();
        }

        private void ConsultationsControl_Load(object sender, EventArgs e)
        {
            _consultationRepo = new ConsultationRepository();
            _hospitalRepo = new HospitalRepository();

            LoadConsultation();

            CenterFormPanel();
            mainDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadConsultation()
        {
            var result = _consultationRepo.SearchConsultationPaged(
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

            var consultation = mainDgv.Rows[e.RowIndex].DataBoundItem as ConsultationDto;
            if (consultation == null) return;

            _selectedConsultationId = consultation.ConsultationId;
            txtPatient.Text = $"{consultation.ConsultationPatientId}";
            txtDoctor.Text = $"{consultation.ConsultationDoctorId}";
            txtReason.Text = consultation.ConsultationReason;
            txtDiagnosis.Text = consultation.ConsultationDiagnosis;
            txtNotes.Text = consultation.ConsultationNotes;
            dtpConsultationDate.Value = consultation.ConsultationDate;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm())
                    return;

                var consultation = new Consultation
                {
                    ConsultationPatientId = int.Parse(txtPatient.Text),
                    ConsultationDoctorId = int.Parse(txtDoctor.Text),
                    ConsultationReason = txtReason.Text,
                    ConsultationDiagnosis = txtDiagnosis.Text,
                    ConsultationNotes = txtNotes.Text,
                    ConsultationDate = DateTime.Parse(dtpConsultationDate.Text)
                };
                _consultationRepo.CreateConsultation(consultation);
                ClearForm();
                LoadConsultation();
                lblMessage.Text = $"Consultation created successfully.";
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

                var consultation = new Consultation
                {
                    ConsultationId = _selectedConsultationId.Value,
                    ConsultationPatientId = int.Parse(txtPatient.Text),
                    ConsultationDoctorId = int.Parse(txtDoctor.Text),
                    ConsultationReason = txtReason.Text,
                    ConsultationDiagnosis = txtDiagnosis.Text,
                    ConsultationNotes = txtNotes.Text,
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
            txtDoctor.Clear();
            txtReason.Clear();
            txtDiagnosis.Clear();
            txtNotes.Clear();
            _selectedConsultationId = null;

            lblPatient.Text = "";
            lblLDoctor.Text = "";
            lblReasonError.Text = "";
            lblPatient.Text = "";
            lblLDoctor.Text = "";
            lblReasonError.Text = "";
            lblDiagnosisError.Text = "";
            lblNotesError.Text = "";
            lblDiagnosisError.Text = "";
            lblNotesError.Text = "";
            lblMessage.Text = "";
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            HideErrors();

            if (string.IsNullOrWhiteSpace(txtPatient.Text))
            {
                lblPatient.Text = "Patient is required";
                lblPatient.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtDoctor.Text))
            {
                lblLDoctor.Text = "Doctor is required";
                lblLDoctor.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                lblReasonError.Text = "Reason is required";
                lblReasonError.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtDiagnosis.Text))
            {
                lblDiagnosisError.Text = "Diagnosis is required";
                lblDiagnosisError.Visible = true;
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
            lblPatient.Visible = false;
            lblLDoctor.Visible = false;
            lblReasonError.Visible = false;
            lblDiagnosisError.Visible = false;
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
