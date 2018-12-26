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
        #region Save Settings
        public void saveDBSettings(string serverName, string username, string password, string dbName)
        {
            Properties.Settings.Default.DBServerName = serverName;
            Properties.Settings.Default.DBUsername = username;
            Properties.Settings.Default.DBPassword = password;
            Properties.Settings.Default.DBName = dbName;
            Properties.Settings.Default.Save();
        }

        public void saveAppStartupSettings(bool previouslyStarted)
        {
            Properties.Settings.Default.PreviouslyStarted = previouslyStarted;
            Properties.Settings.Default.Save();
        }
        #endregion

        #region Check Settings
        public bool checkIfAppUsed()
        {
            if (Properties.Settings.Default.PreviouslyStarted == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
