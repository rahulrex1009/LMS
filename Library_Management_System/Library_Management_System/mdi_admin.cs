using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class mdi_admin : Form
    {
        private int childFormNumber = 0;

        public mdi_admin()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void addNewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "add_books")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (Isopen == false)
            {
                add_books ab = new add_books();
                ab.Show();
            }
        }

        private void viewBooksInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "View_books")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (Isopen == false)
            {

                View_books vb = new View_books();
                vb.Show();
            }
        }

        private void manageBooksInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "manage_books")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (Isopen == false)
            {

                manage_books mb = new manage_books();
                mb.Show();
            }
        }

        private void registerNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "add_student_info")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (Isopen == false)
            {
                add_student_info asi = new add_student_info();
                asi.Show();
            }
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "View_students")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (Isopen == false)
            {
                View_students vs = new View_students();
                vs.Show();
            }
        }

        private void manageStudentsInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Manage_Student_Info")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (Isopen == false)
            {
                Manage_Student_Info msi = new Manage_Student_Info();
                msi.Show();
            }
        }

        private void issuedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Issue_books")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (Isopen == false)
            {
                Issue_books ib = new Issue_books();
                ib.Show();
            }
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Return_books")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (Isopen == false)
            {
                Return_books rb = new Return_books();
                rb.Show();
            }
        }

        private void bookStocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Bookstock")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (Isopen == false)
            {
                Bookstock bs = new Bookstock();
                bs.Show();
            }
        }

        private void booksRetainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Report_books_return_retain")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (Isopen == false)
            {
                Report_books_return_retain rb = new Report_books_return_retain();

                rb.Show();
            }
        }

        private void studentsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Student_report")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (Isopen == false)
            {

                Student_report sr = new Student_report();
                sr.Show();
            }
        }

        private void totalBooksReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Books_Report")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (Isopen == false)
            {
                Books_Report br = new Books_Report();

                br.Show();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "About")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (Isopen == false)
            {
                About1 ab = new About1();
                ab.Show();
            }
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void sendReportViaEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Send_Report")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (Isopen == false)
            {
                Send_Report sr = new Send_Report();
                sr.Show();
            }
        }

        private void reportProblemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

       private void bookCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void contactDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Report_problem")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (Isopen == false)
            {
                Report_problem rp = new Report_problem();
                rp.Show();
            }
        }
    }
}
