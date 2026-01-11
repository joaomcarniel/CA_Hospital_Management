namespace CA_Hospital_Management.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuDoctors = new ToolStripMenuItem();
            menuNurses = new ToolStripMenuItem();
            menuPatients = new ToolStripMenuItem();
            menuConsultations = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            tabControlMain = new TabControl();
            tabDoctors = new TabPage();
            splitDoctors = new SplitContainer();
            btnListDoctors = new Button();
            lblDocMessage = new Label();
            lblDocSalaryError = new Label();
            lblDocGenderError = new Label();
            lblDocCountyError = new Label();
            lblDocAddrError = new Label();
            lblDocEmailError = new Label();
            lblDocPhoneError = new Label();
            lblDocLNameError = new Label();
            label22 = new Label();
            lblDocFNameError = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdateDoctor = new Button();
            btnCreateDoctor = new Button();
            label9 = new Label();
            txtEmail = new TextBox();
            label8 = new Label();
            txtPhone = new TextBox();
            dtpDoB = new DateTimePicker();
            label7 = new Label();
            cmbCounty = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtAddress = new TextBox();
            numSalary = new NumericUpDown();
            label4 = new Label();
            cmbGender = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label10 = new Label();
            textBox2 = new TextBox();
            label11 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            textBox3 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            dgvDoctors = new DataGridView();
            tabNurses = new TabPage();
            tabPatients = new TabPage();
            tabConsultations = new TabPage();
            tabAdmin = new TabPage();
            label19 = new Label();
            textBox6 = new TextBox();
            menuStrip1.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitDoctors).BeginInit();
            splitDoctors.Panel1.SuspendLayout();
            splitDoctors.Panel2.SuspendLayout();
            splitDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuDoctors, menuNurses, menuPatients, menuConsultations, adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(989, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuDoctors
            // 
            menuDoctors.Name = "menuDoctors";
            menuDoctors.Size = new Size(75, 24);
            menuDoctors.Text = "Doctors";
            menuDoctors.Click += menuDoctors_Click;
            // 
            // menuNurses
            // 
            menuNurses.Name = "menuNurses";
            menuNurses.Size = new Size(67, 24);
            menuNurses.Text = "Nurses";
            menuNurses.Click += menuNurses_Click;
            // 
            // menuPatients
            // 
            menuPatients.Name = "menuPatients";
            menuPatients.Size = new Size(74, 24);
            menuPatients.Text = "Patients";
            // 
            // menuConsultations
            // 
            menuConsultations.Name = "menuConsultations";
            menuConsultations.Size = new Size(112, 24);
            menuConsultations.Text = "Consultations";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabDoctors);
            tabControlMain.Controls.Add(tabNurses);
            tabControlMain.Controls.Add(tabPatients);
            tabControlMain.Controls.Add(tabConsultations);
            tabControlMain.Controls.Add(tabAdmin);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 28);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(989, 686);
            tabControlMain.TabIndex = 1;
            // 
            // tabDoctors
            // 
            tabDoctors.Controls.Add(splitDoctors);
            tabDoctors.Location = new Point(4, 29);
            tabDoctors.Name = "tabDoctors";
            tabDoctors.Padding = new Padding(3);
            tabDoctors.Size = new Size(981, 653);
            tabDoctors.TabIndex = 0;
            tabDoctors.Text = "Doctors";
            tabDoctors.UseVisualStyleBackColor = true;
            // 
            // splitDoctors
            // 
            splitDoctors.Dock = DockStyle.Fill;
            splitDoctors.Location = new Point(3, 3);
            splitDoctors.Name = "splitDoctors";
            splitDoctors.Orientation = Orientation.Horizontal;
            // 
            // splitDoctors.Panel1
            // 
            splitDoctors.Panel1.Controls.Add(btnListDoctors);
            splitDoctors.Panel1.Controls.Add(lblDocMessage);
            splitDoctors.Panel1.Controls.Add(lblDocSalaryError);
            splitDoctors.Panel1.Controls.Add(lblDocGenderError);
            splitDoctors.Panel1.Controls.Add(lblDocCountyError);
            splitDoctors.Panel1.Controls.Add(lblDocAddrError);
            splitDoctors.Panel1.Controls.Add(lblDocEmailError);
            splitDoctors.Panel1.Controls.Add(lblDocPhoneError);
            splitDoctors.Panel1.Controls.Add(lblDocLNameError);
            splitDoctors.Panel1.Controls.Add(label22);
            splitDoctors.Panel1.Controls.Add(lblDocFNameError);
            splitDoctors.Panel1.Controls.Add(btnClear);
            splitDoctors.Panel1.Controls.Add(btnDelete);
            splitDoctors.Panel1.Controls.Add(btnUpdateDoctor);
            splitDoctors.Panel1.Controls.Add(btnCreateDoctor);
            splitDoctors.Panel1.Controls.Add(label9);
            splitDoctors.Panel1.Controls.Add(txtEmail);
            splitDoctors.Panel1.Controls.Add(label8);
            splitDoctors.Panel1.Controls.Add(txtPhone);
            splitDoctors.Panel1.Controls.Add(dtpDoB);
            splitDoctors.Panel1.Controls.Add(label7);
            splitDoctors.Panel1.Controls.Add(cmbCounty);
            splitDoctors.Panel1.Controls.Add(label6);
            splitDoctors.Panel1.Controls.Add(label5);
            splitDoctors.Panel1.Controls.Add(txtAddress);
            splitDoctors.Panel1.Controls.Add(numSalary);
            splitDoctors.Panel1.Controls.Add(label4);
            splitDoctors.Panel1.Controls.Add(cmbGender);
            splitDoctors.Panel1.Controls.Add(label3);
            splitDoctors.Panel1.Controls.Add(label2);
            splitDoctors.Panel1.Controls.Add(label1);
            splitDoctors.Panel1.Controls.Add(txtLastName);
            splitDoctors.Panel1.Controls.Add(txtFirstName);
            splitDoctors.Panel1.Controls.Add(label10);
            splitDoctors.Panel1.Controls.Add(textBox2);
            splitDoctors.Panel1.Controls.Add(label11);
            splitDoctors.Panel1.Controls.Add(textBox1);
            splitDoctors.Panel1.Controls.Add(dateTimePicker1);
            splitDoctors.Panel1.Controls.Add(label12);
            splitDoctors.Panel1.Controls.Add(label13);
            splitDoctors.Panel1.Controls.Add(label14);
            splitDoctors.Panel1.Controls.Add(textBox3);
            splitDoctors.Panel1.Controls.Add(numericUpDown1);
            splitDoctors.Panel1.Controls.Add(label15);
            splitDoctors.Panel1.Controls.Add(label16);
            splitDoctors.Panel1.Controls.Add(label17);
            splitDoctors.Panel1.Controls.Add(label18);
            splitDoctors.Panel1.Controls.Add(textBox4);
            splitDoctors.Panel1.Controls.Add(textBox5);
            // 
            // splitDoctors.Panel2
            // 
            splitDoctors.Panel2.Controls.Add(dgvDoctors);
            splitDoctors.Size = new Size(975, 647);
            splitDoctors.SplitterDistance = 442;
            splitDoctors.TabIndex = 0;
            // 
            // btnListDoctors
            // 
            btnListDoctors.Location = new Point(528, 369);
            btnListDoctors.Name = "btnListDoctors";
            btnListDoctors.Size = new Size(128, 29);
            btnListDoctors.TabIndex = 37;
            btnListDoctors.Text = "List Doctors";
            btnListDoctors.UseVisualStyleBackColor = true;
            btnListDoctors.Click += btnListDoctors_Click;
            // 
            // lblDocMessage
            // 
            lblDocMessage.AutoSize = true;
            lblDocMessage.ForeColor = Color.Red;
            lblDocMessage.Location = new Point(346, 407);
            lblDocMessage.Name = "lblDocMessage";
            lblDocMessage.Size = new Size(99, 20);
            lblDocMessage.TabIndex = 36;
            lblDocMessage.Text = "errorMessage";
            lblDocMessage.Visible = false;
            // 
            // lblDocSalaryError
            // 
            lblDocSalaryError.AutoSize = true;
            lblDocSalaryError.ForeColor = Color.Red;
            lblDocSalaryError.Location = new Point(106, 270);
            lblDocSalaryError.Name = "lblDocSalaryError";
            lblDocSalaryError.Size = new Size(99, 20);
            lblDocSalaryError.TabIndex = 35;
            lblDocSalaryError.Text = "errorMessage";
            lblDocSalaryError.Visible = false;
            // 
            // lblDocGenderError
            // 
            lblDocGenderError.AutoSize = true;
            lblDocGenderError.ForeColor = Color.Red;
            lblDocGenderError.Location = new Point(568, 217);
            lblDocGenderError.Name = "lblDocGenderError";
            lblDocGenderError.Size = new Size(99, 20);
            lblDocGenderError.TabIndex = 34;
            lblDocGenderError.Text = "errorMessage";
            lblDocGenderError.Visible = false;
            // 
            // lblDocCountyError
            // 
            lblDocCountyError.AutoSize = true;
            lblDocCountyError.ForeColor = Color.Red;
            lblDocCountyError.Location = new Point(106, 217);
            lblDocCountyError.Name = "lblDocCountyError";
            lblDocCountyError.Size = new Size(99, 20);
            lblDocCountyError.TabIndex = 33;
            lblDocCountyError.Text = "errorMessage";
            lblDocCountyError.Visible = false;
            // 
            // lblDocAddrError
            // 
            lblDocAddrError.AutoSize = true;
            lblDocAddrError.ForeColor = Color.Red;
            lblDocAddrError.Location = new Point(106, 163);
            lblDocAddrError.Name = "lblDocAddrError";
            lblDocAddrError.Size = new Size(99, 20);
            lblDocAddrError.TabIndex = 32;
            lblDocAddrError.Text = "errorMessage";
            lblDocAddrError.Visible = false;
            // 
            // lblDocEmailError
            // 
            lblDocEmailError.AutoSize = true;
            lblDocEmailError.ForeColor = Color.Red;
            lblDocEmailError.Location = new Point(568, 107);
            lblDocEmailError.Name = "lblDocEmailError";
            lblDocEmailError.Size = new Size(99, 20);
            lblDocEmailError.TabIndex = 31;
            lblDocEmailError.Text = "errorMessage";
            lblDocEmailError.Visible = false;
            // 
            // lblDocPhoneError
            // 
            lblDocPhoneError.AutoSize = true;
            lblDocPhoneError.ForeColor = Color.Red;
            lblDocPhoneError.Location = new Point(106, 107);
            lblDocPhoneError.Name = "lblDocPhoneError";
            lblDocPhoneError.Size = new Size(99, 20);
            lblDocPhoneError.TabIndex = 30;
            lblDocPhoneError.Text = "errorMessage";
            lblDocPhoneError.Visible = false;
            // 
            // lblDocLNameError
            // 
            lblDocLNameError.AutoSize = true;
            lblDocLNameError.ForeColor = Color.Red;
            lblDocLNameError.Location = new Point(568, 51);
            lblDocLNameError.Name = "lblDocLNameError";
            lblDocLNameError.Size = new Size(99, 20);
            lblDocLNameError.TabIndex = 29;
            lblDocLNameError.Text = "errorMessage";
            lblDocLNameError.Visible = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.Red;
            label22.Location = new Point(487, 211);
            label22.Name = "label22";
            label22.Size = new Size(0, 20);
            label22.TabIndex = 28;
            // 
            // lblDocFNameError
            // 
            lblDocFNameError.AutoSize = true;
            lblDocFNameError.ForeColor = Color.Red;
            lblDocFNameError.Location = new Point(106, 51);
            lblDocFNameError.Name = "lblDocFNameError";
            lblDocFNameError.Size = new Size(99, 20);
            lblDocFNameError.TabIndex = 27;
            lblDocFNameError.Text = "errorMessage";
            lblDocFNameError.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(528, 326);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 26;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(351, 326);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdateDoctor
            // 
            btnUpdateDoctor.Location = new Point(181, 364);
            btnUpdateDoctor.Name = "btnUpdateDoctor";
            btnUpdateDoctor.Size = new Size(94, 29);
            btnUpdateDoctor.TabIndex = 20;
            btnUpdateDoctor.Text = "Update";
            btnUpdateDoctor.UseVisualStyleBackColor = true;
            btnUpdateDoctor.Click += btnUpdateDoctor_Click;
            // 
            // btnCreateDoctor
            // 
            btnCreateDoctor.Location = new Point(181, 326);
            btnCreateDoctor.Name = "btnCreateDoctor";
            btnCreateDoctor.Size = new Size(94, 29);
            btnCreateDoctor.TabIndex = 19;
            btnCreateDoctor.Text = "Create";
            btnCreateDoctor.UseVisualStyleBackColor = true;
            btnCreateDoctor.Click += btnCreateDoctor_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(516, 80);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 18;
            label9.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(568, 77);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 27);
            txtEmail.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 80);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 16;
            label8.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(106, 77);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(280, 27);
            txtPhone.TabIndex = 15;
            // 
            // dtpDoB
            // 
            dtpDoB.Location = new Point(568, 242);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(327, 27);
            dtpDoB.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(468, 245);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 13;
            label7.Text = "Date of Birth";
            // 
            // cmbCounty
            // 
            cmbCounty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCounty.FormattingEnabled = true;
            cmbCounty.Location = new Point(106, 190);
            cmbCounty.Name = "cmbCounty";
            cmbCounty.Size = new Size(179, 28);
            cmbCounty.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 190);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 11;
            label6.Text = "County";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 136);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 9;
            label5.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(106, 133);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(742, 27);
            txtAddress.TabIndex = 8;
            // 
            // numSalary
            // 
            numSalary.Location = new Point(106, 240);
            numSalary.Name = "numSalary";
            numSalary.Size = new Size(150, 27);
            numSalary.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 242);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "Salary";
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(568, 186);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(179, 28);
            cmbGender.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 190);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 4;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(483, 24);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(568, 21);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(280, 27);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(106, 21);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(280, 27);
            txtFirstName.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(516, 80);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 18;
            label10.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(568, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(280, 27);
            textBox2.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(46, 80);
            label11.Name = "label11";
            label11.Size = new Size(50, 20);
            label11.TabIndex = 16;
            label11.Text = "Phone";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 27);
            textBox1.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(568, 242);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(327, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(468, 245);
            label12.Name = "label12";
            label12.Size = new Size(94, 20);
            label12.TabIndex = 13;
            label12.Text = "Date of Birth";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(45, 190);
            label13.Name = "label13";
            label13.Size = new Size(55, 20);
            label13.TabIndex = 11;
            label13.Text = "County";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(34, 136);
            label14.Name = "label14";
            label14.Size = new Size(62, 20);
            label14.TabIndex = 9;
            label14.Text = "Address";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(106, 133);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(742, 27);
            textBox3.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(106, 240);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(51, 242);
            label15.Name = "label15";
            label15.Size = new Size(49, 20);
            label15.TabIndex = 6;
            label15.Text = "Salary";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(505, 190);
            label16.Name = "label16";
            label16.Size = new Size(57, 20);
            label16.TabIndex = 4;
            label16.Text = "Gender";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(483, 24);
            label17.Name = "label17";
            label17.Size = new Size(79, 20);
            label17.TabIndex = 3;
            label17.Text = "Last Name";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(16, 24);
            label18.Name = "label18";
            label18.Size = new Size(80, 20);
            label18.TabIndex = 2;
            label18.Text = "First Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(568, 21);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(280, 27);
            textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(106, 21);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(280, 27);
            textBox5.TabIndex = 0;
            // 
            // dgvDoctors
            // 
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctors.Dock = DockStyle.Fill;
            dgvDoctors.Location = new Point(0, 0);
            dgvDoctors.MultiSelect = false;
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.ReadOnly = true;
            dgvDoctors.RowHeadersWidth = 51;
            dgvDoctors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoctors.Size = new Size(975, 201);
            dgvDoctors.TabIndex = 0;
            dgvDoctors.CellClick += dgvDoctors_CellClick;
            // 
            // tabNurses
            // 
            tabNurses.Location = new Point(4, 29);
            tabNurses.Name = "tabNurses";
            tabNurses.Padding = new Padding(3);
            tabNurses.Size = new Size(981, 653);
            tabNurses.TabIndex = 1;
            tabNurses.Text = "Nurses";
            tabNurses.UseVisualStyleBackColor = true;
            // 
            // tabPatients
            // 
            tabPatients.Location = new Point(4, 29);
            tabPatients.Name = "tabPatients";
            tabPatients.Padding = new Padding(3);
            tabPatients.Size = new Size(981, 653);
            tabPatients.TabIndex = 2;
            tabPatients.Text = "Patients";
            tabPatients.UseVisualStyleBackColor = true;
            // 
            // tabConsultations
            // 
            tabConsultations.Location = new Point(4, 29);
            tabConsultations.Name = "tabConsultations";
            tabConsultations.Padding = new Padding(3);
            tabConsultations.Size = new Size(981, 653);
            tabConsultations.TabIndex = 3;
            tabConsultations.Text = "Consultations";
            tabConsultations.UseVisualStyleBackColor = true;
            // 
            // tabAdmin
            // 
            tabAdmin.Location = new Point(4, 29);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.Padding = new Padding(3);
            tabAdmin.Size = new Size(981, 653);
            tabAdmin.TabIndex = 4;
            tabAdmin.Text = "Admin";
            tabAdmin.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(46, 80);
            label19.Name = "label19";
            label19.Size = new Size(50, 20);
            label19.TabIndex = 16;
            label19.Text = "Phone";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(106, 77);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(280, 27);
            textBox6.TabIndex = 15;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 714);
            Controls.Add(tabControlMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControlMain.ResumeLayout(false);
            tabDoctors.ResumeLayout(false);
            splitDoctors.Panel1.ResumeLayout(false);
            splitDoctors.Panel1.PerformLayout();
            splitDoctors.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitDoctors).EndInit();
            splitDoctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuDoctors;
        private ToolStripMenuItem menuNurses;
        private ToolStripMenuItem menuPatients;
        private ToolStripMenuItem menuConsultations;
        private TabControl tabControlMain;
        private TabPage tabDoctors;
        private TabPage tabNurses;
        private ToolStripMenuItem adminToolStripMenuItem;
        private TabPage tabPatients;
        private TabPage tabConsultations;
        private TabPage tabAdmin;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private SplitContainer splitDoctors;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private ComboBox cmbCounty;
        private Label label6;
        private Label label5;
        private TextBox txtAddress;
        private NumericUpDown numSalary;
        private Label label4;
        private ComboBox cmbGender;
        private Label label9;
        private TextBox txtEmail;
        private Label label8;
        private TextBox txtPhone;
        private DateTimePicker dtpDoB;
        private Label label7;
        private Button btnDelete;
        private Button btnUpdateDoctor;
        private Button btnCreateDoctor;
        private Label label10;
        private TextBox textBox2;
        private Label label11;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBox3;
        private NumericUpDown numericUpDown1;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label19;
        private TextBox textBox6;
        private Button btnClear;
        private Label lblDocMessage;
        private Label lblDocSalaryError;
        private Label lblDocGenderError;
        private Label lblDocCountyError;
        private Label lblDocAddrError;
        private Label lblDocEmailError;
        private Label lblDocPhoneError;
        private Label lblDocLNameError;
        private Label label22;
        private Label lblDocFNameError;
        private DataGridView dgvDoctors;
        private Button btnListDoctors;
    }
}