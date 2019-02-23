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
        private WelcomeScreenUserControl welcomeScreenUserControl = new WelcomeScreenUserControl();
        private AddInventoryUC addInventoryUserControl = new AddInventoryUC();
        private HomePageUserControl homePageUserControl = new HomePageUserControl();
        private AppSettings settings = new AppSettings();
        #endregion

        #region Event Handlers
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (settings.checkIfAppUsed() == true)
            {
                userControlPanel.Controls.Add(homePageUserControl);
            }
            else if(settings.checkIfAppUsed() == false)
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
            userControlPanel.Controls.Remove(homePageUserControl);
            userControlPanel.Controls.Remove(welcomeScreenUserControl);
            userControlPanel.Controls.Add(addInventoryUserControl);          
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            if(settings.checkIfAppUsed() == true)
            {
                userControlPanel.Controls.Remove(addInventoryUserControl);
                userControlPanel.Controls.Add(homePageUserControl);
            }
            else
            {
                userControlPanel.Controls.Remove(addInventoryUserControl);
                userControlPanel.Controls.Add(welcomeScreenUserControl);
            }

        }
        #endregion
    }
}
