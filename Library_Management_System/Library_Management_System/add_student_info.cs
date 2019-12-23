using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class add_student_info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-29MAECMT\MSSQLSERVER2016;Initial Catalog=Library_mgmt_system1;Integrated Security=True");
        string wanted_path;
        string pwd = Class1.GetRandomPassword(20);


        public add_student_info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            DialogResult result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "All Files (*.*)|*.*|JPEG files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (result == DialogResult.OK) //Test result.
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            //pictureBox1.ImageLocation=@"..\..\Student_images\"+pwd+".jpg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter student name!");
                return; // return because we don't want to run normal code of buton click
            }

            if (comboBox_courses.Text.Trim() == string.Empty && txt_enrollment.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Please Select Course name and enrollment no!");
                return; // return because we don't want to run normal code of buton click
            }


            string pwd = Class1.GetRandomPassword(20);
            string img_path;
            File.Copy(openFileDialog1.FileName, wanted_path + "\\Student_images\\" + pwd + ".jpg");
            img_path = "Student_images\\" + pwd + ".jpg";


            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into student_info values('" + txt_name.Text + "','" + dateTimePicker1_dob.Text + "','" + txt_address.Text + "','" + txt_email.Text + "','" + txt_phone.Text + "','" + comboBox_courses.Text + "','" + txt_enrollment.Text + "','" + txt_class.Text + "','" + txt_rollno.Text + "','" + comboBox1_txtbatch.Text + "','" + comboBox1_txtcurrentsem.Text + "','" + txt_libraryC.Text + "','" + img_path.ToString() + "')";
            /*cmd.Parameters.AddWithValue("@name",txt_name.Text );
            cmd.Parameters.AddWithValue("@dob", dateTimePicker1_dob.Text);
            cmd.Parameters.AddWithValue("@address", txt_address.Text);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            cmd.Parameters.AddWithValue("@phoneno", txt_phone.Text);
            cmd.Parameters.AddWithValue("@course", txt_course.Text);
            cmd.Parameters.AddWithValue("@enrollmentno", txt_enrollment.Text);
            cmd.Parameters.AddWithValue("@class", txt_class.Text);
            cmd.Parameters.AddWithValue("@rollno", txt_rollno.Text);
            cmd.Parameters.AddWithValue("@batch", txt_batch.Text);
            cmd.Parameters.AddWithValue("@currentsem", txt_currentsem.Text);
            cmd.Parameters.AddWithValue("@libcardno", txt_libraryC.Text);
            cmd.Parameters.AddWithValue("@image", img_path.ToString()); */


            DialogResult res = MessageBox.Show("Do You Want To register the student?", "Confirmation", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {


                cmd.ExecuteNonQuery();
                MessageBox.Show("Record entered succesfully");
                txt_name.Text = "";
                txt_address.Text = "";
                txt_email.Text = "";
                txt_phone.Text = "";
                comboBox_courses.Text = "";
                txt_enrollment.Text = "";
                txt_rollno.Text = "";
                comboBox1_txtbatch.Text = "";
                comboBox1_txtcurrentsem.Text = "";
                txt_libraryC.Text = "";
                txt_class.Text = "";
                pictureBox1.Image = null;



            }
            else if (res == DialogResult.No)
            {
                MessageBox.Show("Operation Cancelled");

                txt_name.Text = "";
                txt_address.Text = "";
                dateTimePicker1_dob.Text = "";
                txt_address.Text = "";
                comboBox1_txtbatch.Text = "";
                txt_class.Text = "";
                comboBox_courses.Text = "";
                comboBox1_txtcurrentsem.Text = "";
                txt_email.Text = "";
                txt_enrollment.Text = "";
                txt_libraryC.Text = "";
                txt_phone.Text = "";
                txt_rollno.Text = "";
                pictureBox1.Image = null;

            }
            con.Close();




        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_address.Text = "";
            txt_email.Text = "";
            txt_phone.Text = "";
            comboBox_courses.Text = "";
            txt_enrollment.Text = "";
            txt_rollno.Text = "";
            comboBox1_txtbatch.Text = "";
            comboBox1_txtcurrentsem.Text = "";
            txt_libraryC.Text = "";
            txt_class.Text = "";
            pictureBox1.Image = null;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_student_info_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric Value");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;

            if (txt_email.Text.Trim() != string.Empty)

            {

                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(txt_email.Text.Trim()))

                {

                    MessageBox.Show("E-mail address format is not correct.", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txt_email.Text = "";

                }
            }
        }

        private void txt_phone_Leave(object sender, EventArgs e)
        {
            Regex re = new Regex("^([+][9][1]|[9][1]|[0]){0,1}([7-9]{1})([0-9]{9})$");

            if (re.IsMatch(txt_phone.Text.Trim()) == false || txt_phone.Text.Length > 10)
            {
                MessageBox.Show("Invalid Mobile Number!!","Alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_phone.Text = "";
                
            }
        }
    }
}
