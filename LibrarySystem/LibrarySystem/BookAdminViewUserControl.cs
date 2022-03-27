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

namespace LibrarySystem
{
    public partial class BookAdminViewUserControl : UserControl
    {
        public string bookid;
        public string title;
        public string author;
        public string image;

        public static string bookidUpdate;
        public static string titleUpdate;
        public static string authorUpdate;
        public static string imageUpdate;

        public BookAdminViewUserControl()
        {
            InitializeComponent();
        }

        private void BookAdminViewUserControl_Load(object sender, EventArgs e)
        {
            lbltitle.Text = "Title: " + title;
            lblauthor.Text = "Author: " + author;
            DisplayProfile();
        }

        private void DisplayProfile()
        {
            try
            {
                var profile = Path.GetDirectoryName(Application.ExecutablePath) + "\\Books\\" + image;
                pbbooks.Image = Image.FromFile(profile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //For pulling the Data
            bookidUpdate = bookid;
            titleUpdate = title;
            authorUpdate = author;
            imageUpdate = image;

            Admin.AdminUpdateBooks adminUpdateBooks = new Admin.AdminUpdateBooks();
            adminUpdateBooks.Update();
            adminUpdateBooks.Show();

            //To avoid for duplication
            Form form = this.FindForm();
            form.Close();
            form.Dispose();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string text = "Do you wish to remove this book named " + " \" " + title + " \" ?";
            string caption = "Delete";
            DialogResult dialogResult = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Connection.DB();
                    Function.gen = "DELETE FROM books WHERE bookid = '"+bookid+"' ";
                    Function.command = new SqlCommand(Function.gen, Connection.conn);
                    Function.command.ExecuteNonQuery();

                    MessageBox.Show("Book deleted successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Visible = false;

                    Connection.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
