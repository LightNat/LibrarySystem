using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LibrarySystem
{
    internal class Connection
    {
        public static SqlConnection conn;
        private static string connect = "Data Source=DESKTOP-GQFB644;Initial Catalog=Library_System;Integrated Security=True";

        public static void DB()
        {
            try
            {
                conn = new SqlConnection(connect);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
