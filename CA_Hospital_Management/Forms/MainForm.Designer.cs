using CA_Hospital_Management.UserControls;
using System.Windows.Forms;

namespace CA_Hospital_Management.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

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
            doctorsControl1 = new DoctorsControl();
            tabNurses = new TabPage();
            tabPatients = new TabPage();
            tabConsultations = new TabPage();
            tabAdmin = new TabPage();
            menuStrip1.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabDoctors.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuDoctors, menuNurses, menuPatients, menuConsultations, adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 28);
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
            tabControlMain.Size = new Size(1000, 720);
            tabControlMain.TabIndex = 1;
            // 
            // tabDoctors
            // 
            tabDoctors.Controls.Add(doctorsControl1);
            tabDoctors.Location = new Point(4, 29);
            tabDoctors.Name = "tabDoctors";
            tabDoctors.Padding = new Padding(3);
            tabDoctors.Size = new Size(992, 687);
            tabDoctors.TabIndex = 0;
            tabDoctors.Text = "Doctors";
            tabDoctors.UseVisualStyleBackColor = true;
            // 
            // doctorsControl1
            // 
            doctorsControl1.Dock = DockStyle.Fill;
            doctorsControl1.Location = new Point(3, 3);
            doctorsControl1.Name = "doctorsControl1";
            doctorsControl1.Size = new Size(986, 681);
            doctorsControl1.TabIndex = 0;
            doctorsControl1.Load += doctorsControl1_Load;
            // 
            // tabNurses
            // 
            tabNurses.Location = new Point(4, 29);
            tabNurses.Name = "tabNurses";
            tabNurses.Size = new Size(992, 687);
            tabNurses.TabIndex = 1;
            tabNurses.Text = "Nurses";
            // 
            // tabPatients
            // 
            tabPatients.Location = new Point(4, 29);
            tabPatients.Name = "tabPatients";
            tabPatients.Size = new Size(992, 687);
            tabPatients.TabIndex = 2;
            tabPatients.Text = "Patients";
            // 
            // tabConsultations
            // 
            tabConsultations.Location = new Point(4, 29);
            tabConsultations.Name = "tabConsultations";
            tabConsultations.Size = new Size(992, 687);
            tabConsultations.TabIndex = 3;
            tabConsultations.Text = "Consultations";
            // 
            // tabAdmin
            // 
            tabAdmin.Location = new Point(4, 29);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.Size = new Size(992, 687);
            tabAdmin.TabIndex = 4;
            tabAdmin.Text = "Admin";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 748);
            Controls.Add(tabControlMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Management System";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControlMain.ResumeLayout(false);
            tabDoctors.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuDoctors;
        private ToolStripMenuItem menuNurses;
        private ToolStripMenuItem menuPatients;
        private ToolStripMenuItem menuConsultations;
        private ToolStripMenuItem adminToolStripMenuItem;

        private TabControl tabControlMain;
        private TabPage tabDoctors;
        private TabPage tabNurses;
        private TabPage tabPatients;
        private TabPage tabConsultations;
        private TabPage tabAdmin;
        private DoctorsControl doctorsControl1;
    }
}
