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
    public partial class Books_Report : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-29MAECMT\MSSQLSERVER2016;Initial Catalog=Library_mgmt_system1;Integrated Security=True");
        public Books_Report()
        {
            InitializeComponent();
        }

        private void Books_Report_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void genReportB_Click(object sender, EventArgs e)
        {
            DataSet3Books ds = new DataSet3Books();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from books_info ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.DataTableBooks);
            CrystalReportAllBook myreport = new CrystalReportAllBook();
            myreport.SetDataSource(ds);
            crystalReportViewerAllBooks.ReportSource = myreport;
        }
    }
}
