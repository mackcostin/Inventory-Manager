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
        private WelcomeScreenUserControl welcomeScreenUserControl = new WelcomeScreenUserControl();
        private AddInventoryUserControl addInventoryUserControl = new AddInventoryUserControl();
        private HomePageUserControl homePageUserControl = new HomePageUserControl();
        private AppSettings settings = new AppSettings();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            DialogResult closeDialog = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (closeDialog == DialogResult.Yes){
                Environment.Exit(0);
            };
        }

        private void manageInventoryUserControl_Load(object sender, EventArgs e)
        {

        }

        private void homePageUserControl1_Load(object sender, EventArgs e)
        {
            

        }



        private void userControlPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        /**
         * Methods from in this section are used for the navigation pane.
         * */
        private void btnManageInventory_Click(object sender, EventArgs e)
        {
            userControlPanel.Controls.Remove(homePageUserControl);
            userControlPanel.Controls.Remove(welcomeScreenUserControl);
            userControlPanel.Controls.Add(addInventoryUserControl);          
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            userControlPanel.Controls.Remove(addInventoryUserControl);
            userControlPanel.Controls.Add(welcomeScreenUserControl);
        }
        /**
         * END NAVIGATION PANE METHODS
         * */
    }
}
