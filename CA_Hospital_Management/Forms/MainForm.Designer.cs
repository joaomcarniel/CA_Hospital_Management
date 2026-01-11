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
            button1 = new Button();
            tabNurses = new TabPage();
            label1 = new Label();
            tabPatients = new TabPage();
            tabConsultations = new TabPage();
            tabAdmin = new TabPage();
            menuStrip1.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabDoctors.SuspendLayout();
            tabNurses.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuDoctors, menuNurses, menuPatients, menuConsultations, adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
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
            tabControlMain.Size = new Size(800, 422);
            tabControlMain.TabIndex = 1;
            // 
            // tabDoctors
            // 
            tabDoctors.Controls.Add(button1);
            tabDoctors.Location = new Point(4, 29);
            tabDoctors.Name = "tabDoctors";
            tabDoctors.Padding = new Padding(3);
            tabDoctors.Size = new Size(792, 389);
            tabDoctors.TabIndex = 0;
            tabDoctors.Text = "Doctors";
            tabDoctors.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(308, 148);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabNurses
            // 
            tabNurses.Controls.Add(label1);
            tabNurses.Location = new Point(4, 29);
            tabNurses.Name = "tabNurses";
            tabNurses.Padding = new Padding(3);
            tabNurses.Size = new Size(792, 389);
            tabNurses.TabIndex = 1;
            tabNurses.Text = "Nurses";
            tabNurses.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 288);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // tabPatients
            // 
            tabPatients.Location = new Point(4, 29);
            tabPatients.Name = "tabPatients";
            tabPatients.Padding = new Padding(3);
            tabPatients.Size = new Size(792, 389);
            tabPatients.TabIndex = 2;
            tabPatients.Text = "Patients";
            tabPatients.UseVisualStyleBackColor = true;
            // 
            // tabConsultations
            // 
            tabConsultations.Location = new Point(4, 29);
            tabConsultations.Name = "tabConsultations";
            tabConsultations.Padding = new Padding(3);
            tabConsultations.Size = new Size(792, 389);
            tabConsultations.TabIndex = 3;
            tabConsultations.Text = "Consultations";
            tabConsultations.UseVisualStyleBackColor = true;
            // 
            // tabAdmin
            // 
            tabAdmin.Location = new Point(4, 29);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.Padding = new Padding(3);
            tabAdmin.Size = new Size(792, 389);
            tabAdmin.TabIndex = 4;
            tabAdmin.Text = "Admin";
            tabAdmin.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControlMain.ResumeLayout(false);
            tabDoctors.ResumeLayout(false);
            tabNurses.ResumeLayout(false);
            tabNurses.PerformLayout();
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
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
    }
}