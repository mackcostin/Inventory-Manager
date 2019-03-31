using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Inventory_Manager.Settings;

namespace Inventory_Manager.Data_Access
{
    class DBConnect
    {
        private static SqlConnection sqlConnection;


        /// <summary>
        /// Connects to a database using the stored credentials in app settings.
        /// </summary>
        public static void ConnectToDB()
        {
            sqlConnection = new SqlConnection(
                "Server=" + AppSettings.GetDBSettings()[0] + ";" +
                "uid=" + AppSettings.GetDBSettings()[2] + ";" +
                "pwd=" + AppSettings.GetDBSettings()[3] + ";" +
                "database=" + AppSettings.GetDBSettings()[1]);
            sqlConnection.Open();
        }

        /// <summary>
        /// Closes the database connection.
        /// </summary>
        public static void DisconnectDB()
        {
            sqlConnection.Close();
        }
    }
}
