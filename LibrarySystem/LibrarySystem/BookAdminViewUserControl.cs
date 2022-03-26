using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class BookAdminViewUserControl : UserControl
    {
        public string title;
        public string author;
        public string image;

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
    }
}
