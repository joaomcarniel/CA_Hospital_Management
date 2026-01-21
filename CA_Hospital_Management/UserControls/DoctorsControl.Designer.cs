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

        private Label lblMessage;
        private Label lblError;

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
            label4 = new Label();
            cmbContract = new ComboBox();
            txtDepartment = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lblPagination = new Label();
            btnNext = new Button();
            btnPrev = new Button();
            label1 = new Label();
            txtSearchDoctor = new TextBox();
            btnGetDoctor = new Button();
            lblFirstName = new Label();
            btnCreateDoctor = new Button();
            txtFirstName = new TextBox();
            lblMessage = new Label();
            lblLastName = new Label();
            txtLastName = new TextBox();
            btnClear = new Button();
            btnDelete = new Button();
            lblPhone = new Label();
            btnUpdateDoctor = new Button();
            txtPhone = new TextBox();
            dtpDoB = new DateTimePicker();
            lblDob = new Label();
            lblEmail = new Label();
            lblError = new Label();
            txtEmail = new TextBox();
            numSalary = new NumericUpDown();
            lblSalary = new Label();
            lblAddress = new Label();
            txtAddress = new TextBox();
            cmbGender = new ComboBox();
            lblGender = new Label();
            lblCounty = new Label();
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
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(cmbContract);
            panelForm.Controls.Add(txtDepartment);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(lblPagination);
            panelForm.Controls.Add(btnNext);
            panelForm.Controls.Add(btnPrev);
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(txtSearchDoctor);
            panelForm.Controls.Add(btnGetDoctor);
            panelForm.Controls.Add(lblFirstName);
            panelForm.Controls.Add(btnCreateDoctor);
            panelForm.Controls.Add(txtFirstName);
            panelForm.Controls.Add(lblMessage);
            panelForm.Controls.Add(lblLastName);
            panelForm.Controls.Add(txtLastName);
            panelForm.Controls.Add(btnClear);
            panelForm.Controls.Add(btnDelete);
            panelForm.Controls.Add(lblPhone);
            panelForm.Controls.Add(btnUpdateDoctor);
            panelForm.Controls.Add(txtPhone);
            panelForm.Controls.Add(dtpDoB);
            panelForm.Controls.Add(lblDob);
            panelForm.Controls.Add(lblEmail);
            panelForm.Controls.Add(lblError);
            panelForm.Controls.Add(txtEmail);
            panelForm.Controls.Add(numSalary);
            panelForm.Controls.Add(lblSalary);
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
            // label4
            // 
            label4.Location = new Point(778, 183);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 41;
            label4.Text = "Contract";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // cmbContract
            // 
            cmbContract.BackColor = Color.FromArgb(255, 224, 192);
            cmbContract.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContract.Location = new Point(878, 180);
            cmbContract.Name = "cmbContract";
            cmbContract.Size = new Size(179, 28);
            cmbContract.TabIndex = 6;
            // 
            // txtDepartment
            // 
            txtDepartment.BackColor = Color.FromArgb(255, 224, 192);
            txtDepartment.Location = new Point(416, 181);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(327, 27);
            txtDepartment.TabIndex = 5;
            // 
            // label3
            // 
            label3.Location = new Point(325, 183);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 39;
            label3.Text = "Department";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.BackColor = Color.SteelBlue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(325, 17);
            label2.Name = "label2";
            label2.Size = new Size(880, 57);
            label2.TabIndex = 38;
            label2.Text = "Doctors";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPagination
            // 
            lblPagination.ForeColor = Color.Black;
            lblPagination.Location = new Point(637, 552);
            lblPagination.Name = "lblPagination";
            lblPagination.Size = new Size(255, 23);
            lblPagination.TabIndex = 37;
            lblPagination.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.MenuHighlight;
            btnNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(963, 543);
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
            btnPrev.Location = new Point(474, 543);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(92, 40);
            btnPrev.TabIndex = 35;
            btnPrev.Text = "Privious";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // label1
            // 
            label1.Location = new Point(474, 458);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 34;
            label1.Text = "Search By Name";
            // 
            // txtSearchDoctor
            // 
            txtSearchDoctor.BackColor = Color.FromArgb(255, 224, 192);
            txtSearchDoctor.Location = new Point(600, 454);
            txtSearchDoctor.Name = "txtSearchDoctor";
            txtSearchDoctor.Size = new Size(327, 27);
            txtSearchDoctor.TabIndex = 33;
            // 
            // btnGetDoctor
            // 
            btnGetDoctor.BackColor = SystemColors.MenuHighlight;
            btnGetDoctor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetDoctor.ForeColor = Color.White;
            btnGetDoctor.Location = new Point(932, 446);
            btnGetDoctor.Name = "btnGetDoctor";
            btnGetDoctor.Size = new Size(123, 42);
            btnGetDoctor.TabIndex = 32;
            btnGetDoctor.Text = "Search Doctor";
            btnGetDoctor.UseVisualStyleBackColor = false;
            btnGetDoctor.Click += btnGetDoctor_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.Location = new Point(314, 98);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(100, 23);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            lblFirstName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCreateDoctor
            // 
            btnCreateDoctor.BackColor = SystemColors.MenuHighlight;
            btnCreateDoctor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateDoctor.ForeColor = Color.White;
            btnCreateDoctor.Location = new Point(474, 396);
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
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(474, 505);
            lblMessage.Name = "lblDocMessage";
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
            txtLastName.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.MenuHighlight;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(963, 395);
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
            btnDelete.Location = new Point(800, 396);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 40);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDeleteDoctor_Click;
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(314, 141);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone";
            lblPhone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnUpdateDoctor
            // 
            btnUpdateDoctor.BackColor = Color.Lime;
            btnUpdateDoctor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateDoctor.ForeColor = Color.White;
            btnUpdateDoctor.Location = new Point(637, 396);
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
            txtPhone.Location = new Point(416, 139);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(327, 27);
            txtPhone.TabIndex = 3;
            // 
            // dtpDoB
            // 
            dtpDoB.CalendarMonthBackground = Color.FromArgb(255, 224, 192);
            dtpDoB.Location = new Point(878, 315);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(327, 27);
            dtpDoB.TabIndex = 11;
            // 
            // lblDob
            // 
            lblDob.Location = new Point(778, 318);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(100, 23);
            lblDob.TabIndex = 24;
            lblDob.Text = "Date of Birth";
            lblDob.TextAlign = ContentAlignment.TopRight;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(778, 142);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.TopRight;
            // 
            // lblError
            // 
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(325, 357);
            lblError.Name = "lblError";
            lblError.Size = new Size(880, 23);
            lblError.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(255, 224, 192);
            txtEmail.Location = new Point(878, 139);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(327, 27);
            txtEmail.TabIndex = 4;
            // 
            // numSalary
            // 
            numSalary.BackColor = Color.FromArgb(255, 224, 192);
            numSalary.Location = new Point(416, 311);
            numSalary.Name = "numSalary";
            numSalary.Size = new Size(179, 27);
            numSalary.TabIndex = 10;
            // 
            // lblSalary
            // 
            lblSalary.Location = new Point(314, 315);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(100, 23);
            lblSalary.TabIndex = 21;
            lblSalary.Text = "Salary";
            lblSalary.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(314, 226);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 23);
            lblAddress.TabIndex = 12;
            lblAddress.Text = "Address";
            lblAddress.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(255, 224, 192);
            txtAddress.Location = new Point(416, 224);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(789, 27);
            txtAddress.TabIndex = 7;
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.FromArgb(255, 224, 192);
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Location = new Point(878, 266);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(179, 28);
            cmbGender.TabIndex = 9;
            // 
            // lblGender
            // 
            lblGender.Location = new Point(778, 269);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(100, 23);
            lblGender.TabIndex = 18;
            lblGender.Text = "Gender";
            lblGender.TextAlign = ContentAlignment.TopRight;
            // 
            // lblCounty
            // 
            lblCounty.Location = new Point(314, 269);
            lblCounty.Name = "lblCounty";
            lblCounty.Size = new Size(100, 23);
            lblCounty.TabIndex = 15;
            lblCounty.Text = "County";
            lblCounty.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbCounty
            // 
            cmbCounty.BackColor = Color.FromArgb(255, 224, 192);
            cmbCounty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCounty.Location = new Point(416, 267);
            cmbCounty.Name = "cmbCounty";
            cmbCounty.Size = new Size(179, 28);
            cmbCounty.TabIndex = 8;
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
        private Label label4;
        private ComboBox cmbContract;
        private TextBox txtDepartment;
        private Label label3;
        private Label label5;
    }
}
