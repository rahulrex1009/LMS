namespace Library_Management_System
{
    partial class Course_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Course_Info));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_courseName = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.listCourses = new System.Windows.Forms.ListBox();
            this.del_Btn = new System.Windows.Forms.Button();
            this.arrowup_Btn = new System.Windows.Forms.Button();
            this.arrowdown_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_courseId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course :";
            // 
            // txt_courseName
            // 
            this.txt_courseName.Location = new System.Drawing.Point(147, 71);
            this.txt_courseName.Name = "txt_courseName";
            this.txt_courseName.Size = new System.Drawing.Size(234, 20);
            this.txt_courseName.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(189, 168);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(114, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(341, 542);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(115, 23);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // listCourses
            // 
            this.listCourses.FormattingEnabled = true;
            this.listCourses.Location = new System.Drawing.Point(60, 197);
            this.listCourses.Name = "listCourses";
            this.listCourses.Size = new System.Drawing.Size(368, 329);
            this.listCourses.TabIndex = 4;
            this.listCourses.Click += new System.EventHandler(this.listCourses_Click);
            this.listCourses.SelectedIndexChanged += new System.EventHandler(this.listCourses_SelectedIndexChanged);
            // 
            // del_Btn
            // 
            this.del_Btn.Location = new System.Drawing.Point(189, 542);
            this.del_Btn.Name = "del_Btn";
            this.del_Btn.Size = new System.Drawing.Size(114, 23);
            this.del_Btn.TabIndex = 5;
            this.del_Btn.Text = "DELETE";
            this.del_Btn.UseVisualStyleBackColor = true;
            this.del_Btn.Click += new System.EventHandler(this.del_Btn_Click);
            // 
            // arrowup_Btn
            // 
            this.arrowup_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrowup_Btn.BackgroundImage")));
            this.arrowup_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arrowup_Btn.Location = new System.Drawing.Point(447, 269);
            this.arrowup_Btn.Name = "arrowup_Btn";
            this.arrowup_Btn.Size = new System.Drawing.Size(57, 64);
            this.arrowup_Btn.TabIndex = 6;
            this.arrowup_Btn.UseVisualStyleBackColor = true;
            // 
            // arrowdown_Btn
            // 
            this.arrowdown_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arrowdown_Btn.BackgroundImage")));
            this.arrowdown_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arrowdown_Btn.Location = new System.Drawing.Point(447, 374);
            this.arrowdown_Btn.Name = "arrowdown_Btn";
            this.arrowdown_Btn.Size = new System.Drawing.Size(57, 61);
            this.arrowdown_Btn.TabIndex = 7;
            this.arrowdown_Btn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Description :";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(147, 111);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(234, 47);
            this.txt_Description.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Course ID";
            // 
            // lb_courseId
            // 
            this.lb_courseId.AutoSize = true;
            this.lb_courseId.Location = new System.Drawing.Point(147, 33);
            this.lb_courseId.Name = "lb_courseId";
            this.lb_courseId.Size = new System.Drawing.Size(0, 13);
            this.lb_courseId.TabIndex = 11;
            // 
            // Course_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 577);
            this.Controls.Add(this.lb_courseId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arrowdown_Btn);
            this.Controls.Add(this.arrowup_Btn);
            this.Controls.Add(this.del_Btn);
            this.Controls.Add(this.listCourses);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.txt_courseName);
            this.Controls.Add(this.label1);
            this.Name = "Course_Info";
            this.Text = "Course_Info";
            this.Load += new System.EventHandler(this.Course_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_courseName;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.ListBox listCourses;
        private System.Windows.Forms.Button del_Btn;
        private System.Windows.Forms.Button arrowup_Btn;
        private System.Windows.Forms.Button arrowdown_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_courseId;
    }
}