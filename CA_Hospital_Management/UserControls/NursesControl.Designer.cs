namespace CA_Hospital_Management.UserControls
{
    partial class NursesControl
    {
        private System.ComponentModel.IContainer components = null;

        private SplitContainer splitCont;

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtAddress;

        private ComboBox cmbCounty;
        private ComboBox cmbGender;

        private NumericUpDown hoursWorked;
        private DateTimePicker dtpDoB;

        private DataGridView mainDgv;

        private Button btnCreate;
        private Button btnUpdate;
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
            label4 = new Label();
            cmbContract = new ComboBox();
            txtDepartment = new TextBox();
            label3 = new Label();
            btnMaleNurses = new Button();
            label2 = new Label();
            lblPagination = new Label();
            btnNext = new Button();
            btnPrev = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            btnGetNurse = new Button();
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
            lblError = new Label();
            txtEmail = new TextBox();
            hoursWorked = new NumericUpDown();
            lblHoursWorked = new Label();
            lblAddress = new Label();
            txtAddress = new TextBox();
            cmbGender = new ComboBox();
            lblGender = new Label();
            lblCounty = new Label();
            cmbCounty = new ComboBox();
            mainDgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitCont).BeginInit();
            splitCont.Panel1.SuspendLayout();
            splitCont.Panel2.SuspendLayout();
            splitCont.SuspendLayout();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hoursWorked).BeginInit();
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
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(cmbContract);
            panelForm.Controls.Add(txtDepartment);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(btnMaleNurses);
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(lblPagination);
            panelForm.Controls.Add(btnNext);
            panelForm.Controls.Add(btnPrev);
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(txtSearch);
            panelForm.Controls.Add(btnGetNurse);
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
            panelForm.Controls.Add(hoursWorked);
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
            // label4
            // 
            label4.Location = new Point(778, 185);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 45;
            label4.Text = "Contract";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // cmbContract
            // 
            cmbContract.BackColor = Color.FromArgb(255, 224, 192);
            cmbContract.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContract.Location = new Point(881, 183);
            cmbContract.Name = "cmbContract";
            cmbContract.Size = new Size(179, 28);
            cmbContract.TabIndex = 6;
            // 
            // txtDepartment
            // 
            txtDepartment.BackColor = Color.FromArgb(255, 224, 192);
            txtDepartment.Location = new Point(416, 183);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(327, 27);
            txtDepartment.TabIndex = 5;
            // 
            // label3
            // 
            label3.Location = new Point(325, 185);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 44;
            label3.Text = "Department";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnMaleNurses
            // 
            btnMaleNurses.BackColor = SystemColors.MenuHighlight;
            btnMaleNurses.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaleNurses.ForeColor = Color.White;
            btnMaleNurses.Location = new Point(950, 392);
            btnMaleNurses.Name = "btnMaleNurses";
            btnMaleNurses.Size = new Size(123, 42);
            btnMaleNurses.TabIndex = 39;
            btnMaleNurses.Text = "Male Nurses";
            btnMaleNurses.UseVisualStyleBackColor = false;
            btnMaleNurses.Click += btnMaleNurses_Click;
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
            label2.Size = new Size(883, 57);
            label2.TabIndex = 38;
            label2.Text = "Nurses";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPagination
            // 
            lblPagination.ForeColor = Color.Black;
            lblPagination.Location = new Point(590, 552);
            lblPagination.Name = "lblPagination";
            lblPagination.Size = new Size(332, 23);
            lblPagination.TabIndex = 37;
            lblPagination.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.MenuHighlight;
            btnNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(950, 543);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(123, 40);
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
            btnPrev.Location = new Point(470, 543);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(114, 40);
            btnPrev.TabIndex = 35;
            btnPrev.Text = "Privious";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // label1
            // 
            label1.Location = new Point(470, 458);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 34;
            label1.Text = "Search By Name";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(255, 224, 192);
            txtSearch.Location = new Point(590, 454);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(332, 27);
            txtSearch.TabIndex = 33;
            // 
            // btnGetNurse
            // 
            btnGetNurse.BackColor = SystemColors.MenuHighlight;
            btnGetNurse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetNurse.ForeColor = Color.White;
            btnGetNurse.Location = new Point(950, 446);
            btnGetNurse.Name = "btnGetNurse";
            btnGetNurse.Size = new Size(123, 42);
            btnGetNurse.TabIndex = 32;
            btnGetNurse.Text = "Search Nurse";
            btnGetNurse.UseVisualStyleBackColor = false;
            btnGetNurse.Click += btnGetNurse_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.Location = new Point(314, 98);
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
            btnCreate.Location = new Point(470, 394);
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
            lblMessage.Location = new Point(470, 507);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(603, 23);
            lblMessage.TabIndex = 31;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.Visible = false;
            // 
            // lblLastName
            // 
            lblLastName.Location = new Point(778, 98);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(100, 23);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name";
            lblLastName.TextAlign = ContentAlignment.TopRight;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(255, 224, 192);
            txtLastName.Location = new Point(881, 95);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(327, 27);
            txtLastName.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.MenuHighlight;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(830, 394);
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
            btnDelete.Location = new Point(710, 394);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 40);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(314, 140);
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
            btnUpdate.Location = new Point(590, 394);
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
            txtPhone.Location = new Point(416, 138);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(327, 27);
            txtPhone.TabIndex = 3;
            // 
            // dtpDoB
            // 
            dtpDoB.CalendarMonthBackground = Color.FromArgb(255, 224, 192);
            dtpDoB.Location = new Point(878, 314);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(330, 27);
            dtpDoB.TabIndex = 11;
            // 
            // lblDob
            // 
            lblDob.Location = new Point(778, 317);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(100, 23);
            lblDob.TabIndex = 24;
            lblDob.Text = "Date of Birth";
            lblDob.TextAlign = ContentAlignment.TopRight;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(778, 143);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.TopRight;
            // 
            // lblError
            // 
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(325, 359);
            lblError.Name = "lblError";
            lblError.Size = new Size(883, 23);
            lblError.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(255, 224, 192);
            txtEmail.Location = new Point(881, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(327, 27);
            txtEmail.TabIndex = 4;
            // 
            // hoursWorked
            // 
            hoursWorked.BackColor = Color.FromArgb(255, 224, 192);
            hoursWorked.Location = new Point(416, 314);
            hoursWorked.Name = "hoursWorked";
            hoursWorked.Size = new Size(179, 27);
            hoursWorked.TabIndex = 10;
            // 
            // lblHoursWorked
            // 
            lblHoursWorked.Location = new Point(314, 317);
            lblHoursWorked.Name = "lblHoursWorked";
            lblHoursWorked.Size = new Size(100, 23);
            lblHoursWorked.TabIndex = 21;
            lblHoursWorked.Text = "Hours";
            lblHoursWorked.TextAlign = ContentAlignment.TopRight;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(314, 227);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 23);
            lblAddress.TabIndex = 12;
            lblAddress.Text = "Address";
            lblAddress.TextAlign = ContentAlignment.TopRight;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(255, 224, 192);
            txtAddress.Location = new Point(416, 224);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(792, 27);
            txtAddress.TabIndex = 7;
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.FromArgb(255, 224, 192);
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Location = new Point(878, 268);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(179, 28);
            cmbGender.TabIndex = 9;
            // 
            // lblGender
            // 
            lblGender.Location = new Point(778, 271);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(100, 23);
            lblGender.TabIndex = 18;
            lblGender.Text = "Gender";
            lblGender.TextAlign = ContentAlignment.TopRight;
            // 
            // lblCounty
            // 
            lblCounty.Location = new Point(314, 271);
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
            cmbCounty.Location = new Point(416, 268);
            cmbCounty.Name = "cmbCounty";
            cmbCounty.Size = new Size(179, 28);
            cmbCounty.TabIndex = 8;
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
            // NursesControl
            // 
            Controls.Add(splitCont);
            Name = "NursesControl";
            Size = new Size(1561, 832);
            Load += NursesControl_Load;
            splitCont.Panel1.ResumeLayout(false);
            splitCont.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitCont).EndInit();
            splitCont.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hoursWorked).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForm;
        private Label label1;
        private TextBox txtSearch;
        private Button btnGetNurse;
        private Label lblPagination;
        private Button btnNext;
        private Button btnPrev;
        private Label label2;
        private Button btnMaleNurses;
        private TextBox txtPhone;
        private Label label4;
        private ComboBox cmbContract;
        private TextBox txtDepartment;
        private Label label3;
    }
}
