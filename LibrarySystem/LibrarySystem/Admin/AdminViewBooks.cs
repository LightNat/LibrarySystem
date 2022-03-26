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

namespace LibrarySystem.Admin
{
    public partial class AdminViewBooks : Form
    {
        //For usercontrol variables
        private int booksCount;
        private string[] title = new string[100];
        private string[] author = new string[100];
        private string[] image = new string[100];

        public AdminViewBooks()
        {
            InitializeComponent();

            using (var icon = File.OpenRead(Path.GetDirectoryName(Application.ExecutablePath) + "\\Icon\\Books.ico"))
            {
                this.Icon = new Icon(icon);
            }
        }

        private void AdminViewBooks_Load(object sender, EventArgs e)
        {
            var logo = Path.GetDirectoryName(Application.ExecutablePath) + "\\Admin\\Books.png";
            pblogo.Image = Image.FromFile(logo);

            var profile = Path.GetDirectoryName(Application.ExecutablePath) + "\\Admin\\Admin.png";
            pbprofile.Image = Image.FromFile(profile);

            GenerateBooks();
        }

        private void btnbooks_Click(object sender, EventArgs e)
        {
            Admin.AdminViewBooks adminViewBooks = new Admin.AdminViewBooks();
            this.Visible = false;
            adminViewBooks.Show();
        }

        private void btnupdateoradd_Click(object sender, EventArgs e)
        {
            Admin.AdminUpdateBooks adminUpdateBooks = new Admin.AdminUpdateBooks();
            this.Visible = false;
            adminUpdateBooks.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            string text = "Do you wish to log out?";
            string caption = "Logout";

            DialogResult result = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                this.Visible = false;
                login.Show();
            }
        }

        private void GenerateBooks()
        {
            flowLayoutPanelBooks.Controls.Clear();

            try
            {
                Connection.DB();
                Function.gen = "SELECT COUNT(*) FROM books";
                Function.command = new SqlCommand(Function.gen, Connection.conn);
                Function.reader = Function.command.ExecuteReader();

                if (Function.reader.HasRows)
                {
                    Function.reader.Read();

                    string count = Function.reader.GetValue(0).ToString();

                    booksCount = Convert.ToInt32(count);

                    BookAdminViewUserControl[] bookAdminViewUserControl = new BookAdminViewUserControl[booksCount];

                    try
                    {
                        Connection.DB();
                        Function.gen = "SELECT * FROM books";
                        Function.command = new SqlCommand(Function.gen, Connection.conn);
                        Function.reader = Function.command.ExecuteReader();

                        if (Function.reader.HasRows)
                        {
                            
                            for (int i = 0; i < bookAdminViewUserControl.Length; i++)
                            {
                                Function.reader.Read();

                                title[i] = Function.reader.GetValue(1).ToString();
                                author[i] = Function.reader.GetValue(2).ToString();
                                image[i] = Function.reader.GetValue(3).ToString();

                                //Initialize
                                bookAdminViewUserControl[i] = new BookAdminViewUserControl();

                                //Adding Data
                                bookAdminViewUserControl[i].title = title[i];
                                bookAdminViewUserControl[i].author = author[i];
                                bookAdminViewUserControl[i].image = image[i];

                                flowLayoutPanelBooks.Controls.Add(bookAdminViewUserControl[i]);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
