namespace Library_Management_System
{
    partial class Books_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books_Report));
            this.crystalReportViewerAllBooks = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.genReportB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewerAllBooks
            // 
            this.crystalReportViewerAllBooks.ActiveViewIndex = -1;
            this.crystalReportViewerAllBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerAllBooks.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerAllBooks.Location = new System.Drawing.Point(27, 101);
            this.crystalReportViewerAllBooks.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewerAllBooks.Name = "crystalReportViewerAllBooks";
            this.crystalReportViewerAllBooks.Size = new System.Drawing.Size(1737, 749);
            this.crystalReportViewerAllBooks.TabIndex = 0;
            this.crystalReportViewerAllBooks.ToolPanelWidth = 267;
            // 
            // genReportB
            // 
            this.genReportB.BackColor = System.Drawing.SystemColors.Info;
            this.genReportB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genReportB.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.genReportB.Location = new System.Drawing.Point(27, 41);
            this.genReportB.Margin = new System.Windows.Forms.Padding(4);
            this.genReportB.Name = "genReportB";
            this.genReportB.Size = new System.Drawing.Size(368, 52);
            this.genReportB.TabIndex = 1;
            this.genReportB.Text = "Generate Report For Books";
            this.genReportB.UseVisualStyleBackColor = false;
            this.genReportB.Click += new System.EventHandler(this.genReportB_Click);
            // 
            // Books_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1813, 908);
            this.Controls.Add(this.genReportB);
            this.Controls.Add(this.crystalReportViewerAllBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Books_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books_Report";
            this.Load += new System.EventHandler(this.Books_Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerAllBooks;
        private System.Windows.Forms.Button genReportB;
    }
}