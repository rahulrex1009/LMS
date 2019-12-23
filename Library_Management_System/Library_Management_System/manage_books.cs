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
    public partial class manage_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-29MAECMT\MSSQLSERVER2016;Initial Catalog=Library_mgmt_system1;Integrated Security=True");
        public manage_books()
        {
            InitializeComponent();
        }

        public void resetBtn()
        {
            Booknametxt.Text = "";
            
            booknumbertxt.Text = "";
            Bookpagestxt.Text = "";
            BookPricetxt.Text = "";
            BookPublicationtxt.Text = "";
            BookDescriptiontxt.Text = "";
            BookPurchaseDtptxt.Text = "";
            BookQuantitytxt.Text = "";
            Bookshelftxt.Text = "";
            BookAuthortxt.Text = "";
            comboBox_category.Text = "";
            ISBNnotxt.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manage_books_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            disp_books();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where Book_Name like('%" + textBox1.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                i = Convert.ToInt32(dt.Rows.Count.ToString());

                dataGridView1.DataSource = dt;

               

                if (i == 0)
                {
                    MessageBox.Show("No Books Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where Book_Author like('%" + textBox2.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                i = Convert.ToInt32(dt.Rows.Count.ToString());

                dataGridView1.DataSource = dt;

                

                if (i == 0)
                {
                    MessageBox.Show("No Books Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where Book_Category like('%" + textBox3.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                i = Convert.ToInt32(dt.Rows.Count.ToString());

                dataGridView1.DataSource = dt;

                

                if (i == 0)
                {
                    MessageBox.Show("No Books Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open(); 
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                resetBtn();



            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());       //for providing input by clicking the rows (i)

            try
            {
              
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where BookId="+i+" ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
               
                foreach(DataRow dr in dt.Rows)                                  //for iterating the retrieved values through the textboxes
                {
                    ISBNnotxt.Text = dr["ISBN_number"].ToString();
                     booknumbertxt.Text=dr["Book_No"].ToString();
                    Booknametxt.Text=dr["Book_Name"].ToString();
                    BookAuthortxt.Text=dr["Book_Author"].ToString();
                    BookPublicationtxt.Text=dr["Book_Publication"].ToString();
                    BookPricetxt.Text=dr["Book_Price"].ToString();
                    BookQuantitytxt.Text=dr["Book_Quantity"].ToString();
                    BookPurchaseDtptxt.Value=Convert.ToDateTime(dr["Books_Purchase_Date"].ToString());
                    Bookpagestxt.Text=dr["Books_Pages"].ToString();
                    BookDescriptiontxt.Text=dr["Description"].ToString();
                    comboBox_category.Text=dr["Book_Category"].ToString();
                    Bookshelftxt.Text=dr["Book_Shelf"].ToString();
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                if (Booknametxt.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please enter student name!");
                    return; // return because we don't want to run normal code of buton click
                }

               

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update books_info set ISBN_number='"+ISBNnotxt.Text+"',Book_No='"+booknumbertxt.Text+"',Book_Name='"+Booknametxt.Text+"',Book_Author='"+BookAuthortxt.Text+"',Book_Publication='"+BookPublicationtxt.Text+"',Book_Price="+BookPricetxt.Text+",Book_Quantity="+BookQuantitytxt.Text+",Available_qty="+ BookQuantitytxt.Text +",Books_Purchase_Date='"+BookPurchaseDtptxt.Value.ToShortDateString()+"',Books_Pages="+Bookpagestxt.Text+",Description='"+BookDescriptiontxt.Text+"',Book_Category='"+ comboBox_category.Text + "',Book_Shelf='"+Bookshelftxt.Text+"'where BookId="+i+"";
                DialogResult result = MessageBox.Show("Are You Sure You Want to Edit the book?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();

                    disp_books();
                    MessageBox.Show("Record Updated Successfully");
                    resetBtn();
                }
                else if (result == DialogResult.No)
                {
                    resetBtn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void disp_books()
        {
            try
            {
               
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();                 // a function is created for displaying the book records in the datagridview;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (Booknametxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select student record!");
                return; // return because we don't want to run normal code of buton click
            }

            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

           
            try
            {
              
                SqlCommand del = con.CreateCommand();
                del.CommandType = CommandType.Text;
                del.CommandText = "delete from books_info where BookId=" + i + "";
                DialogResult result = MessageBox.Show("Are You Sure You Want to delete the book?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    del.ExecuteNonQuery();
                    
                    disp_books();
                    MessageBox.Show("Record deleted Successfully");
                    resetBtn();
                }
                else if (result == DialogResult.No)
                {
                    resetBtn();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
