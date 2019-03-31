using Inventory_Manager.Forms;
using Inventory_Manager.Settings;
using Inventory_Manager.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class MainForm : Form
    {
        #region Variables
        private UCWelcomeScreen welcomeScreenUserControl = new UCWelcomeScreen();
        private UCAddInventory addInventoryUserControl = new UCAddInventory();
        private UCHomePage homePageUserControl = new UCHomePage();
        private UCSettings settingsUC;
        #endregion

        #region Event Handlers
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (AppSettings.CheckIfAppUsed() == true)
            {
                userControlPanel.Controls.Add(homePageUserControl);
            }
            else if(AppSettings.CheckIfAppUsed() == false)
            {
                userControlPanel.Controls.Add(welcomeScreenUserControl);
            }
        }

        /**
         * This Method Handles the "Close App button (Power Icon)" 
         * */
        private void BtnCloseApp_Click(object sender, EventArgs e)
        {
            DialogResult closeDialog = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (closeDialog == DialogResult.Yes){
                Environment.Exit(0);
            };
        }
        #endregion

        #region Navigation Pane
        private void BtnManageInventory_Click(object sender, EventArgs e)
        {
            userControlPanel.Controls.Clear();
            userControlPanel.Controls.Add(addInventoryUserControl);          
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            if(AppSettings.CheckIfAppUsed() == true)
            {
                userControlPanel.Controls.Clear();
                userControlPanel.Controls.Add(homePageUserControl);
            }
            else
            {
                userControlPanel.Controls.Clear();
                userControlPanel.Controls.Add(welcomeScreenUserControl);
            }
        }
        #endregion

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            userControlPanel.Controls.Clear();
            userControlPanel.Controls.Add(settingsUC = new UCSettings());
        }
    }
}
