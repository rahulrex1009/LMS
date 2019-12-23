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
    public partial class Course_Info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RAHUL-PC;Initial Catalog=Library_mgmt_system1;Integrated Security=True");
       
 
        public Course_Info()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
               

                SqlCommand cmd;
                    cmd = new SqlCommand("INSERT INTO Courses(CourseName,CourseDescription) VALUES(@coursename,@coursedescriptn)", con);
                   
                     if (txt_courseName.Text == "")
                     {
                         MessageBox.Show("Please Enter Course Name");
                         txt_courseName.Text = "";
                         txt_Description.Text = "";
                     }

                     else if (txt_courseName.Text == " " || txt_courseName.Text=="    ")
                     {
                         MessageBox.Show("Spaces Not Allowed");
                         txt_courseName.Text = "";
                         txt_Description.Text = "";
                     }

                    else if(txt_courseName.Text == ",")
                     {
                         MessageBox.Show("Comma Not Allowed");
                         txt_courseName.Text = "";
                         txt_Description.Text = "";
                     }

                     else
                     {
                         cmd.Parameters.AddWithValue("@coursename", txt_courseName.Text);
                         cmd.Parameters.AddWithValue("@coursedescriptn", txt_Description.Text);
                         cmd.ExecuteNonQuery();
                         MessageBox.Show("course added successfully");
                         txt_courseName.Text = "";
                         txt_Description.Text = "";
                         fill_listbox();
                         
                     }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } 
        }

        public void fill_listbox()
        {
            listCourses.Items.Clear();
            
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select CourseName from Courses";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                listCourses.Items.Add(dr["CourseName"].ToString());
            }
        }
        

        private void Course_Info_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            
            con.Open();
            fill_listbox();

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            /*try 
            { 

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Courses set CourseName=@coursename,CourseDescription=@coursedesc where CourseID="+ lb_courseId.Text+"";
            cmd.Parameters.AddWithValue("@coursename",txt_courseName.Text);
            cmd.Parameters.AddWithValue("@coursedesc",txt_Description.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updates Saved");
             }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
             */
        }

        private void listCourses_Click(object sender, EventArgs e)
        {
           
        }

        private void listCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

            

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Courses where CourseName='"+ listCourses.SelectedItem.ToString() +"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                txt_courseName.Text = dr["CourseName"].ToString();
                txt_Description.Text = dr["CourseDescription"].ToString();
                lb_courseId.Text = dr["CourseID"].ToString();
            }

           
        }

        private void del_Btn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Courses where CourseName='"+txt_courseName.Text+"'";
            cmd.ExecuteNonQuery();
            txt_courseName.Text = "";
            txt_Description.Text = "";
            fill_listbox();
            MessageBox.Show("Course deleted successfully");

        }
        }
    }

