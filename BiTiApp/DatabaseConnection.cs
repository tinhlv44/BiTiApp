using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiTiApp
{
    public class DatabaseConnection
    {
        private SqlConnection connection;
        public SqlConnection Open()
        {
            //string connectionString = @"server=ADMIN-PC\SQLEXPRESS;Database=BiTiApp;Integrated security=True"; // của Tính
            string connectionString = @"server=DESKTOP-CM888JL\KTEAM;Database=BiTiApp;Integrated security=True"; // của Bình
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Cannot connect to database! Lỗi: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            return connection;
        }

        public void Close()
        {
            if (connection != null && connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}
