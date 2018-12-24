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
    public partial class Form1 : Form
    {
        private HomePageUserControl homePageUserControl = new HomePageUserControl();
        private ManageInventoryUserControl manageInventoryUserControl = new ManageInventoryUserControl();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControlPanel.Controls.Add(homePageUserControl);
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
            userControlPanel.Controls.Add(manageInventoryUserControl);          
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            userControlPanel.Controls.Remove(manageInventoryUserControl);
            userControlPanel.Controls.Add(homePageUserControl);
        }
        /**
         * END NAVIGATION PANE METHODS
         * */
    }
}
