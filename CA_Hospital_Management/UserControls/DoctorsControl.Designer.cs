namespace CA_Hospital_Management.UserControls
{
    partial class DoctorsControl
    {
        private System.ComponentModel.IContainer components = null;

        private SplitContainer splitDoctors;

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;

        private ComboBox cmbCounty;
        private ComboBox cmbGender;

        private NumericUpDown numSalary;
        private DateTimePicker dtpDoB;

        private DataGridView dgvDoctors;

        private Button btnCreateDoctor;
        private Button btnUpdateDoctor;
        private Button btnDelete;
        private Button btnClear;

        private Label lblDocMessage;
        private Label lblDocFNameError;
        private Label lblDocLNameError;
        private Label lblDocPhoneError;
        private Label lblDocEmailError;
        private Label lblDocAddrError;
        private Label lblDocCountyError;
        private Label lblDocGenderError;
        private Label lblDocSalaryError;

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblAddress;
        private Label lblCounty;
        private Label lblGender;
        private Label lblSalary;
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
            splitDoctors = new SplitContainer();
            panelForm = new Panel();
            label2 = new Label();
            lblPagination = new Label();
            btnNext = new Button();
            btnPrev = new Button();
            label1 = new Label();
            txtSearchDoctor = new TextBox();
            btnGetDoctor = new Button();
            lblDocFNameError = new Label();
            lblFirstName = new Label();
            btnCreateDoctor = new Button();
            txtFirstName = new TextBox();
            lblDocMessage = new Label();
            lblLastName = new Label();
            txtLastName = new TextBox();
            btnClear = new Button();
            lblDocLNameError = new Label();
            btnDelete = new Button();
            lblPhone = new Label();
            btnUpdateDoctor = new Button();
            txtPhone = new TextBox();
            dtpDoB = new DateTimePicker();
            lblDocPhoneError = new Label();
            lblDob = new Label();
            lblEmail = new Label();
            lblDocSalaryError = new Label();
            txtEmail = new TextBox();
            numSalary = new NumericUpDown();
            lblDocEmailError = new Label();
            lblSalary = new Label();
            lblAddress = new Label();
            lblDocGenderError = new Label();
            txtAddress = new TextBox();
            cmbGender = new ComboBox();
            lblDocAddrError = new Label();
            lblGender = new Label();
            lblCounty = new Label();
            lblDocCountyError = new Label();
            cmbCounty = new ComboBox();
            dgvDoctors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitDoctors).BeginInit();
            splitDoctors.Panel1.SuspendLayout();
            splitDoctors.Panel2.SuspendLayout();
            splitDoctors.SuspendLayout();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            SuspendLayout();
            // 
            // splitDoctors
            // 
            splitDoctors.Dock = DockStyle.Fill;
            splitDoctors.Location = new Point(0, 0);
            splitDoctors.Name = "splitDoctors";
            splitDoctors.Orientation = Orientation.Horizontal;
            // 
            // splitDoctors.Panel1
            // 
            splitDoctors.Panel1.AutoScroll = true;
            splitDoctors.Panel1.Controls.Add(panelForm);
            splitDoctors.Panel1.Paint += splitDoctors_Panel1_Paint;
            splitDoctors.Panel1.Resize += splitDoctors_Panel1_Resize;
            // 
            // splitDoctors.Panel2
            // 
            splitDoctors.Panel2.Controls.Add(dgvDoctors);
            splitDoctors.Size = new Size(1561, 832);
            splitDoctors.SplitterDistance = 595;
            splitDoctors.TabIndex = 0;
            // 
            // panelForm
            // 
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(lblPagination);
            panelForm.Controls.Add(btnNext);
            panelForm.Controls.Add(btnPrev);
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(txtSearchDoctor);
            panelForm.Controls.Add(btnGetDoctor);
            panelForm.Controls.Add(lblDocFNameError);
            panelForm.Controls.Add(lblFirstName);
            panelForm.Controls.Add(btnCreateDoctor);
            panelForm.Controls.Add(txtFirstName);
            panelForm.Controls.Add(lblDocMessage);
            panelForm.Controls.Add(lblLastName);
            panelForm.Controls.Add(txtLastName);
            panelForm.Controls.Add(btnClear);
            panelForm.Controls.Add(lblDocLNameError);
            panelForm.Controls.Add(btnDelete);
            panelForm.Controls.Add(lblPhone);
            panelForm.Controls.Add(btnUpdateDoctor);
            panelForm.Controls.Add(txtPhone);
            panelForm.Controls.Add(dtpDoB);
            panelForm.Controls.Add(lblDocPhoneError);
            panelForm.Controls.Add(lblDob);
            panelForm.Controls.Add(lblEmail);
            panelForm.Controls.Add(lblDocSalaryError);
            panelForm.Controls.Add(txtEmail);
            panelForm.Controls.Add(numSalary);
            panelForm.Controls.Add(lblDocEmailError);
            panelForm.Controls.Add(lblSalary);
            panelForm.Controls.Add(lblAddress);
            panelForm.Controls.Add(lblDocGenderError);
            panelForm.Controls.Add(txtAddress);
            panelForm.Controls.Add(cmbGender);
            panelForm.Controls.Add(lblDocAddrError);
            panelForm.Controls.Add(lblGender);
            panelForm.Controls.Add(lblCounty);
            panelForm.Controls.Add(lblDocCountyError);
            panelForm.Controls.Add(cmbCounty);
            panelForm.Location = new Point(17, 3);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(1524, 589);
            panelForm.TabIndex = 32;
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
            label2.Text = "Doctors";
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
            label1.Click += label1_Click;
            // 
            // txtSearchDoctor
            // 
            txtSearchDoctor.BackColor = Color.FromArgb(255, 224, 192);
            txtSearchDoctor.Location = new Point(602, 454);
            txtSearchDoctor.Name = "txtSearchDoctor";
            txtSearchDoctor.Size = new Size(327, 27);
            txtSearchDoctor.TabIndex = 33;
            // 
            // btnGetDoctor
            // 
            btnGetDoctor.BackColor = SystemColors.MenuHighlight;
            btnGetDoctor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetDoctor.ForeColor = Color.White;
            btnGetDoctor.Location = new Point(937, 446);
            btnGetDoctor.Name = "btnGetDoctor";
            btnGetDoctor.Size = new Size(123, 42);
            btnGetDoctor.TabIndex = 32;
            btnGetDoctor.Text = "Search Doctor";
            btnGetDoctor.UseVisualStyleBackColor = false;
            btnGetDoctor.Click += btnGetDoctor_Click;
            // 
            // lblDocFNameError
            // 
            lblDocFNameError.ForeColor = Color.Red;
            lblDocFNameError.Location = new Point(416, 124);
            lblDocFNameError.Name = "lblDocFNameError";
            lblDocFNameError.Size = new Size(100, 23);
            lblDocFNameError.TabIndex = 2;
            lblDocFNameError.Visible = false;
            // 
            // lblFirstName
            // 
            lblFirstName.Location = new Point(314, 97);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(100, 23);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // btnCreateDoctor
            // 
            btnCreateDoctor.BackColor = SystemColors.MenuHighlight;
            btnCreateDoctor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateDoctor.ForeColor = Color.White;
            btnCreateDoctor.Location = new Point(541, 394);
            btnCreateDoctor.Name = "btnCreateDoctor";
            btnCreateDoctor.Size = new Size(92, 40);
            btnCreateDoctor.TabIndex = 26;
            btnCreateDoctor.Text = "Create";
            btnCreateDoctor.UseVisualStyleBackColor = false;
            btnCreateDoctor.Click += btnCreateDoctor_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(255, 224, 192);
            txtFirstName.Location = new Point(416, 95);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(327, 27);
            txtFirstName.TabIndex = 1;
            // 
            // lblDocMessage
            // 
            lblDocMessage.ForeColor = Color.Red;
            lblDocMessage.Location = new Point(476, 507);
            lblDocMessage.Name = "lblDocMessage";
            lblDocMessage.Size = new Size(581, 23);
            lblDocMessage.TabIndex = 31;
            lblDocMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblDocMessage.Visible = false;
            lblDocMessage.Click += lblDocMessage_Click;
            // 
            // lblLastName
            // 
            lblLastName.Location = new Point(778, 97);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(100, 23);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name";
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
            btnClear.Location = new Point(901, 394);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 42);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblDocLNameError
            // 
            lblDocLNameError.ForeColor = Color.Red;
            lblDocLNameError.Location = new Point(878, 124);
            lblDocLNameError.Name = "lblDocLNameError";
            lblDocLNameError.Size = new Size(100, 23);
            lblDocLNameError.TabIndex = 5;
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
            btnDelete.Click += btnDeleteDoctor_Click;
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(314, 153);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone";
            // 
            // btnUpdateDoctor
            // 
            btnUpdateDoctor.BackColor = Color.Lime;
            btnUpdateDoctor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateDoctor.ForeColor = Color.White;
            btnUpdateDoctor.Location = new Point(661, 394);
            btnUpdateDoctor.Name = "btnUpdateDoctor";
            btnUpdateDoctor.Size = new Size(92, 40);
            btnUpdateDoctor.TabIndex = 27;
            btnUpdateDoctor.Text = "Update";
            btnUpdateDoctor.UseVisualStyleBackColor = false;
            btnUpdateDoctor.Click += btnUpdateDoctor_Click;
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
            // lblDocPhoneError
            // 
            lblDocPhoneError.ForeColor = Color.Red;
            lblDocPhoneError.Location = new Point(416, 180);
            lblDocPhoneError.Name = "lblDocPhoneError";
            lblDocPhoneError.Size = new Size(280, 23);
            lblDocPhoneError.TabIndex = 8;
            // 
            // lblDob
            // 
            lblDob.Location = new Point(778, 321);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(100, 23);
            lblDob.TabIndex = 24;
            lblDob.Text = "Date of Birth";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(778, 153);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // lblDocSalaryError
            // 
            lblDocSalaryError.ForeColor = Color.Red;
            lblDocSalaryError.Location = new Point(416, 348);
            lblDocSalaryError.Name = "lblDocSalaryError";
            lblDocSalaryError.Size = new Size(259, 23);
            lblDocSalaryError.TabIndex = 23;
            lblDocSalaryError.Click += lblDocSalaryError_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(255, 224, 192);
            txtEmail.Location = new Point(878, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(327, 27);
            txtEmail.TabIndex = 10;
            // 
            // numSalary
            // 
            numSalary.BackColor = Color.FromArgb(255, 224, 192);
            numSalary.Location = new Point(416, 318);
            numSalary.Name = "numSalary";
            numSalary.Size = new Size(179, 27);
            numSalary.TabIndex = 22;
            // 
            // lblDocEmailError
            // 
            lblDocEmailError.ForeColor = Color.Red;
            lblDocEmailError.Location = new Point(878, 180);
            lblDocEmailError.Name = "lblDocEmailError";
            lblDocEmailError.Size = new Size(280, 23);
            lblDocEmailError.TabIndex = 11;
            // 
            // lblSalary
            // 
            lblSalary.Location = new Point(314, 321);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(100, 23);
            lblSalary.TabIndex = 21;
            lblSalary.Text = "Salary";
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(314, 209);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 23);
            lblAddress.TabIndex = 12;
            lblAddress.Text = "Address";
            // 
            // lblDocGenderError
            // 
            lblDocGenderError.ForeColor = Color.Red;
            lblDocGenderError.Location = new Point(878, 291);
            lblDocGenderError.Name = "lblDocGenderError";
            lblDocGenderError.Size = new Size(280, 23);
            lblDocGenderError.TabIndex = 20;
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
            // lblDocAddrError
            // 
            lblDocAddrError.ForeColor = Color.Red;
            lblDocAddrError.Location = new Point(416, 236);
            lblDocAddrError.Name = "lblDocAddrError";
            lblDocAddrError.Size = new Size(280, 23);
            lblDocAddrError.TabIndex = 14;
            // 
            // lblGender
            // 
            lblGender.Location = new Point(778, 263);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(100, 23);
            lblGender.TabIndex = 18;
            lblGender.Text = "Gender";
            // 
            // lblCounty
            // 
            lblCounty.Location = new Point(314, 263);
            lblCounty.Name = "lblCounty";
            lblCounty.Size = new Size(100, 23);
            lblCounty.TabIndex = 15;
            lblCounty.Text = "County";
            // 
            // lblDocCountyError
            // 
            lblDocCountyError.ForeColor = Color.Red;
            lblDocCountyError.Location = new Point(416, 291);
            lblDocCountyError.Name = "lblDocCountyError";
            lblDocCountyError.Size = new Size(259, 23);
            lblDocCountyError.TabIndex = 17;
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
            // dgvDoctors
            // 
            dgvDoctors.ColumnHeadersHeight = 29;
            dgvDoctors.Dock = DockStyle.Fill;
            dgvDoctors.Location = new Point(0, 0);
            dgvDoctors.MultiSelect = false;
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.ReadOnly = true;
            dgvDoctors.RowHeadersWidth = 51;
            dgvDoctors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoctors.Size = new Size(1561, 233);
            dgvDoctors.TabIndex = 0;
            dgvDoctors.CellClick += dgvDoctors_CellClick;
            // 
            // DoctorsControl
            // 
            Controls.Add(splitDoctors);
            Name = "DoctorsControl";
            Size = new Size(1561, 832);
            Load += DoctorsControl_Load;
            splitDoctors.Panel1.ResumeLayout(false);
            splitDoctors.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitDoctors).EndInit();
            splitDoctors.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForm;
        private Label label1;
        private TextBox txtSearchDoctor;
        private Button btnGetDoctor;
        private Label lblPagination;
        private Button btnNext;
        private Button btnPrev;
        private Label label2;
    }
}
