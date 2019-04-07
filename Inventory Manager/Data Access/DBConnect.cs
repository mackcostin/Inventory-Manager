using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Inventory_Manager.Settings;
using System.Windows.Forms;

namespace Inventory_Manager.Data_Access
{
    class DBConnect
    {
        private static SqlConnection sqlConnection;
        public static string ErrorMessage { get; private set;}

        /// <summary>
        /// Connects to a database using the stored credentials in app settings.
        /// Returns true if connection is successful, false if failed.
        /// </summary>
        public static bool ConnectToDBOnStartup()
        {
            try
            {
                sqlConnection = new SqlConnection(
                    "Server=" + AppSettings.GetDBSettings()[0] + ";" +
                    "uid=" + AppSettings.GetDBSettings()[2] + ";" +
                    "pwd=" + AppSettings.GetDBSettings()[3] + ";" +
                    "database=" + AppSettings.GetDBSettings()[1]);
                sqlConnection.Open();
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 18456:
                        MessageBox.Show("Error # 18456: Invalid connection credentials.");
                        break;
                    case 5170:
                        MessageBox.Show("SQL Error #5170: Database with this name already exists.");
                        break;
                    case 53:
                        MessageBox.Show("SQL Error #53: Could not find SQL server instance, please check and try again.");
                        break;
                }
                //ENABLE THIS FOR DEBUGGING SQL SERVER CONNECTION
                //MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Connects to a database using the provided credentials to the parameters.
        /// Returns true if connection is successful, false if failed.
        /// </summary>
        /// <param name="server"></param>
        /// <param name="database"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public static bool ConnectDB(string server, string database, string username, string password)
        {
            try
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
                sqlConnection = new SqlConnection(
                "Server=" + server + ";" +
                "uid=" + username + ";" +
                "pwd=" + password + ";" +
                "database=" + database
                );
                sqlConnection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 18456:
                        MessageBox.Show("Error # 18456: Invalid connection credentials.");
                        break;
                    case 53:
                        MessageBox.Show("SQL Error #53: Could not find SQL server instance, please check and try again.");
                        break;
                }
                //ENABLE THIS FOR DEBUGGING SQL SERVER CONNECTION
                //MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        /// <summary>
        /// Closes the database connection.
        /// 
        /// THIS METHOD MAY NEED AN EXCEPTION TO CHECK IF A CURRENT CONNECTION IS OPEN.
        /// </summary>
        public static void DisconnectDB()
        {
            sqlConnection.Close();
        }
    }
}
