using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibrarySystem
{
    internal class Function
    {
        public static string gen = "";          //Variable that holds the SQL Statements
        public static SqlCommand command;       //Processes Sql Statements and Connection
        public static SqlDataReader reader;     //Retrieves Data from Database

        public static void fill(string q, DataGridView dgv) //(Optional) To display dataGridview in your system
        {
            try
            {
                Connection.DB();
                DataTable dt = new DataTable();
                command = new SqlCommand(q, Connection.conn);
                SqlDataAdapter data = new SqlDataAdapter(command);
                data.Fill(dt);
                dgv.DataSource = dt;        //Retrieves all records from dgv
                Connection.conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
