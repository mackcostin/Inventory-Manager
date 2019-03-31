namespace Inventory_Manager.Settings
{
    class AppSettings
    {
        #region Save Settings
        public static void SaveDBSettings(string serverName, string dbName,string username, string password)
        {
            Properties.Settings.Default.DBServerName = serverName;
            Properties.Settings.Default.DBUsername = username;
            Properties.Settings.Default.DBPassword = password;
            Properties.Settings.Default.DBName = dbName;
            Properties.Settings.Default.Save();
        }

        public static void SaveStartupSettings(bool previouslyStarted)
        {
            Properties.Settings.Default.PreviouslyStarted = previouslyStarted;
            Properties.Settings.Default.Save();
        }
        #endregion

        #region Check Settings
        public static bool CheckIfAppUsed()
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

        /// <summary>
        /// Returns Database connection settings.
        /// 
        /// 0 - Server Name
        /// 1 - Database Name
        /// 2 - User Name
        /// 3 - Password
        /// 
        /// </summary>
        /// <returns>string[]</returns>
        public static string [] GetDBSettings()
        {
            string[] DBSettings = new string[]{
                Properties.Settings.Default.DBServerName,
                Properties.Settings.Default.DBName,
                Properties.Settings.Default.DBUsername,
                Properties.Settings.Default.DBPassword
            };
            return DBSettings;
        }
    }
}
