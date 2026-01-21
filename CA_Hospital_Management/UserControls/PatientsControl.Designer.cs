using CA_Hospital_Management.Services;

namespace CA_Hospital_Management.UserControls
{
    partial class PatientsControl
    {
        private System.ComponentModel.IContainer components = null;

        private SplitContainer splitCont;

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;

        private ComboBox cmbCounty;
        private ComboBox cmbGender;
        private DateTimePicker dtpDoB;

        private DataGridView mainDgv;

        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;

        private Label lblMessage;

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblAddress;
        private Label lblCounty;
        private Label lblGender;
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
            btnGetPatientAbove25 = new Button();
            txtPatientNumber = new TextBox();
            label2 = new Label();
            lblPagination = new Label();
            btnNext = new Button();
            btnPrev = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            btnGetPatient = new Button();
            lblFirstName = new Label();
            btnCreate = new Button();
            txtFirstName = new TextBox();
            lblMessage = new Label();
            lblLastName = new Label();
            txtLastName = new TextBox();
            btnClear = new Button();
            btnDelete = new Button();
            lblPhone = new Label();
            btnUpdate = new Button();
            txtPhone = new TextBox();
            dtpDoB = new DateTimePicker();
            lblDob = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblHoursWorked = new Label();
            lblAddress = new Label();
            txtAddress = new TextBox();
            cmbGender = new ComboBox();
            lblGender = new Label();
            lblCounty = new Label();
            cmbCounty = new ComboBox();
            mainDgv = new DataGridView();
            lblError = new Label();
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
            panelForm.Controls.Add(btnGetPatientAbove25);
            panelForm.Controls.Add(txtPatientNumber);
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(lblPagination);
            panelForm.Controls.Add(btnNext);
            panelForm.Controls.Add(btnPrev);
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(txtSearch);
            panelForm.Controls.Add(btnGetPatient);
            panelForm.Controls.Add(lblFirstName);
            panelForm.Controls.Add(btnCreate);
            panelForm.Controls.Add(txtFirstName);
            panelForm.Controls.Add(lblMessage);
            panelForm.Controls.Add(lblLastName);
            panelForm.Controls.Add(txtLastName);
            panelForm.Controls.Add(btnClear);
            panelForm.Controls.Add(btnDelete);
            panelForm.Controls.Add(lblPhone);
            panelForm.Controls.Add(btnUpdate);
            panelForm.Controls.Add(txtPhone);
            panelForm.Controls.Add(dtpDoB);
            panelForm.Controls.Add(lblDob);
            panelForm.Controls.Add(lblEmail);
            panelForm.Controls.Add(lblError);
            panelForm.Controls.Add(txtEmail);
            panelForm.Controls.Add(lblHoursWorked);
            panelForm.Controls.Add(lblAddress);
            panelForm.Controls.Add(txtAddress);
            panelForm.Controls.Add(cmbGender);
            panelForm.Controls.Add(lblGender);
            panelForm.Controls.Add(lblCounty);
            panelForm.Controls.Add(cmbCounty);
            panelForm.Location = new Point(17, 3);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(1524, 589);
            panelForm.TabIndex = 32;
            // 
            // btnGetPatientAbove25
            // 
            btnGetPatientAbove25.BackColor = SystemColors.MenuHighlight;
            btnGetPatientAbove25.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetPatientAbove25.ForeColor = Color.White;
            btnGetPatientAbove25.Location = new Point(945, 394);
            btnGetPatientAbove25.Name = "btnGetPatientAbove25";
            btnGetPatientAbove25.Size = new Size(154, 42);
            btnGetPatientAbove25.TabIndex = 40;
            btnGetPatientAbove25.Text = "Patients Above 25";
            btnGetPatientAbove25.UseVisualStyleBackColor = false;
            btnGetPatientAbove25.Click += btnGetPatientAbove25_Click;
            // 
            // txtPatientNumber
            // 
            txtPatientNumber.AutoCompleteSource = AutoCompleteSource.HistoryList;
            txtPatientNumber.BackColor = Color.FromArgb(255, 224, 192);
            txtPatientNumber.Location = new Point(416, 318);
            txtPatientNumber.Name = "txtPatientNumber";
            txtPatientNumber.Size = new Size(327, 27);
            txtPatientNumber.TabIndex = 39;
            // 
            // label2
            // 
            label2.BackColor = Color.SteelBlue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(299, 17);
            label2.Name = "label2";
            label2.Size = new Size(906, 57);
            label2.TabIndex = 38;
            label2.Text = "Patients";
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
            label1.Location = new Point(476, 457);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 34;
            label1.Text = "Search By Name";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(255, 224, 192);
            txtSearch.Location = new Point(602, 454);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(327, 27);
            txtSearch.TabIndex = 33;
            // 
            // btnGetPatient
            // 
            btnGetPatient.BackColor = SystemColors.MenuHighlight;
            btnGetPatient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetPatient.ForeColor = Color.White;
            btnGetPatient.Location = new Point(937, 446);
            btnGetPatient.Name = "btnGetPatient";
            btnGetPatient.Size = new Size(123, 42);
            btnGetPatient.TabIndex = 32;
            btnGetPatient.Text = "Search Patient";
            btnGetPatient.UseVisualStyleBackColor = false;
            btnGetPatient.Click += btnGetPatient_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.Location = new Point(312, 97);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(100, 23);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            lblFirstName.TextAlign = ContentAlignment.TopRight;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.MenuHighlight;
            btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(453, 394);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(92, 40);
            btnCreate.TabIndex = 26;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(255, 224, 192);
            txtFirstName.Location = new Point(416, 95);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(327, 27);
            txtFirstName.TabIndex = 1;
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
            lblLastName.Text = "Last Name";
            lblLastName.TextAlign = ContentAlignment.TopRight;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(255, 224, 192);
            txtLastName.Location = new Point(878, 95);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(327, 27);
            txtLastName.TabIndex = 4;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.MenuHighlight;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(822, 394);
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
            btnDelete.Location = new Point(699, 394);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 40);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(312, 153);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone";
            lblPhone.TextAlign = ContentAlignment.TopRight;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Lime;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(576, 394);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 40);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(255, 224, 192);
            txtPhone.Location = new Point(416, 150);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(327, 27);
            txtPhone.TabIndex = 7;
            // 
            // dtpDoB
            // 
            dtpDoB.CalendarMonthBackground = Color.FromArgb(255, 224, 192);
            dtpDoB.Location = new Point(878, 318);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(327, 27);
            dtpDoB.TabIndex = 25;
            // 
            // lblDob
            // 
            lblDob.Location = new Point(778, 321);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(100, 23);
            lblDob.TabIndex = 24;
            lblDob.Text = "Date of Birth";
            lblDob.TextAlign = ContentAlignment.TopRight;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(778, 153);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.TopRight;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(255, 224, 192);
            txtEmail.Location = new Point(878, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(327, 27);
            txtEmail.TabIndex = 10;
            // 
            // lblHoursWorked
            // 
            lblHoursWorked.Location = new Point(294, 321);
            lblHoursWorked.Name = "lblHoursWorked";
            lblHoursWorked.Size = new Size(118, 23);
            lblHoursWorked.TabIndex = 21;
            lblHoursWorked.Text = "Patient Number";
            lblHoursWorked.TextAlign = ContentAlignment.TopRight;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(312, 209);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 23);
            lblAddress.TabIndex = 12;
            lblAddress.Text = "Address";
            lblAddress.TextAlign = ContentAlignment.TopRight;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(255, 224, 192);
            txtAddress.Location = new Point(416, 206);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(789, 27);
            txtAddress.TabIndex = 13;
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.FromArgb(255, 224, 192);
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Location = new Point(878, 260);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(179, 28);
            cmbGender.TabIndex = 19;
            // 
            // lblGender
            // 
            lblGender.Location = new Point(778, 263);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(100, 23);
            lblGender.TabIndex = 18;
            lblGender.Text = "Gender";
            lblGender.TextAlign = ContentAlignment.TopRight;
            // 
            // lblCounty
            // 
            lblCounty.Location = new Point(312, 263);
            lblCounty.Name = "lblCounty";
            lblCounty.Size = new Size(100, 23);
            lblCounty.TabIndex = 15;
            lblCounty.Text = "County";
            lblCounty.TextAlign = ContentAlignment.TopRight;
            // 
            // cmbCounty
            // 
            cmbCounty.BackColor = Color.FromArgb(255, 224, 192);
            cmbCounty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCounty.Location = new Point(416, 260);
            cmbCounty.Name = "cmbCounty";
            cmbCounty.Size = new Size(179, 28);
            cmbCounty.TabIndex = 16;
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
            // lblError
            // 
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(299, 361);
            lblError.Name = "lblError";
            lblError.Size = new Size(906, 23);
            lblError.TabIndex = 23;
            // 
            // PatientsControl
            // 
            Controls.Add(splitCont);
            Name = "PatientsControl";
            Size = new Size(1561, 832);
            Load += PatientsControl_Load;
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
        private Button btnGetPatient;
        private Label lblPagination;
        private Button btnNext;
        private Button btnPrev;
        private Label label2;
        private TextBox txtPatientNumber;
        private Button btnGetPatientAbove25;
        private Label lblError;
    }
}
