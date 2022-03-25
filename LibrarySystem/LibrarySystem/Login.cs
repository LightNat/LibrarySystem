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
            Admin.AdminViewBooks adminViewBooks = new Admin.AdminViewBooks();
            this.Visible = false;
            adminViewBooks.Show();
        }

        private void lblguest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}