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
    public partial class BookGuestViewUserControl : UserControl
    {
        public string bookid;
        public string title;
        public string author;
        public string image;

        public static string bookidUpdate;
        public static string titleUpdate;
        public static string authorUpdate;
        public static string imageUpdate;

        public BookGuestViewUserControl()
        {
            InitializeComponent();
        }

        private void BookGuestViewUserControl_Load(object sender, EventArgs e)
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

    }
}
