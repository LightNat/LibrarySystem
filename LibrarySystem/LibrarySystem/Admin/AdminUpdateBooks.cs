using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Admin
{
    public partial class AdminUpdateBooks : Form
    {
        //holds the image info
        private string fileImage;

        //use for storing the image
        private string imageFile;

        public AdminUpdateBooks()
        {
            InitializeComponent();

            using (var icon = File.OpenRead(Path.GetDirectoryName(Application.ExecutablePath) + "\\Icon\\Books.ico"))
            {
                this.Icon = new Icon(icon);
            }
        }

        private void AdminUpdateBooks_Load(object sender, EventArgs e)
        {
            var logo = Path.GetDirectoryName(Application.ExecutablePath) + "\\Admin\\Books.png";
            pblogo.Image = Image.FromFile(logo);

            var profile = Path.GetDirectoryName(Application.ExecutablePath) + "\\Admin\\Admin.png";
            pbprofile.Image = Image.FromFile(profile);
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

        private void btnchoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;) | *.jpg; *.jpeg; *.gif; *.bmp;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialog.FileName;
                imageFile = Path.GetFileName(fileImage);
                pbimage.Image = new Bitmap(fileImage);

                lblfilename.Text = imageFile;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }
    }
}
