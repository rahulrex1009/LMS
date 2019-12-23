using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Library_Management_System
{
    
    public partial class add_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-29MAECMT\MSSQLSERVER2016;Initial Catalog=Library_mgmt_system1;Integrated Security=True");
        SqlCommand cmd;
       
        public add_books()
        {
            InitializeComponent();
        }
        public void resetbtn()
        {
            isbn_no.Text = "";
            book_no.Text = "";
            book_name.Text = "";
            book_author.Text = "";
            book_publication.Text = "";
            book_price.Text = "";
            book_qty.Text = "";
            book_qty.Text = "";
            dateTimePicker1_purchase.Text = "";
            book_pages.Text = "";
            book_description.Text = "";
            comboBox_category.Text = "";
            comboBox_shelf.Text = "";

        }

        private void label5_Click(object sender, EventArgs e)
        { 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (book_name.Text == "")
            {
                MessageBox.Show("Give Book Name to add");
                return;
            }

            if (isbn_no.Text == "")
            {
                MessageBox.Show("Provide ISBN number to add");
                return;
            }

            cmd = new SqlCommand("INSERT INTO books_info (ISBN_number,Book_No,Book_Name,Book_Author,Book_Publication,Book_Price,Book_Quantity,Available_qty,Books_Purchase_Date,Books_Pages,Description,Book_Category,Book_Shelf)  VALUES(@isbnNo,@bookNo,@bookName,@bookAuthor,@bookPublication,@bookPrice,@bookQuantity,@availableQty,@bookPurchasedt,@bookPages,@bookDescription,@bookCategory,@bookShelf)", con);
            cmd.Parameters.AddWithValue("@isbnNo", isbn_no.Text);
            cmd.Parameters.AddWithValue("@bookNo", book_no.Text);
             cmd.Parameters.AddWithValue("@bookName", book_name.Text);
             cmd.Parameters.AddWithValue("@bookAuthor", book_author.Text);
             cmd.Parameters.AddWithValue("@bookPublication", book_publication.Text);
             cmd.Parameters.AddWithValue("@bookPrice", book_price.Text);
             cmd.Parameters.AddWithValue("@bookQuantity", book_qty.Text);
             cmd.Parameters.AddWithValue("@availableQty", book_qty.Text);
             cmd.Parameters.AddWithValue("@bookPurchasedt", dateTimePicker1_purchase.Text);
            cmd.Parameters.AddWithValue("@bookPages", book_pages.Text);
            cmd.Parameters.AddWithValue("@bookDescription",book_description.Text);
            cmd.Parameters.AddWithValue("@bookCategory", comboBox_category.Text);
            cmd.Parameters.AddWithValue("@bookShelf", comboBox_shelf.Text);

            DialogResult result = MessageBox.Show("Are You Sure You Want to Add the book?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Added successfully");
                resetbtn();
            }
            else if (result == DialogResult.No)
            {
                resetbtn();
            }

           

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetbtn();

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric Value");
            }

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric Value");
            }

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric Value");
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void book_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric Value");
            }
        }

        private void book_pages_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric Value");
            }
        }

        private void book_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric Value");
            }
        }

        private void add_books_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void book_category_KeyUp(object sender, KeyEventArgs e)
        {
           //
        }
    }
}
