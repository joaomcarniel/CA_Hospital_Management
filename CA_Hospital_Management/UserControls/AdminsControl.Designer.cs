namespace CA_Hospital_Management.UserControls
{
    partial class AdminsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            btnUpdatePass = new Button();
            label4 = new Label();
            btnDelete = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            lblPagination = new Label();
            btnNext = new Button();
            btnPrev = new Button();
            lblMessage = new Label();
            lblError = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            mainDgv = new DataGridView();
            cmbActive = new ComboBox();
            cmbRole = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainDgv).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(cmbRole);
            splitContainer1.Panel1.Controls.Add(cmbActive);
            splitContainer1.Panel1.Controls.Add(btnUpdatePass);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(btnDelete);
            splitContainer1.Panel1.Controls.Add(btnCreate);
            splitContainer1.Panel1.Controls.Add(btnUpdate);
            splitContainer1.Panel1.Controls.Add(lblPagination);
            splitContainer1.Panel1.Controls.Add(btnNext);
            splitContainer1.Panel1.Controls.Add(btnPrev);
            splitContainer1.Panel1.Controls.Add(lblMessage);
            splitContainer1.Panel1.Controls.Add(lblError);
            splitContainer1.Panel1.Controls.Add(txtPassword);
            splitContainer1.Panel1.Controls.Add(txtUsername);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(mainDgv);
            splitContainer1.Size = new Size(1238, 787);
            splitContainer1.SplitterDistance = 610;
            splitContainer1.TabIndex = 0;
            // 
            // btnUpdatePass
            // 
            btnUpdatePass.BackColor = Color.Lime;
            btnUpdatePass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdatePass.ForeColor = Color.White;
            btnUpdatePass.Location = new Point(276, 505);
            btnUpdatePass.Name = "btnUpdatePass";
            btnUpdatePass.Size = new Size(150, 40);
            btnUpdatePass.TabIndex = 61;
            btnUpdatePass.Text = "Update Password";
            btnUpdatePass.UseVisualStyleBackColor = false;
            btnUpdatePass.Click += btnUpdatePass_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 388);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 59;
            label4.Text = "Active";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(437, 505);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 40);
            btnDelete.TabIndex = 58;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.MenuHighlight;
            btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(70, 505);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(92, 40);
            btnCreate.TabIndex = 57;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Lime;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(173, 505);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 40);
            btnUpdate.TabIndex = 56;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblPagination
            // 
            lblPagination.ForeColor = Color.Black;
            lblPagination.Location = new Point(169, 594);
            lblPagination.Name = "lblPagination";
            lblPagination.Size = new Size(256, 23);
            lblPagination.TabIndex = 55;
            lblPagination.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.MenuHighlight;
            btnNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(431, 585);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(92, 40);
            btnNext.TabIndex = 54;
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
            btnPrev.Location = new Point(71, 585);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(92, 40);
            btnPrev.TabIndex = 53;
            btnPrev.Text = "Privious";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // lblMessage
            // 
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(48, 554);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(497, 23);
            lblMessage.TabIndex = 52;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.Visible = false;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(251, 475);
            lblError.Name = "lblError";
            lblError.Size = new Size(65, 20);
            lblError.TabIndex = 48;
            lblError.Text = "              ";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(251, 342);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(166, 27);
            txtPassword.TabIndex = 46;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(251, 300);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(166, 27);
            txtUsername.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 431);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 44;
            label3.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 346);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 43;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 303);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 42;
            label1.Text = "Username";
            // 
            // mainDgv
            // 
            mainDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainDgv.Dock = DockStyle.Fill;
            mainDgv.Location = new Point(0, 0);
            mainDgv.Name = "mainDgv";
            mainDgv.RowHeadersWidth = 51;
            mainDgv.Size = new Size(624, 787);
            mainDgv.TabIndex = 0;
            mainDgv.CellClick += mainDgv_CellClick;
            // 
            // cmbActive
            // 
            cmbActive.BackColor = Color.FromArgb(255, 224, 192);
            cmbActive.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActive.Location = new Point(251, 388);
            cmbActive.Name = "cmbActive";
            cmbActive.Size = new Size(166, 28);
            cmbActive.TabIndex = 62;
            // 
            // cmbRole
            // 
            cmbRole.BackColor = Color.FromArgb(255, 224, 192);
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Location = new Point(251, 431);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(166, 28);
            cmbRole.TabIndex = 63;
            // 
            // AdminsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "AdminsControl";
            Size = new Size(1238, 787);
            Load += AdminsControl_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lblPagination;
        private Button btnNext;
        private Button btnPrev;
        private Label lblMessage;
        private Label lblError;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView mainDgv;
        private Button btnUpdate;
        private Button btnCreate;
        private Button btnDelete;
        private Label label4;
        private Button btnUpdatePass;
        private ComboBox cmbRole;
        private ComboBox cmbActive;
    }
}
