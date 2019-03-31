using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Inventory_Manager.Data_Access
{
    class DBCreate
    {
        /**
         * This method is intended for use in the First Setup UC. Creates the database needed for the software to run. SQL Server must exist
         * for this to work.
         * */
        public bool CreateDB(string svrName, string dbName, string username, string password)
        {
            string createDBScript;
            string createTablesScript;

            SqlConnection sqlConnection = new SqlConnection("Server=" + svrName + ";" +
                "uid=" + username + ";" +
                "pwd=" + password + ";" +
                "database=master");

            createDBScript = "CREATE DATABASE " + dbName;
            createTablesScript = "USE  " + dbName + " " +
                "CREATE TABLE dbo.InventoryItem(" +
                "[InventoryID] INT NOT NULL PRIMARY KEY," +
                "[ItemName] VARCHAR(255) NOT NULL," +
                "[ItemPrice] FLOAT NOT NULL," +
                "[ItemNumber] INT UNIQUE)";

            SqlCommand execCreateDBScript = new SqlCommand(createDBScript, sqlConnection);
            SqlCommand execCreateTablesScript = new SqlCommand(createTablesScript,sqlConnection);
            try
            {
                sqlConnection.Open();
                execCreateDBScript.ExecuteNonQuery();
                execCreateTablesScript.ExecuteNonQuery();

                DialogResult dresult = MessageBox.Show("Database Created Successfully", "Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
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
                }
                //ENABLE THIS FOR DEBUGGING SQL SERVER CONNECTION
                // MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            return false;
        }
    }
}
