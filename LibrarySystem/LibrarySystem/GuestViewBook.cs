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
    public partial class GuestViewBook : Form
    {
        //For usercontrol variables
        private int booksCount;
        private string[] bookid = new string[100];
        private string[] title = new string[100];
        private string[] author = new string[100];
        private string[] image = new string[100];

        public GuestViewBook()
        {
            InitializeComponent();

            using (var icon = File.OpenRead(Path.GetDirectoryName(Application.ExecutablePath) + "\\Icon\\Books.ico"))
            {
                this.Icon = new Icon(icon);
            }
        }

        private void GuestViewBook_Load(object sender, EventArgs e)
        {
            var logo = Path.GetDirectoryName(Application.ExecutablePath) + "\\Admin\\Books.png";
            pblogo.Image = Image.FromFile(logo);

            var profile = Path.GetDirectoryName(Application.ExecutablePath) + "\\Guest\\Guest.png";
            pbprofile.Image = Image.FromFile(profile);

            var search = Path.GetDirectoryName(Application.ExecutablePath) + "\\Admin\\Search.png";
            pbsearch.Image = Image.FromFile(search);

            GenerateBooks();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Visible = false;
            login.Show();
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

                    BookGuestViewUserControl[] bookGuestViewUserControl = new BookGuestViewUserControl[booksCount];

                    try
                    {
                        Connection.DB();
                        Function.gen = "SELECT * FROM books";
                        Function.command = new SqlCommand(Function.gen, Connection.conn);
                        Function.reader = Function.command.ExecuteReader();

                        if (Function.reader.HasRows)
                        {

                            for (int i = 0; i < bookGuestViewUserControl.Length; i++)
                            {
                                Function.reader.Read();
                                bookid[i] = Function.reader.GetValue(0).ToString();
                                title[i] = Function.reader.GetValue(1).ToString();
                                author[i] = Function.reader.GetValue(2).ToString();
                                image[i] = Function.reader.GetValue(3).ToString();

                                //Initialize
                                bookGuestViewUserControl[i] = new BookGuestViewUserControl();

                                //Adding Data
                                bookGuestViewUserControl[i].bookid = bookid[i];
                                bookGuestViewUserControl[i].title = title[i];
                                bookGuestViewUserControl[i].author = author[i];
                                bookGuestViewUserControl[i].image = image[i];

                                flowLayoutPanelBooks.Controls.Add(bookGuestViewUserControl[i]);
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

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtsearch.Text) == true)
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

                        BookGuestViewUserControl[] bookGuestViewUserControl = new BookGuestViewUserControl[booksCount];

                        try
                        {
                            Connection.DB();
                            Function.gen = "SELECT * FROM books";
                            Function.command = new SqlCommand(Function.gen, Connection.conn);
                            Function.reader = Function.command.ExecuteReader();

                            if (Function.reader.HasRows)
                            {

                                for (int i = 0; i < bookGuestViewUserControl.Length; i++)
                                {
                                    Function.reader.Read();
                                    bookid[i] = Function.reader.GetValue(0).ToString();
                                    title[i] = Function.reader.GetValue(1).ToString();
                                    author[i] = Function.reader.GetValue(2).ToString();
                                    image[i] = Function.reader.GetValue(3).ToString();

                                    //Initialize
                                    bookGuestViewUserControl[i] = new BookGuestViewUserControl();

                                    //Adding Data
                                    bookGuestViewUserControl[i].bookid = bookid[i];
                                    bookGuestViewUserControl[i].title = title[i];
                                    bookGuestViewUserControl[i].author = author[i];
                                    bookGuestViewUserControl[i].image = image[i];

                                    flowLayoutPanelBooks.Controls.Add(bookGuestViewUserControl[i]);
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
            else
            {
                flowLayoutPanelBooks.Controls.Clear();
                try
                {
                    Connection.DB();
                    Function.gen = "SELECT COUNT(*) FROM books WHERE title LIKE '%" + txtsearch.Text + "%'";
                    Function.command = new SqlCommand(Function.gen, Connection.conn);
                    Function.reader = Function.command.ExecuteReader();

                    if (Function.reader.HasRows)
                    {
                        Function.reader.Read();

                        string count = Function.reader.GetValue(0).ToString();

                        booksCount = Convert.ToInt32(count);

                        BookGuestViewUserControl[] bookGuestViewUserControl = new BookGuestViewUserControl[booksCount];

                        try
                        {
                            Connection.DB();
                            Function.gen = "SELECT * FROM books WHERE title LIKE '%" + txtsearch.Text + "%'";
                            Function.command = new SqlCommand(Function.gen, Connection.conn);
                            Function.reader = Function.command.ExecuteReader();

                            if (Function.reader.HasRows)
                            {

                                for (int i = 0; i < bookGuestViewUserControl.Length; i++)
                                {
                                    Function.reader.Read();
                                    bookid[i] = Function.reader.GetValue(0).ToString();
                                    title[i] = Function.reader.GetValue(1).ToString();
                                    author[i] = Function.reader.GetValue(2).ToString();
                                    image[i] = Function.reader.GetValue(3).ToString();

                                    //Initialize
                                    bookGuestViewUserControl[i] = new BookGuestViewUserControl();

                                    //Adding Data
                                    bookGuestViewUserControl[i].bookid = bookid[i];
                                    bookGuestViewUserControl[i].title = title[i];
                                    bookGuestViewUserControl[i].author = author[i];
                                    bookGuestViewUserControl[i].image = image[i];

                                    flowLayoutPanelBooks.Controls.Add(bookGuestViewUserControl[i]);
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
}
