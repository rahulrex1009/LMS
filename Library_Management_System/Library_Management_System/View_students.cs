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
    public partial class View_students : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-29MAECMT\MSSQLSERVER2016;Initial Catalog=Library_mgmt_system1;Integrated Security=True");
        public View_students()
        {
            InitializeComponent();
        }

        private void searchbtn1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                int i = 0;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student_info where EnrollmentNo like('%" + textBox1.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                Bitmap img;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.Width = 100;
                imageCol.HeaderText = "student image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

                dataGridView1.Columns.Add(imageCol);

                foreach (DataRow dr in dt.Rows)
                {
                    img = new Bitmap(@"..\..\" + dr["Image"].ToString());  //image is name of column in database.
                    dataGridView1.Rows[i].Cells[14].Value = img;    //13=position of the colum that displays the images. 13 becuz columns in db is 12 in total
                    dataGridView1.Rows[i].Height = 100;
                    i = i + 1;
                }
                textBox1.Text = "";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

          //this is button1 search event

        }

        private void View_students_Load(object sender, EventArgs e)
        {
            int i = 0;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            Bitmap img;                                                         
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            imageCol.Width = 100;
            imageCol.HeaderText = "student image";
            imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;                
     
            dataGridView1.Columns.Add(imageCol);

            foreach (DataRow dr in dt.Rows)
            {
                img = new Bitmap(@"..\..\"+dr["Image"].ToString());  //image is name of column in database.
                dataGridView1.Rows[i].Cells[14].Value = img;    //13=position of the colum that displays the images. 13 becuz columns in db is 12 in total
                dataGridView1.Rows[i].Height = 100;
                i = i + 1;
            }
           //this is page load event
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchbtn2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                int i = 0;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student_info where LibCardNo like('%" + textBox2.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                Bitmap img;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.Width = 100;
                imageCol.HeaderText = "student image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

                dataGridView1.Columns.Add(imageCol);

                foreach (DataRow dr in dt.Rows)
                {
                    img = new Bitmap(@"..\..\" + dr["Image"].ToString());  //image is name of column in database.
                    dataGridView1.Rows[i].Cells[14].Value = img;    //13=position of the colum that displays the images. 13 becuz columns in db is 12 in total
                    dataGridView1.Rows[i].Height = 100;
                    i = i + 1;
                }
                textBox2.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            //this is button 2 search event.
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            Bitmap img;
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            imageCol.Width = 100;
            imageCol.HeaderText = "student image";
            imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dataGridView1.Columns.Add(imageCol);

            foreach (DataRow dr in dt.Rows)
            {
                img = new Bitmap(@"..\..\" + dr["Image"].ToString());  //image is name of column in database.
                dataGridView1.Rows[i].Cells[14].Value = img;    //13=position of the colum that displays the images. 13 becuz columns in db is 12 in total
                dataGridView1.Rows[i].Height = 100;
                i = i + 1;
            }
            //refresh button search event.
        }

        private void searchbtn3_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                int i = 0;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student_info where Name like('%" + textBox3.Text + "%') AND Course like('%"+textBox4.Text+"%') AND Batch like('%"+textBox5.Text+"%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                Bitmap img;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.Width = 100;
                imageCol.HeaderText = "student image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

                dataGridView1.Columns.Add(imageCol);

                foreach (DataRow dr in dt.Rows)
                {
                    img = new Bitmap(@"..\..\" + dr["Image"].ToString());  //image is name of column in database.
                    dataGridView1.Rows[i].Cells[14].Value = img;    //13=position of the colum that displays the images. 13 becuz columns in db is 12 in total
                    dataGridView1.Rows[i].Height = 100;
                    i = i + 1;
                }
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            //this is button 3 search event.
        }

        private void editStudentbtn_Click(object sender, EventArgs e)
        {
            Manage_Student_Info msi = new Manage_Student_Info();
            msi.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }     
    }
}
