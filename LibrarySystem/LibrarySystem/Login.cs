using System.Data.SqlClient;

namespace LibrarySystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            using (var icon = File.OpenRead(Path.GetDirectoryName(Application.ExecutablePath) + "\\Icon\\Books.ico"))
            {
                this.Icon = new Icon(icon);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var logo = Path.GetDirectoryName(Application.ExecutablePath) + "\\Login\\Library_System.png";
            pblogo.Image = Image.FromFile(logo);

            var username = Path.GetDirectoryName(Application.ExecutablePath) + "\\Login\\Username.png";
            pbusername.Image = Image.FromFile(username);

            var password = Path.GetDirectoryName(Application.ExecutablePath) + "\\Login\\Password.png";
            pbpassword.Image = Image.FromFile(password);


        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.DB();
                Function.gen = "SELECT * FROM users WHERE username = '"+txtusername.Text+"' AND password = '"+txtpassword.Text+"' ";
                Function.command = new SqlCommand(Function.gen, Connection.conn);
                Function.reader = Function.command.ExecuteReader();

                if (Function.reader.HasRows)
                {
                    Function.reader.Read();

                    txtusername.Text = Function.reader.GetValue(1).ToString();
                    txtpassword.Text = Function.reader.GetValue(2).ToString();

                    Admin.AdminViewBooks adminViewBooks = new Admin.AdminViewBooks();
                    this.Visible = false;
                    adminViewBooks.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void lblguest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GuestViewBook guestViewBook = new GuestViewBook();
            this.Visible = false;
            guestViewBook.Show();
        }
    }
}