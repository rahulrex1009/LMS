using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace Library_Management_System
{
    public partial class Report_problem : Form
    {
        public Report_problem()
        {
            InitializeComponent();
        }

        private void linkattachment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {

            if (txtBody.Text.Trim() == string.Empty)
            {
                MessageBox.Show("No Content TO send!");
                return; // return because we don't want to run normal code of buton click
            }
            using (MailMessage mm = new MailMessage("rahulmtr689@gmail.com", "rahul.mitra685@gmail.com"))
            {
                mm.Subject = "This is with regards to s/w problems in the system";
                mm.Body = txtBody.Text;
                foreach (string filePath in openFileDialog1.FileNames)
                {
                    if (File.Exists(filePath))
                    {
                        string fileName = Path.GetFileName(filePath);
                        mm.Attachments.Add(new Attachment(filePath));
                    }
                }
                mm.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential("rahulmtr689@gmail.com", "9702763522lol");
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                DialogResult res = MessageBox.Show("Do You Want To Send Mail?", "Confirmation", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    smtp.Send(mm);
                    MessageBox.Show("Email sent.", "Message");

                }
                else if (res == DialogResult.No)
                {
                    txtBody.Text = "";
                    
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Send_Report ssr = new Send_Report();
            ssr.Show();
        }
    }
}
