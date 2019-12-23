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

    public partial class Issue_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-29MAECMT\MSSQLSERVER2016;Initial Catalog=Library_mgmt_system1;Integrated Security=True");
        public Issue_books()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i=0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student_info where LibCardNo='"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                MessageBox.Show("Record not found");

            }

            else
            {

                foreach (DataRow dr in dt.Rows)
                {
                    txt_enrollmentno.Text = dr["EnrollmentNo"].ToString();
                    txt_sname.Text = dr["Name"].ToString();
                    txt_semail.Text = dr["Email"].ToString();
                    txt_scourse.Text = dr["Course"].ToString();
                    txt_sclass.Text = dr["Class"].ToString();
                    txt_srollNo.Text = dr["RollNo"].ToString();
                    txt_libcardNo.Text = dr["LibCardNo"].ToString();


                }
            }
            textBox1.Text = "";
        }

        private void Issue_books_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();
        }







        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void searchBooksbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void issueBtn_Click(object sender, EventArgs e)
        {

            int books_qty = 0;
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from books_info where Book_Name='"+ txt_bookname.Text +"'";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach(DataRow dr2 in dt2.Rows)
            {
                books_qty = Convert.ToInt32(dr2["Available_qty"].ToString());
            }

            if (books_qty > 0)
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into issue_books values('" + txt_enrollmentno.Text + "','" + txt_sname.Text + "','" + txt_semail.Text + "','" + txt_scourse.Text + "','" + txt_sclass.Text + "','" + txt_srollNo.Text + "','" + txt_libcardNo.Text + "','" + dateTimePicker1_bookissuedate.Text + "','" + txt_bookname.Text + "','" + txt_bookIsbnNo.Text + "','"+ dateTimePicker1_dueDate.Text+"','')";
                cmd.ExecuteNonQuery();


                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update books_info set Available_qty=Available_qty-1 where Book_Name='" + txt_bookname.Text + "'";   //not the book searchbox but the textbox in which the name of the book gets displayed.
                cmd1.ExecuteNonQuery();


                MessageBox.Show("Book Issued Successfully");

                txt_enrollmentno.Text = "";
                txt_sname.Text = "";
                txt_semail.Text = "";
                txt_scourse.Text = "";
                txt_sclass.Text = "";
                txt_srollNo.Text = "";
                
                txt_libcardNo.Text = "";
                txt_bookIsbnNo.Text = "";
                txt_bookname.Text = "";

                book_isbnno.Text = "";
                book_name.Text = "";
                book_author.Text = "";
                book_publication.Text = "";
                book_category.Text = "";
                book_description.Text = "";
                book_shelf.Text = "";

            }
            else
            {
                MessageBox.Show("Book Not Available");
            }
        }

        private void searchBtn1_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select * from books_info where Book_Name like('%" + textBox2.Text + "%')";
            cmd3.ExecuteNonQuery();

            if (textBox2.Text == "")
            {
                MessageBox.Show("Enter Book Name Please");
                textBox2.Text = "";
            }

            else if(textBox2.Text==" ")
            {
                MessageBox.Show("Space Not Allowed. Enter Book Name");
                textBox2.Text = "";
            }
            else
            { 

            

                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd3);
                da1.Fill(dt1);
                i = Convert.ToInt32(dt1.Rows.Count.ToString());


                if (i == 0)
                {
                    MessageBox.Show("Record not found");

                }
                else
                {
                    foreach (DataRow dr in dt1.Rows)
                    {
                        txt_bookname.Text = dr["Book_Name"].ToString();
                        txt_bookIsbnNo.Text = dr["ISBN_number"].ToString();

                        book_isbnno.Text = dr["ISBN_number"].ToString();
                        book_name.Text = dr["Book_Name"].ToString();
                        book_author.Text = dr["Book_Author"].ToString();
                        book_publication.Text = dr["Book_Publication"].ToString();
                        book_category.Text = dr["Book_Category"].ToString();
                        book_description.Text = dr["Description"].ToString();
                        book_shelf.Text = dr["Book_Shelf"].ToString();
                    }
                }
            }
            textBox2.Text = "";
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
