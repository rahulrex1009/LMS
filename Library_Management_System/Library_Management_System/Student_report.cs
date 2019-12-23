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
    public partial class Student_report : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-29MAECMT\MSSQLSERVER2016;Initial Catalog=Library_mgmt_system1;Integrated Security=True");
        public Student_report()
        {
            InitializeComponent();
        }

        private void Student_report_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void genReportSt_Click(object sender, EventArgs e)
        {
            DataSet2St ds = new DataSet2St();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student_info ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTable2);
            CrystalReportStudent myreport = new CrystalReportStudent();
            myreport.SetDataSource(ds);
            crystalReportViewerSt.ReportSource = myreport;
        }
    }
}
