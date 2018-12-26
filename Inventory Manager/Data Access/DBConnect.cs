using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Inventory_Manager.Data_Access
{
    class DBConnect
    {
        public void ConnectToDB()
        {
            var conn = new SqlConnection();
            conn.ConnectionString =
            @"Data Source=.\SQLExpress;" +
            "User Instance=true;" +
            "User Id=UserName;" +
            "Password=Secret;" +
            "AttachDbFilename=|DataDirectory|DataBaseName.mdf;";
            conn.Open();
        }
    }
}
