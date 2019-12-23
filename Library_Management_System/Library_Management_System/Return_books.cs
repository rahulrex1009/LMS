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

namespace Library_Management_System
{
    public partial class Return_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-29MAECMT\MSSQLSERVER2016;Initial Catalog=Library_mgmt_system1;Integrated Security=True");
        public Return_books()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            int i=0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from issue_books where Student_LibraryCardNo='" + textBox1.Text + "' and Book_Return_Date=' '";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                MessageBox.Show("This library card is not found");
            }
            else
            {


                dataGridView1.DataSource = dt;

            }

            //fill_grid(textBox1.Text);
        }

        private void Return_books_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();
        }
        public void fill_grid(string libcardno)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from issue_books where Student_LibraryCardNo='"+ libcardno.ToString() +"' and Book_Return_Date=' '";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                bookName_txt.Text = row.Cells["Book_Name"].Value.ToString();
                issueDate_txt.Text = row.Cells["Book_Issue_Date"].Value.ToString();
                txt_dueDate.Text= row.Cells["Book_Due_date"].Value.ToString();
            }

          

            DateTime due = DateTime.Parse(txt_dueDate.Text);
            DateTime ret = DateTime.Parse(dateTimePicker1.Text);
            int diff = (ret.Date - due.Date).Days;
            int fine = diff * 10;
            lb_fine.Visible = true;
            lb_fine.Text = fine.ToString();
            //txt_fine.Text = fine.ToString();
        }

        private void retrnBook_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update issue_books set Book_Return_Date='"+ dateTimePicker1.Value.ToShortDateString() +"' where Id="+i+"";

               cmd.ExecuteNonQuery();

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update books_info set Available_qty=Available_qty+1 where Book_Name='" + bookName_txt.Text + "'";
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Book Returned Successfully");

                fill_grid(textBox1.Text);
            

           
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fineBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bookstock bs = new Bookstock();
            bs.Show();
        }
        }
    }

