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
        private Button btnListDoctors;

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
            lblDocFNameError = new Label();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblDocLNameError = new Label();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblDocPhoneError = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblDocEmailError = new Label();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblDocAddrError = new Label();
            lblCounty = new Label();
            cmbCounty = new ComboBox();
            lblDocCountyError = new Label();
            lblGender = new Label();
            cmbGender = new ComboBox();
            lblDocGenderError = new Label();
            lblSalary = new Label();
            numSalary = new NumericUpDown();
            lblDocSalaryError = new Label();
            lblDob = new Label();
            dtpDoB = new DateTimePicker();
            btnCreateDoctor = new Button();
            btnUpdateDoctor = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnListDoctors = new Button();
            lblDocMessage = new Label();
            dgvDoctors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitDoctors).BeginInit();
            splitDoctors.Panel1.SuspendLayout();
            splitDoctors.Panel2.SuspendLayout();
            splitDoctors.SuspendLayout();
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
            splitDoctors.Panel1.Controls.Add(lblDocFNameError);
            splitDoctors.Panel1.Controls.Add(lblFirstName);
            splitDoctors.Panel1.Controls.Add(txtFirstName);
            splitDoctors.Panel1.Controls.Add(lblLastName);
            splitDoctors.Panel1.Controls.Add(txtLastName);
            splitDoctors.Panel1.Controls.Add(lblDocLNameError);
            splitDoctors.Panel1.Controls.Add(lblPhone);
            splitDoctors.Panel1.Controls.Add(txtPhone);
            splitDoctors.Panel1.Controls.Add(lblDocPhoneError);
            splitDoctors.Panel1.Controls.Add(lblEmail);
            splitDoctors.Panel1.Controls.Add(txtEmail);
            splitDoctors.Panel1.Controls.Add(lblDocEmailError);
            splitDoctors.Panel1.Controls.Add(lblAddress);
            splitDoctors.Panel1.Controls.Add(txtAddress);
            splitDoctors.Panel1.Controls.Add(lblDocAddrError);
            splitDoctors.Panel1.Controls.Add(lblCounty);
            splitDoctors.Panel1.Controls.Add(cmbCounty);
            splitDoctors.Panel1.Controls.Add(lblDocCountyError);
            splitDoctors.Panel1.Controls.Add(lblGender);
            splitDoctors.Panel1.Controls.Add(cmbGender);
            splitDoctors.Panel1.Controls.Add(lblDocGenderError);
            splitDoctors.Panel1.Controls.Add(lblSalary);
            splitDoctors.Panel1.Controls.Add(numSalary);
            splitDoctors.Panel1.Controls.Add(lblDocSalaryError);
            splitDoctors.Panel1.Controls.Add(lblDob);
            splitDoctors.Panel1.Controls.Add(dtpDoB);
            splitDoctors.Panel1.Controls.Add(btnCreateDoctor);
            splitDoctors.Panel1.Controls.Add(btnUpdateDoctor);
            splitDoctors.Panel1.Controls.Add(btnDelete);
            splitDoctors.Panel1.Controls.Add(btnClear);
            splitDoctors.Panel1.Controls.Add(btnListDoctors);
            splitDoctors.Panel1.Controls.Add(lblDocMessage);
            splitDoctors.Panel1.Paint += splitDoctors_Panel1_Paint;
            // 
            // splitDoctors.Panel2
            // 
            splitDoctors.Panel2.Controls.Add(dgvDoctors);
            splitDoctors.Size = new Size(1561, 832);
            splitDoctors.SplitterDistance = 590;
            splitDoctors.TabIndex = 0;
            // 
            // lblDocFNameError
            // 
            lblDocFNameError.ForeColor = Color.Red;
            lblDocFNameError.Location = new Point(140, 116);
            lblDocFNameError.Name = "lblDocFNameError";
            lblDocFNameError.Size = new Size(100, 23);
            lblDocFNameError.TabIndex = 2;
            lblDocFNameError.Visible = false;
            // 
            // lblFirstName
            // 
            lblFirstName.Location = new Point(38, 89);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(100, 23);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(140, 87);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(280, 27);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.Location = new Point(502, 89);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(100, 23);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(602, 87);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(280, 27);
            txtLastName.TabIndex = 4;
            // 
            // lblDocLNameError
            // 
            lblDocLNameError.ForeColor = Color.Red;
            lblDocLNameError.Location = new Point(602, 116);
            lblDocLNameError.Name = "lblDocLNameError";
            lblDocLNameError.Size = new Size(100, 23);
            lblDocLNameError.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(38, 145);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(140, 142);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(280, 27);
            txtPhone.TabIndex = 7;
            // 
            // lblDocPhoneError
            // 
            lblDocPhoneError.ForeColor = Color.Red;
            lblDocPhoneError.Location = new Point(140, 172);
            lblDocPhoneError.Name = "lblDocPhoneError";
            lblDocPhoneError.Size = new Size(280, 23);
            lblDocPhoneError.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(502, 145);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(602, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 27);
            txtEmail.TabIndex = 10;
            // 
            // lblDocEmailError
            // 
            lblDocEmailError.ForeColor = Color.Red;
            lblDocEmailError.Location = new Point(602, 172);
            lblDocEmailError.Name = "lblDocEmailError";
            lblDocEmailError.Size = new Size(280, 23);
            lblDocEmailError.TabIndex = 11;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(38, 201);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 23);
            lblAddress.TabIndex = 12;
            lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(140, 198);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(742, 27);
            txtAddress.TabIndex = 13;
            // 
            // lblDocAddrError
            // 
            lblDocAddrError.ForeColor = Color.Red;
            lblDocAddrError.Location = new Point(140, 228);
            lblDocAddrError.Name = "lblDocAddrError";
            lblDocAddrError.Size = new Size(280, 23);
            lblDocAddrError.TabIndex = 14;
            // 
            // lblCounty
            // 
            lblCounty.Location = new Point(38, 255);
            lblCounty.Name = "lblCounty";
            lblCounty.Size = new Size(100, 23);
            lblCounty.TabIndex = 15;
            lblCounty.Text = "County";
            // 
            // cmbCounty
            // 
            cmbCounty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCounty.Location = new Point(140, 252);
            cmbCounty.Name = "cmbCounty";
            cmbCounty.Size = new Size(179, 28);
            cmbCounty.TabIndex = 16;
            // 
            // lblDocCountyError
            // 
            lblDocCountyError.ForeColor = Color.Red;
            lblDocCountyError.Location = new Point(140, 283);
            lblDocCountyError.Name = "lblDocCountyError";
            lblDocCountyError.Size = new Size(259, 23);
            lblDocCountyError.TabIndex = 17;
            // 
            // lblGender
            // 
            lblGender.Location = new Point(502, 255);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(100, 23);
            lblGender.TabIndex = 18;
            lblGender.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Location = new Point(602, 252);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(179, 28);
            cmbGender.TabIndex = 19;
            // 
            // lblDocGenderError
            // 
            lblDocGenderError.ForeColor = Color.Red;
            lblDocGenderError.Location = new Point(602, 283);
            lblDocGenderError.Name = "lblDocGenderError";
            lblDocGenderError.Size = new Size(280, 23);
            lblDocGenderError.TabIndex = 20;
            // 
            // lblSalary
            // 
            lblSalary.Location = new Point(38, 313);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(100, 23);
            lblSalary.TabIndex = 21;
            lblSalary.Text = "Salary";
            // 
            // numSalary
            // 
            numSalary.Location = new Point(140, 310);
            numSalary.Name = "numSalary";
            numSalary.Size = new Size(150, 27);
            numSalary.TabIndex = 22;
            // 
            // lblDocSalaryError
            // 
            lblDocSalaryError.ForeColor = Color.Red;
            lblDocSalaryError.Location = new Point(140, 340);
            lblDocSalaryError.Name = "lblDocSalaryError";
            lblDocSalaryError.Size = new Size(259, 23);
            lblDocSalaryError.TabIndex = 23;
            lblDocSalaryError.Click += lblDocSalaryError_Click;
            // 
            // lblDob
            // 
            lblDob.Location = new Point(502, 313);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(100, 23);
            lblDob.TabIndex = 24;
            lblDob.Text = "Date of Birth";
            // 
            // dtpDoB
            // 
            dtpDoB.Location = new Point(602, 310);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(327, 27);
            dtpDoB.TabIndex = 25;
            // 
            // btnCreateDoctor
            // 
            btnCreateDoctor.Location = new Point(215, 395);
            btnCreateDoctor.Name = "btnCreateDoctor";
            btnCreateDoctor.Size = new Size(92, 32);
            btnCreateDoctor.TabIndex = 26;
            btnCreateDoctor.Text = "Create";
            btnCreateDoctor.Click += btnCreateDoctor_Click;
            // 
            // btnUpdateDoctor
            // 
            btnUpdateDoctor.Location = new Point(215, 433);
            btnUpdateDoctor.Name = "btnUpdateDoctor";
            btnUpdateDoctor.Size = new Size(92, 28);
            btnUpdateDoctor.TabIndex = 27;
            btnUpdateDoctor.Text = "Update";
            btnUpdateDoctor.Click += btnUpdateDoctor_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(385, 395);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 32);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDeleteDoctor_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(562, 395);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 32);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // btnListDoctors
            // 
            btnListDoctors.Location = new Point(562, 438);
            btnListDoctors.Name = "btnListDoctors";
            btnListDoctors.Size = new Size(123, 35);
            btnListDoctors.TabIndex = 30;
            btnListDoctors.Text = "List Doctors";
            btnListDoctors.Click += btnListDoctors_Click;
            // 
            // lblDocMessage
            // 
            lblDocMessage.ForeColor = Color.Red;
            lblDocMessage.Location = new Point(180, 487);
            lblDocMessage.Name = "lblDocMessage";
            lblDocMessage.Size = new Size(539, 23);
            lblDocMessage.TabIndex = 31;
            lblDocMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblDocMessage.Visible = false;
            lblDocMessage.Click += lblDocMessage_Click;
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
            dgvDoctors.Size = new Size(1561, 238);
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
            splitDoctors.Panel1.PerformLayout();
            splitDoctors.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitDoctors).EndInit();
            splitDoctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
