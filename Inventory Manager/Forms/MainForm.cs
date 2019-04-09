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
        private readonly UCWelcomeScreen welcomeScreenUserControl = new UCWelcomeScreen();
        private readonly UCAddInventory addInventoryUserControl = new UCAddInventory();
        private readonly UCHomePage homePageUserControl = new UCHomePage();
        private readonly UCSettings settingsUC = new UCSettings();
        private bool mouseDown;
        private Point lastLocation;
        #endregion

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

        private void BtnCloseApp_Click(object sender, EventArgs e)
        {
            DialogResult closeDialog = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (closeDialog == DialogResult.Yes){
                Environment.Exit(0);
            };
        }

        #region Navigation Pane
        private void BtnManageInventory_Click(object sender, EventArgs e)
        {
            userControlPanel.Controls.Clear();
            userControlPanel.Controls.Add(addInventoryUserControl);          
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            if (AppSettings.CheckIfAppUsed() == true)
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
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            userControlPanel.Controls.Clear();
            userControlPanel.Controls.Add(settingsUC);
        }
        #endregion



        #region Window Movement controllers.
        //This Region allows for the form to be dragged to different places on the screen.
        private void PnlFormHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void PnlFormHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void PnlFormHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion
    }
}
