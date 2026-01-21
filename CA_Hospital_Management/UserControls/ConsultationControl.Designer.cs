namespace CA_Hospital_Management.UserControls
{
    partial class ConsultationControl
    {
        private System.ComponentModel.IContainer components = null;

        private SplitContainer splitCont;

        private TextBox txtPatient;
        private TextBox txtDoctor;
        private TextBox txtReason;
        private DateTimePicker dtpConsultationDate;

        private DataGridView mainDgv;

        private Button btnCreate;
        private Button btnUpdate;
        private Button btnClear;

        private Label lblMessage;
        private Label lblPatient;
        private Label lblLDoctor;
        private Label lblReasonError;
        private Label lblDiagnosisError;
        private Label lblError;

        private Label lblPatientId;
        private Label lblLastName;
        private Label lblPhone;
        private Label lblAddress;
        private Label lblHoursWorked;
        private Label lblDob;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            splitCont = new SplitContainer();
            panelForm = new Panel();
            txtNotes = new TextBox();
            txtDiagnosis = new TextBox();
            label2 = new Label();
            lblPagination = new Label();
            btnNext = new Button();
            btnPrev = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            btnGetConsultation = new Button();
            lblPatient = new Label();
            lblPatientId = new Label();
            btnCreate = new Button();
            txtPatient = new TextBox();
            lblMessage = new Label();
            lblLastName = new Label();
            txtDoctor = new TextBox();
            btnClear = new Button();
            lblLDoctor = new Label();
            btnDelete = new Button();
            lblPhone = new Label();
            btnUpdate = new Button();
            txtReason = new TextBox();
            dtpConsultationDate = new DateTimePicker();
            lblReasonError = new Label();
            lblDob = new Label();
            lblHoursWorked = new Label();
            lblAddress = new Label();
            lblDiagnosisError = new Label();
            lblError = new Label();
            mainDgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitCont).BeginInit();
            splitCont.Panel1.SuspendLayout();
            splitCont.Panel2.SuspendLayout();
            splitCont.SuspendLayout();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainDgv).BeginInit();
            SuspendLayout();
            // 
            // splitCont
            // 
            splitCont.Dock = DockStyle.Fill;
            splitCont.Location = new Point(0, 0);
            splitCont.Name = "splitCont";
            splitCont.Orientation = Orientation.Horizontal;
            // 
            // splitCont.Panel1
            // 
            splitCont.Panel1.AutoScroll = true;
            splitCont.Panel1.Controls.Add(panelForm);
            splitCont.Panel1.Resize += splitCont_Panel1_Resize;
            // 
            // splitCont.Panel2
            // 
            splitCont.Panel2.Controls.Add(mainDgv);
            splitCont.Size = new Size(1561, 832);
            splitCont.SplitterDistance = 595;
            splitCont.TabIndex = 0;
            // 
            // panelForm
            // 
            panelForm.Controls.Add(txtNotes);
            panelForm.Controls.Add(txtDiagnosis);
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(lblPagination);
            panelForm.Controls.Add(btnNext);
            panelForm.Controls.Add(btnPrev);
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(txtSearch);
            panelForm.Controls.Add(btnGetConsultation);
            panelForm.Controls.Add(lblPatient);
            panelForm.Controls.Add(lblPatientId);
            panelForm.Controls.Add(btnCreate);
            panelForm.Controls.Add(txtPatient);
            panelForm.Controls.Add(lblMessage);
            panelForm.Controls.Add(lblLastName);
            panelForm.Controls.Add(txtDoctor);
            panelForm.Controls.Add(btnClear);
            panelForm.Controls.Add(lblLDoctor);
            panelForm.Controls.Add(btnDelete);
            panelForm.Controls.Add(lblPhone);
            panelForm.Controls.Add(btnUpdate);
            panelForm.Controls.Add(txtReason);
            panelForm.Controls.Add(dtpConsultationDate);
            panelForm.Controls.Add(lblReasonError);
            panelForm.Controls.Add(lblDob);
            panelForm.Controls.Add(lblHoursWorked);
            panelForm.Controls.Add(lblAddress);
            panelForm.Controls.Add(lblDiagnosisError);
            panelForm.Controls.Add(lblError);
            panelForm.Font = new Font("Segoe UI", 9F);
            panelForm.Location = new Point(17, 3);
            panelForm.Name = "panelForm";
            panelForm.RightToLeft = RightToLeft.Yes;
            panelForm.Size = new Size(1524, 589);
            panelForm.TabIndex = 32;
            // 
            // txtNotes
            // 
            txtNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNotes.BackColor = Color.FromArgb(255, 224, 192);
            txtNotes.Location = new Point(416, 262);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(789, 27);
            txtNotes.TabIndex = 40;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDiagnosis.BackColor = Color.FromArgb(255, 224, 192);
            txtDiagnosis.Location = new Point(416, 209);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.ScrollBars = ScrollBars.Vertical;
            txtDiagnosis.Size = new Size(789, 27);
            txtDiagnosis.TabIndex = 39;
            // 
            // label2
            // 
            label2.BackColor = Color.SteelBlue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(620, 17);
            label2.Name = "label2";
            label2.Size = new Size(285, 57);
            label2.TabIndex = 38;
            label2.Text = "Consultations";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPagination
            // 
            lblPagination.ForeColor = Color.Black;
            lblPagination.Location = new Point(639, 552);
            lblPagination.Name = "lblPagination";
            lblPagination.Size = new Size(256, 23);
            lblPagination.TabIndex = 37;
            lblPagination.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.MenuHighlight;
            btnNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(901, 543);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(92, 40);
            btnNext.TabIndex = 36;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = SystemColors.MenuHighlight;
            btnPrev.FlatAppearance.BorderSize = 4;
            btnPrev.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrev.ForeColor = Color.White;
            btnPrev.Location = new Point(541, 543);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(92, 40);
            btnPrev.TabIndex = 35;
            btnPrev.Text = "Privious";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // label1
            // 
            label1.Location = new Point(463, 457);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 34;
            label1.Text = "Search By Patient";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(255, 224, 192);
            txtSearch.Location = new Point(589, 454);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(327, 27);
            txtSearch.TabIndex = 33;
            // 
            // btnGetConsultation
            // 
            btnGetConsultation.BackColor = SystemColors.MenuHighlight;
            btnGetConsultation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetConsultation.ForeColor = Color.White;
            btnGetConsultation.Location = new Point(924, 446);
            btnGetConsultation.Name = "btnGetConsultation";
            btnGetConsultation.Size = new Size(171, 42);
            btnGetConsultation.TabIndex = 32;
            btnGetConsultation.Text = "Search Consultation";
            btnGetConsultation.UseVisualStyleBackColor = false;
            btnGetConsultation.Click += btnGetConsultation_Click;
            // 
            // lblPatient
            // 
            lblPatient.ForeColor = Color.Red;
            lblPatient.Location = new Point(416, 124);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(327, 23);
            lblPatient.TabIndex = 2;
            lblPatient.Visible = false;
            // 
            // lblPatientId
            // 
            lblPatientId.Font = new Font("Segoe UI", 9F);
            lblPatientId.Location = new Point(310, 97);
            lblPatientId.Name = "lblPatientId";
            lblPatientId.RightToLeft = RightToLeft.Yes;
            lblPatientId.Size = new Size(100, 23);
            lblPatientId.TabIndex = 0;
            lblPatientId.Text = "PatientId";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.MenuHighlight;
            btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(541, 394);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(92, 40);
            btnCreate.TabIndex = 26;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtPatient
            // 
            txtPatient.BackColor = Color.FromArgb(255, 224, 192);
            txtPatient.Location = new Point(416, 95);
            txtPatient.Name = "txtPatient";
            txtPatient.Size = new Size(327, 27);
            txtPatient.TabIndex = 1;
            txtPatient.KeyPress += txtFirstName_KeyPress;
            // 
            // lblMessage
            // 
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(476, 507);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(581, 23);
            lblMessage.TabIndex = 31;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.Visible = false;
            // 
            // lblLastName
            // 
            lblLastName.Location = new Point(778, 97);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(100, 23);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "DoctorId";
            // 
            // txtDoctor
            // 
            txtDoctor.BackColor = Color.FromArgb(255, 224, 192);
            txtDoctor.Location = new Point(878, 95);
            txtDoctor.Name = "txtDoctor";
            txtDoctor.Size = new Size(327, 27);
            txtDoctor.TabIndex = 4;
            txtDoctor.KeyPress += txtLastName_KeyPress;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.MenuHighlight;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(901, 394);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 42);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblLDoctor
            // 
            lblLDoctor.ForeColor = Color.Red;
            lblLDoctor.Location = new Point(878, 124);
            lblLDoctor.Name = "lblLDoctor";
            lblLDoctor.Size = new Size(327, 23);
            lblLDoctor.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(781, 394);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 40);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblPhone
            // 
            lblPhone.Font = new Font("Segoe UI", 9F);
            lblPhone.Location = new Point(310, 265);
            lblPhone.Name = "lblPhone";
            lblPhone.RightToLeft = RightToLeft.Yes;
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Notes";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Lime;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(661, 394);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 40);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtReason
            // 
            txtReason.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtReason.BackColor = Color.FromArgb(255, 224, 192);
            txtReason.Location = new Point(416, 150);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.ScrollBars = ScrollBars.Vertical;
            txtReason.Size = new Size(789, 27);
            txtReason.TabIndex = 7;
            // 
            // dtpConsultationDate
            // 
            dtpConsultationDate.CalendarMonthBackground = Color.FromArgb(255, 224, 192);
            dtpConsultationDate.Location = new Point(416, 318);
            dtpConsultationDate.Name = "dtpConsultationDate";
            dtpConsultationDate.Size = new Size(327, 27);
            dtpConsultationDate.TabIndex = 25;
            // 
            // lblReasonError
            // 
            lblReasonError.ForeColor = Color.Red;
            lblReasonError.Location = new Point(416, 180);
            lblReasonError.Name = "lblReasonError";
            lblReasonError.Size = new Size(789, 23);
            lblReasonError.TabIndex = 8;
            // 
            // lblDob
            // 
            lblDob.Location = new Point(241, 322);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(169, 23);
            lblDob.TabIndex = 24;
            lblDob.Text = "Consultation Date";
            // 
            // lblHoursWorked
            // 
            lblHoursWorked.Font = new Font("Segoe UI", 9F);
            lblHoursWorked.Location = new Point(292, 209);
            lblHoursWorked.Name = "lblHoursWorked";
            lblHoursWorked.RightToLeft = RightToLeft.Yes;
            lblHoursWorked.Size = new Size(118, 23);
            lblHoursWorked.TabIndex = 21;
            lblHoursWorked.Text = "Diagnosis";
            // 
            // lblAddress
            // 
            lblAddress.Font = new Font("Segoe UI", 9F);
            lblAddress.Location = new Point(310, 153);
            lblAddress.Name = "lblAddress";
            lblAddress.RightToLeft = RightToLeft.Yes;
            lblAddress.Size = new Size(100, 23);
            lblAddress.TabIndex = 12;
            lblAddress.Text = "Reason";
            // 
            // lblDiagnosisError
            // 
            lblDiagnosisError.ForeColor = Color.Red;
            lblDiagnosisError.Location = new Point(416, 236);
            lblDiagnosisError.Name = "lblDiagnosisError";
            lblDiagnosisError.Size = new Size(789, 23);
            lblDiagnosisError.TabIndex = 14;
            // 
            // lblError
            // 
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(416, 368);
            lblError.Name = "lblError";
            lblError.Size = new Size(789, 23);
            lblError.TabIndex = 17;
            // 
            // mainDgv
            // 
            mainDgv.ColumnHeadersHeight = 29;
            mainDgv.Dock = DockStyle.Fill;
            mainDgv.Location = new Point(0, 0);
            mainDgv.MultiSelect = false;
            mainDgv.Name = "mainDgv";
            mainDgv.ReadOnly = true;
            mainDgv.RowHeadersWidth = 51;
            mainDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mainDgv.Size = new Size(1561, 233);
            mainDgv.TabIndex = 0;
            mainDgv.CellClick += mainDgv_CellClick;
            // 
            // ConsultationControl
            // 
            Controls.Add(splitCont);
            Name = "ConsultationControl";
            Size = new Size(1561, 832);
            Load += ConsultationsControl_Load;
            splitCont.Panel1.ResumeLayout(false);
            splitCont.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitCont).EndInit();
            splitCont.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForm;
        private Label label1;
        private TextBox txtSearch;
        private Button btnGetConsultation;
        private Label lblPagination;
        private Button btnNext;
        private Button btnPrev;
        private Label label2;
        private TextBox txtNotes;
        private TextBox txtDiagnosis;
        private Button btnDelete;
    }
}
