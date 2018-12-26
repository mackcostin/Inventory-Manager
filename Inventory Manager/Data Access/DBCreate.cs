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
        public void CreateDB(string svrName, string username, string password)
        {
            string createDBScript;
            string createTablesScript;

            SqlConnection sqlConnection = new SqlConnection("Server=" + svrName + ";" +
                "uid=" + username + ";" +
                "pwd=" + password + ";" +
                "database=master");

            createDBScript = "CREATE DATABASE Business_Manager";
            createTablesScript = "USE Business_Manager " +
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
                MessageBox.Show("Database is Created Successfully", "Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
