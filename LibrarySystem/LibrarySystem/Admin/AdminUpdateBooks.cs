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
    public partial class AdminUpdateBooks : Form
    {
        //Variable for update
        private string bookIdUpdate;

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
            if (String.IsNullOrWhiteSpace(txttitle.Text) == true)
            {
                MessageBox.Show("Title must not be set as Null or WhiteSpace, Please try Again!", "Null | WhiteSpace", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(txtauthor.Text) == true)
            {
                MessageBox.Show("Author must not be set as Null or WhiteSpace, Please try Again!", "Null | WhiteSpace", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lblfilename.Text == "No File Chosen")
            {
                MessageBox.Show("Please choose an Image File!", "Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Connection.DB();
                    Function.gen = "INSERT INTO Books(title, author, image) VALUES('"+txttitle.Text+"', '"+txtauthor.Text+"', '"+lblfilename.Text+"') ";
                    Function.command = new SqlCommand(Function.gen, Connection.conn);
                    Function.command.ExecuteNonQuery();
                    
                    try
                    {
                        File.Copy(fileImage, Path.Combine(Path.GetDirectoryName(Application.ExecutablePath) + "\\Books", lblfilename.Text));
                    }
                    catch (Exception ex)
                    {
                        //Do nothing
                    }
                    Admin.AdminViewBooks adminViewBooks = new Admin.AdminViewBooks();
                    this.Visible = false;
                    adminViewBooks.Show();

                    MessageBox.Show("Book is saved successfully!", "Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Connection.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lblfilename.Text);
            if (String.IsNullOrWhiteSpace(txttitle.Text) == true)
            {
                MessageBox.Show("Title must not be set as Null or WhiteSpace, Please try Again!", "Null | WhiteSpace", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrWhiteSpace(txtauthor.Text) == true)
            {
                MessageBox.Show("Author must not be set as Null or WhiteSpace, Please try Again!", "Null | WhiteSpace", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lblfilename.Text == "No File Chosen")
            {
                MessageBox.Show("Please choose an Image File!", "Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    bookIdUpdate = BookAdminViewUserControl.bookidUpdate;

                    Connection.DB();
                    Function.gen = "UPDATE books SET title = '"+txttitle.Text+"', author = '"+txtauthor.Text+"', image = '"+lblfilename.Text+"' WHERE bookid = '"+bookIdUpdate+"' ";
                    Function.command = new SqlCommand(Function.gen, Connection.conn);
                    Function.command.ExecuteNonQuery();
                    try
                    {
                        File.Copy(fileImage, Path.Combine(Path.GetDirectoryName(Application.ExecutablePath) + "\\Books", lblfilename.Text));
                    }
                    catch (Exception ex)
                    {
                        //Do nothing
                    }

                    Admin.AdminViewBooks adminViewBooks = new Admin.AdminViewBooks();
                    this.Visible = false;
                    adminViewBooks.Show();

                    MessageBox.Show("Book is updated successfully!", "Book", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Connection.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        public void Update()
        {
            txttitle.Text = BookAdminViewUserControl.titleUpdate;
            txtauthor.Text = BookAdminViewUserControl.authorUpdate;

            var image = Path.GetDirectoryName(Application.ExecutablePath) + "\\Books\\" + BookAdminViewUserControl.imageUpdate;
            pbimage.Image = Image.FromFile(image);

            lblfilename.Text = BookAdminViewUserControl.imageUpdate;

            lbladd.Visible = false;
            lblupdate.Visible = true;

            btnadd.Enabled = false;
            btnupdate.Enabled = true;
        }
    }
}
