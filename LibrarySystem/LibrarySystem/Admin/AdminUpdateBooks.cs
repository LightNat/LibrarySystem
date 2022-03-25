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
    }
}
