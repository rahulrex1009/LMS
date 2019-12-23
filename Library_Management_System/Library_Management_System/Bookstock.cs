using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace Library_Management_System
{
    public partial class Bookstock : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-29MAECMT\MSSQLSERVER2016;Initial Catalog=Library_mgmt_system1;Integrated Security=True");
        public Bookstock()
        {
            InitializeComponent();
        }

        private void Bookstock_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            fill_grid();
        }


        public void fill_grid()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Book_Name,Book_Author,Book_Publication,Book_Quantity,Available_qty,Book_Category from books_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string i;
            i = dataGridView1.SelectedCells[0].Value.ToString();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from issue_books where Book_Name='"+ i.ToString()+"' and Book_Return_Date=''";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;


        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Book_Name,Book_Author,Book_Publication,Book_Quantity,Available_qty,Book_Category from books_info where Book_Name like('%"+ txt_search.Text +"%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string i;
            
                i = dataGridView2.SelectedCells[3].Value.ToString();

                txt_email.Text = i.ToString();

                i = dataGridView2.SelectedCells[0].Value.ToString();
                lb_id.Text = i.ToString();


                i = dataGridView2.SelectedCells[11].Value.ToString();
                dateTimePicker1_due.Text = i.ToString();
            
        }

        private void sendEmailBtn_Click(object sender, EventArgs e)
        {
            try
            {


                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                //(username,password)
                smtp.Credentials = new NetworkCredential("rahulmtr689@gmail.com", "9702763522lol");
                //(from,to,subject,body)
                MailMessage mail = new MailMessage("rahulmtr689@gmail.com", txt_email.Text, "This is a notice for returning the book", txt_content.Text);
                mail.Priority = MailPriority.High;
                DialogResult res = MessageBox.Show("Do You Want To Send Mail?", "Confirmation", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    smtp.Send(mail);
                    MessageBox.Show("Mail sent");
                    txt_content.Text = "";
                    txt_email.Text = "";

                }
                else if(res==DialogResult.No)
                {
                    dateTimePicker1_due.Text = "";
                    txt_content.Text = "";
                    txt_email.Text = "";
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void saveDueBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "update issue_books set Book_Due_date ='" + dateTimePicker1_due.Value.ToLongDateString() + "' where Id=" +lb_id.Text+ " ";

             DialogResult res = MessageBox.Show("Do You Want To update Due Date?", "Confirmation", MessageBoxButtons.YesNo);
             if (res == DialogResult.Yes)
             {
                 cmd1.ExecuteNonQuery();
                 MessageBox.Show("Due Date updated Successfully");
             }
             else if(res==DialogResult.No)
                {
                    dateTimePicker1_due.Text = "";
                   
                }

        }

    }
}
