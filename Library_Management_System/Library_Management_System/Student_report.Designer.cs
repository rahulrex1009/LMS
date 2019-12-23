namespace Library_Management_System
{
    partial class Student_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_report));
            this.crystalReportViewerSt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.genReportSt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewerSt
            // 
            this.crystalReportViewerSt.ActiveViewIndex = -1;
            this.crystalReportViewerSt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crystalReportViewerSt.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerSt.Location = new System.Drawing.Point(48, 110);
            this.crystalReportViewerSt.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewerSt.Name = "crystalReportViewerSt";
            this.crystalReportViewerSt.Size = new System.Drawing.Size(1820, 877);
            this.crystalReportViewerSt.TabIndex = 0;
            this.crystalReportViewerSt.ToolPanelWidth = 267;
            // 
            // genReportSt
            // 
            this.genReportSt.BackColor = System.Drawing.SystemColors.Info;
            this.genReportSt.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genReportSt.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.genReportSt.Location = new System.Drawing.Point(48, 46);
            this.genReportSt.Margin = new System.Windows.Forms.Padding(4);
            this.genReportSt.Name = "genReportSt";
            this.genReportSt.Size = new System.Drawing.Size(414, 46);
            this.genReportSt.TabIndex = 1;
            this.genReportSt.Text = "Generate list of Registered Student Report";
            this.genReportSt.UseVisualStyleBackColor = false;
            this.genReportSt.Click += new System.EventHandler(this.genReportSt_Click);
            // 
            // Student_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1913, 1048);
            this.Controls.Add(this.genReportSt);
            this.Controls.Add(this.crystalReportViewerSt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Student_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_report";
            this.Load += new System.EventHandler(this.Student_report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerSt;
        private System.Windows.Forms.Button genReportSt;
    }
}