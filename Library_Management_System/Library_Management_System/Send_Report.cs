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
    public partial class Send_Report : Form
    {
        public Send_Report()
        {
            InitializeComponent();
        }

        private void lnkAttachment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtTo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter email ID!");
                return; // return because we don't want to run normal code of buton click
            }
            using (MailMessage mm = new MailMessage("rahulmtr689@gmail.com", txtTo.Text.Trim()))
            {
                mm.Subject = txtSubject.Text;
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
                   
                    txtSubject.Text = "";
                   
                }
               
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            foreach (string filePath in openFileDialog1.FileNames)
            {
                if (File.Exists(filePath))
                {
                    string fileName = Path.GetFileName(filePath);
                    lblAttachments.Text += fileName + Environment.NewLine;
                }
            }
        }
    }
}
