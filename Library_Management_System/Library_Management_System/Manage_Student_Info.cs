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
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;


namespace Library_Management_System
{
    public partial class Manage_Student_Info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-29MAECMT\MSSQLSERVER2016;Initial Catalog=Library_mgmt_system1;Integrated Security=True");
        string wanted_path;
        string pwd = Class1.GetRandomPassword(20);
        DialogResult result;

        public Manage_Student_Info()
        {
            InitializeComponent();
        }

        private void Manage_Student_Info_Load(object sender, EventArgs e)
        {
           
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            fill_grid();

           
        }
        public void fill_grid()
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
            imageCol.Width = 105;
            imageCol.HeaderText = "student image";
            imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dataGridView1.Columns.Add(imageCol);

            foreach (DataRow dr in dt.Rows)
            {
                img = new Bitmap(@"..\..\" + dr["Image"].ToString());  //image is name of column in database.
                dataGridView1.Rows[i].Cells[14].Value = img;    //13=position of the colum that displays the images. 13 becuz columns in db is 12 in total
                dataGridView1.Rows[i].Height = 105;
                i = i + 1;
            }
            //this is page load event
        }

        private void student_libcardNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                dataGridView1.Columns.Clear();
                dataGridView1.Refresh();
                int i = 0;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student_info where LibCardNo like('%" +textBox1.Text+ "%') AND EnrollmentNo like('%"+textBox2.Text+"%') AND Name like('%"+textBox3.Text+"%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                Bitmap img;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.Width = 105;
                imageCol.HeaderText = "student image";
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

                dataGridView1.Columns.Add(imageCol);

                foreach (DataRow dr in dt.Rows)
                {
                    img = new Bitmap(@"..\..\" + dr["Image"].ToString());  //image is name of column in database.
                    dataGridView1.Rows[i].Cells[14].Value = img;    //13=position of the colum that displays the images. 13 becuz columns in db is 12 in total
                    dataGridView1.Rows[i].Height = 105;
                    i = i + 1;
                }
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText="select * from student_info where id="+i+"";
            cmd.ExecuteNonQuery();
            DataTable dt=new DataTable();
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                student_name.Text=dr["Name"].ToString();
                dateTimePicker1_dob.Text=dr["DateOfBirth"].ToString();
                student_address.Text=dr["Address"].ToString();
                student_email.Text=dr["Email"].ToString();
                student_phnNo.Text=dr["PhoneNo"].ToString();
                comboBox_scourses.Text=dr["Course"].ToString();
                student_enrollmentNo.Text=dr["EnrollmentNo"].ToString();
                student_class.Text = dr["Class"].ToString();
                student_rollNo.Text=dr["RollNo"].ToString();
                comboBox1_txtbatch.Text=dr["Batch"].ToString();
               comboBox1_txtcurrentsem.Text=dr["CurrentSem"].ToString();
                student_libcardNo.Text=dr["LibCardNo"].ToString();

            }


        }

        private void Select_fileBtn_Click(object sender, EventArgs e)
        {
            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "All Files (*.*)|*.*|JPEG files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|PNG Files (*.png)|*.png";
           
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (student_name.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Select Student Record!");
                    return; // return because we don't want to run normal code of buton click
                }


                int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update student_info set Name='" + student_name.Text + "', DateOfBirth='" + dateTimePicker1_dob.Text + "', Address='" + student_address.Text + "', Email='" + student_email.Text + "', PhoneNo='" + student_phnNo.Text + "', Course='" + comboBox_scourses.Text + "', EnrollmentNo='" + student_enrollmentNo.Text + "',Class='"+student_class.Text+"', RollNo='" + student_rollNo.Text + "', Batch='" + comboBox1_txtbatch.Text + "', CurrentSem='" + comboBox1_txtcurrentsem.Text + "', LibCardno='" + student_libcardNo.Text + "' where Id=" + i + "";
            DialogResult res = MessageBox.Show("Do You Want To Save Changes?", "Confirmation", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("record updated successfully");
                fill_grid();



                if (result == DialogResult.OK) //for uploading image.
                {


                    string pwd = Class1.GetRandomPassword(20);
                    string img_path;
                    File.Copy(openFileDialog1.FileName, wanted_path + "\\Student_images\\" + pwd + ".jpg");
                    img_path = "Student_images\\" + pwd + ".jpg";


                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText= "update student_info set  Image='"+img_path.ToString()+"' where Id="+i+""; //separate query only for updatng image.
                    cmd.ExecuteNonQuery();
                    fill_grid();
                   
                }
            }
            else if(res==DialogResult.No)
            {
                MessageBox.Show("Operation Cancelled");

                student_name.Text = "";
                dateTimePicker1_dob.Text = "";
                student_address.Text= "";
                student_email.Text= "";
                student_phnNo.Text = "";
                    comboBox_scourses.Text = "";
                student_enrollmentNo.Text = "";
                student_class.Text = ""; 
                student_rollNo.Text = "";
                comboBox1_txtbatch.Text= "";
                comboBox1_txtcurrentsem.Text= "";
                student_libcardNo.Text = "";
            }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        
    }

        private void student_phnNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric Value");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());


            try
            {
                if (student_name.Text == "")
                {
                    MessageBox.Show("Select Record to delete");
                    return;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are You Sure You Want to Delete Whole record?", "Confirmation", MessageBoxButtons.YesNo);
                    SqlCommand del = con.CreateCommand();
                    del.CommandType = CommandType.Text;
                    del.CommandText = "delete from student_info where Id=" + i + "";
                    if (result == DialogResult.Yes)
                    {

                        del.ExecuteNonQuery();

                        MessageBox.Show("Record deleted Successfully");
                        fill_grid();
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("deletion Cancelled");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            fill_grid();
        }

        private void student_email_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;

            if (student_email.Text.Trim() != string.Empty)

            {

                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(student_email.Text.Trim()))

                {

                    MessageBox.Show("E-mail address format is not correct.", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    student_email.Text = "";

                }
            }
        }

        private void student_phnNo_Leave(object sender, EventArgs e)
        {
            Regex re = new Regex("^([+][9][1]|[9][1]|[0]){0,1}([7-9]{1})([0-9]{9})$");

            if (re.IsMatch(student_phnNo.Text.Trim()) == false || student_phnNo.Text.Length > 10)
            {
                MessageBox.Show("Invalid Mobile Number!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                student_phnNo.Text = "";

            }
        }
    }

        
    }
    

