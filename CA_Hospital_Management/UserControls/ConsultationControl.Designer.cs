namespace CA_Hospital_Management.UserControls
{
    partial class ConsultationControl
    {
        private System.ComponentModel.IContainer components = null;

        private SplitContainer splitCont;

        private TextBox txtPatient;
        private TextBox txtDoctor;
        private TextBox txtReason;
        private TextBox txtDiagnosis;
        private TextBox txtNotes;
        private DateTimePicker dtpConsultationDate;

        private DataGridView mainDgv;

        private Button btnCreate;
        private Button btnUpdate;
        private Button btnClear;

        private Label lblMessage;
        private Label lblError;

        private Label lblPatientId;
        private Label lblLastName;
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
            txtDiagnosis = new TextBox();
            label4 = new Label();
            txtNotes = new TextBox();
            label3 = new Label();
            txtReason = new TextBox();
            label5 = new Label();
            label2 = new Label();
            lblPagination = new Label();
            btnNext = new Button();
            btnPrev = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            btnGetConsultation = new Button();
            lblPatientId = new Label();
            btnCreate = new Button();
            txtPatient = new TextBox();
            lblMessage = new Label();
            lblLastName = new Label();
            txtDoctor = new TextBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dtpConsultationDate = new DateTimePicker();
            lblDob = new Label();
            lblError = new Label();
            mainDgv = new DataGridView();
            btnConsultationsToday = new Button();
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
            panelForm.Controls.Add(btnConsultationsToday);
            panelForm.Controls.Add(txtDiagnosis);
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(txtNotes);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(txtReason);
            panelForm.Controls.Add(label5);
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(lblPagination);
            panelForm.Controls.Add(btnNext);
            panelForm.Controls.Add(btnPrev);
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(txtSearch);
            panelForm.Controls.Add(btnGetConsultation);
            panelForm.Controls.Add(lblPatientId);
            panelForm.Controls.Add(btnCreate);
            panelForm.Controls.Add(txtPatient);
            panelForm.Controls.Add(lblMessage);
            panelForm.Controls.Add(lblLastName);
            panelForm.Controls.Add(txtDoctor);
            panelForm.Controls.Add(btnClear);
            panelForm.Controls.Add(btnDelete);
            panelForm.Controls.Add(btnUpdate);
            panelForm.Controls.Add(dtpConsultationDate);
            panelForm.Controls.Add(lblDob);
            panelForm.Controls.Add(lblError);
            panelForm.Font = new Font("Segoe UI", 9F);
            panelForm.Location = new Point(17, 3);
            panelForm.Name = "panelForm";
            panelForm.RightToLeft = RightToLeft.Yes;
            panelForm.Size = new Size(1524, 589);
            panelForm.TabIndex = 32;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.AcceptsReturn = true;
            txtDiagnosis.AcceptsTab = true;
            txtDiagnosis.Anchor = AnchorStyles.None;
            txtDiagnosis.BackColor = Color.FromArgb(255, 224, 192);
            txtDiagnosis.Location = new Point(287, 249);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.ScrollBars = ScrollBars.Vertical;
            txtDiagnosis.Size = new Size(508, 155);
            txtDiagnosis.TabIndex = 5;
            txtDiagnosis.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(181, 249);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(100, 23);
            label4.TabIndex = 52;
            label4.Text = "Diagnosis";
            // 
            // txtNotes
            // 
            txtNotes.AcceptsReturn = true;
            txtNotes.AcceptsTab = true;
            txtNotes.Anchor = AnchorStyles.None;
            txtNotes.BackColor = Color.FromArgb(255, 224, 192);
            txtNotes.Location = new Point(901, 249);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(508, 155);
            txtNotes.TabIndex = 6;
            txtNotes.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(799, 249);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(100, 23);
            label3.TabIndex = 49;
            label3.Text = "Notes";
            // 
            // txtReason
            // 
            txtReason.AcceptsReturn = true;
            txtReason.AcceptsTab = true;
            txtReason.Anchor = AnchorStyles.None;
            txtReason.BackColor = Color.FromArgb(255, 224, 192);
            txtReason.Location = new Point(901, 77);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.ScrollBars = ScrollBars.Vertical;
            txtReason.Size = new Size(508, 155);
            txtReason.TabIndex = 4;
            txtReason.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(828, 81);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(69, 23);
            label5.TabIndex = 51;
            label5.Text = "Reason";
            // 
            // label2
            // 
            label2.BackColor = Color.SteelBlue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(157, 8);
            label2.Name = "label2";
            label2.Size = new Size(1252, 57);
            label2.TabIndex = 38;
            label2.Text = "Consultations";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPagination
            // 
            lblPagination.ForeColor = Color.Black;
            lblPagination.Location = new Point(651, 552);
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
            btnNext.Location = new Point(913, 543);
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
            btnPrev.Location = new Point(553, 543);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(92, 40);
            btnPrev.TabIndex = 35;
            btnPrev.Text = "Privious";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // label1
            // 
            label1.Location = new Point(475, 483);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 34;
            label1.Text = "Search By Patient";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(255, 224, 192);
            txtSearch.Location = new Point(601, 480);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(327, 27);
            txtSearch.TabIndex = 33;
            // 
            // btnGetConsultation
            // 
            btnGetConsultation.BackColor = SystemColors.MenuHighlight;
            btnGetConsultation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetConsultation.ForeColor = Color.White;
            btnGetConsultation.Location = new Point(936, 472);
            btnGetConsultation.Name = "btnGetConsultation";
            btnGetConsultation.Size = new Size(171, 42);
            btnGetConsultation.TabIndex = 32;
            btnGetConsultation.Text = "Search Consultation";
            btnGetConsultation.UseVisualStyleBackColor = false;
            btnGetConsultation.Click += btnGetConsultation_Click;
            // 
            // lblPatientId
            // 
            lblPatientId.Font = new Font("Segoe UI", 9F);
            lblPatientId.Location = new Point(181, 81);
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
            btnCreate.Location = new Point(472, 420);
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
            txtPatient.Location = new Point(287, 79);
            txtPatient.Name = "txtPatient";
            txtPatient.Size = new Size(327, 27);
            txtPatient.TabIndex = 1;
            txtPatient.KeyPress += txtFirstName_KeyPress;
            // 
            // lblMessage
            // 
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(488, 516);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(581, 23);
            lblMessage.TabIndex = 31;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.Visible = false;
            // 
            // lblLastName
            // 
            lblLastName.Location = new Point(181, 123);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(100, 23);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "DoctorId";
            // 
            // txtDoctor
            // 
            txtDoctor.BackColor = Color.FromArgb(255, 224, 192);
            txtDoctor.Location = new Point(287, 121);
            txtDoctor.Name = "txtDoctor";
            txtDoctor.Size = new Size(327, 27);
            txtDoctor.TabIndex = 2;
            txtDoctor.KeyPress += txtLastName_KeyPress;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.MenuHighlight;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(826, 420);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 42);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(708, 420);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 40);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Lime;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(590, 420);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 40);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dtpConsultationDate
            // 
            dtpConsultationDate.CalendarMonthBackground = Color.FromArgb(255, 224, 192);
            dtpConsultationDate.Location = new Point(287, 167);
            dtpConsultationDate.Name = "dtpConsultationDate";
            dtpConsultationDate.Size = new Size(327, 27);
            dtpConsultationDate.TabIndex = 3;
            // 
            // lblDob
            // 
            lblDob.Location = new Point(143, 171);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(138, 23);
            lblDob.TabIndex = 24;
            lblDob.Text = "Consultation Date";
            // 
            // lblError
            // 
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(157, 430);
            lblError.Name = "lblError";
            lblError.Size = new Size(387, 23);
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
            // btnConsultationsToday
            // 
            btnConsultationsToday.BackColor = SystemColors.MenuHighlight;
            btnConsultationsToday.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultationsToday.ForeColor = Color.White;
            btnConsultationsToday.Location = new Point(944, 420);
            btnConsultationsToday.Name = "btnConsultationsToday";
            btnConsultationsToday.Size = new Size(162, 42);
            btnConsultationsToday.TabIndex = 53;
            btnConsultationsToday.Text = "Consultations Today";
            btnConsultationsToday.UseVisualStyleBackColor = false;
            btnConsultationsToday.Click += btnConsultationsToday_Click;
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
        private Button btnDelete;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private Label label5;
        private Button btnConsultationsToday;
    }
}
