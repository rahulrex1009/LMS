namespace Library_Management_System
{
    partial class mdi_admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdi_admin));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooksInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBooksInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentsInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksRetainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalBooksReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendReportViaEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.FloralWhite;
            this.menuStrip.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.issuedBooksToolStripMenuItem,
            this.returnBooksToolStripMenuItem,
            this.bookStocksToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1920, 32);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBooksToolStripMenuItem,
            this.viewBooksInfoToolStripMenuItem,
            this.manageBooksInfoToolStripMenuItem});
            this.booksToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(82, 28);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // addNewBooksToolStripMenuItem
            // 
            this.addNewBooksToolStripMenuItem.Name = "addNewBooksToolStripMenuItem";
            this.addNewBooksToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.addNewBooksToolStripMenuItem.Text = "Add New Books";
            this.addNewBooksToolStripMenuItem.Click += new System.EventHandler(this.addNewBooksToolStripMenuItem_Click);
            // 
            // viewBooksInfoToolStripMenuItem
            // 
            this.viewBooksInfoToolStripMenuItem.Name = "viewBooksInfoToolStripMenuItem";
            this.viewBooksInfoToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.viewBooksInfoToolStripMenuItem.Text = "View Books Info";
            this.viewBooksInfoToolStripMenuItem.Click += new System.EventHandler(this.viewBooksInfoToolStripMenuItem_Click);
            // 
            // manageBooksInfoToolStripMenuItem
            // 
            this.manageBooksInfoToolStripMenuItem.Name = "manageBooksInfoToolStripMenuItem";
            this.manageBooksInfoToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.manageBooksInfoToolStripMenuItem.Text = "Manage Books Info";
            this.manageBooksInfoToolStripMenuItem.Click += new System.EventHandler(this.manageBooksInfoToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerNewStudentToolStripMenuItem,
            this.viewStudentInfoToolStripMenuItem,
            this.manageStudentsInfoToolStripMenuItem});
            this.studentsToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(109, 28);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // registerNewStudentToolStripMenuItem
            // 
            this.registerNewStudentToolStripMenuItem.Name = "registerNewStudentToolStripMenuItem";
            this.registerNewStudentToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.registerNewStudentToolStripMenuItem.Text = "Register New Student";
            this.registerNewStudentToolStripMenuItem.Click += new System.EventHandler(this.registerNewStudentToolStripMenuItem_Click);
            // 
            // viewStudentInfoToolStripMenuItem
            // 
            this.viewStudentInfoToolStripMenuItem.Name = "viewStudentInfoToolStripMenuItem";
            this.viewStudentInfoToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.viewStudentInfoToolStripMenuItem.Text = "View Student Info";
            this.viewStudentInfoToolStripMenuItem.Click += new System.EventHandler(this.viewStudentInfoToolStripMenuItem_Click);
            // 
            // manageStudentsInfoToolStripMenuItem
            // 
            this.manageStudentsInfoToolStripMenuItem.Name = "manageStudentsInfoToolStripMenuItem";
            this.manageStudentsInfoToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.manageStudentsInfoToolStripMenuItem.Text = "Manage Students Info";
            this.manageStudentsInfoToolStripMenuItem.Click += new System.EventHandler(this.manageStudentsInfoToolStripMenuItem_Click);
            // 
            // issuedBooksToolStripMenuItem
            // 
            this.issuedBooksToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedBooksToolStripMenuItem.Name = "issuedBooksToolStripMenuItem";
            this.issuedBooksToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.issuedBooksToolStripMenuItem.Text = "Issued Books";
            this.issuedBooksToolStripMenuItem.Click += new System.EventHandler(this.issuedBooksToolStripMenuItem_Click);
            // 
            // returnBooksToolStripMenuItem
            // 
            this.returnBooksToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            this.returnBooksToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.returnBooksToolStripMenuItem.Text = "Return Books";
            this.returnBooksToolStripMenuItem.Click += new System.EventHandler(this.returnBooksToolStripMenuItem_Click);
            // 
            // bookStocksToolStripMenuItem
            // 
            this.bookStocksToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookStocksToolStripMenuItem.Name = "bookStocksToolStripMenuItem";
            this.bookStocksToolStripMenuItem.Size = new System.Drawing.Size(142, 28);
            this.bookStocksToolStripMenuItem.Text = "Book Stocks";
            this.bookStocksToolStripMenuItem.Click += new System.EventHandler(this.bookStocksToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksRetainingToolStripMenuItem,
            this.studentsReportToolStripMenuItem,
            this.totalBooksReportToolStripMenuItem,
            this.sendReportViaEmailToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(99, 28);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // booksRetainingToolStripMenuItem
            // 
            this.booksRetainingToolStripMenuItem.Name = "booksRetainingToolStripMenuItem";
            this.booksRetainingToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.booksRetainingToolStripMenuItem.Text = "Books Retaining";
            this.booksRetainingToolStripMenuItem.Click += new System.EventHandler(this.booksRetainingToolStripMenuItem_Click);
            // 
            // studentsReportToolStripMenuItem
            // 
            this.studentsReportToolStripMenuItem.Name = "studentsReportToolStripMenuItem";
            this.studentsReportToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.studentsReportToolStripMenuItem.Text = "Students Report";
            this.studentsReportToolStripMenuItem.Click += new System.EventHandler(this.studentsReportToolStripMenuItem_Click);
            // 
            // totalBooksReportToolStripMenuItem
            // 
            this.totalBooksReportToolStripMenuItem.Name = "totalBooksReportToolStripMenuItem";
            this.totalBooksReportToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.totalBooksReportToolStripMenuItem.Text = "Total Books Report";
            this.totalBooksReportToolStripMenuItem.Click += new System.EventHandler(this.totalBooksReportToolStripMenuItem_Click);
            // 
            // sendReportViaEmailToolStripMenuItem
            // 
            this.sendReportViaEmailToolStripMenuItem.Name = "sendReportViaEmailToolStripMenuItem";
            this.sendReportViaEmailToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.sendReportViaEmailToolStripMenuItem.Text = "Send Report via email";
            this.sendReportViaEmailToolStripMenuItem.Click += new System.EventHandler(this.sendReportViaEmailToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactDeveloperToolStripMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 28);
            this.settingsToolStripMenuItem.Text = "Feedback";
            // 
            // contactDeveloperToolStripMenuItem
            // 
            this.contactDeveloperToolStripMenuItem.Name = "contactDeveloperToolStripMenuItem";
            this.contactDeveloperToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.contactDeveloperToolStripMenuItem.Text = "Contact Developer";
            this.contactDeveloperToolStripMenuItem.Click += new System.EventHandler(this.contactDeveloperToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(82, 28);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 1026);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1920, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(207, 20);
            this.toolStripStatusLabel.Text = "Developed By Mr. Rahul Mitra";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(597, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME TO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1044, 68);
            this.label2.TabIndex = 5;
            this.label2.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // mdi_admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mdi_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBooksInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBooksInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentsInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuedBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksRetainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalBooksReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendReportViaEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactDeveloperToolStripMenuItem;
    }
}



