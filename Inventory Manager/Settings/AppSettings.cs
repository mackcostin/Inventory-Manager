using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace Inventory_Manager.Settings
{
    class AppSettings
    {
        public void saveDBSettings(string serverName, string username, string password, string dbName)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Add("dbServerName", serverName);
            config.AppSettings.Settings.Add("dbUsername", username);
            config.AppSettings.Settings.Add("dbPassword", password);
            config.AppSettings.Settings.Add("dbName", dbName);
            config.Save(ConfigurationSaveMode.Minimal);
        }
    }
}
