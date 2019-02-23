using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Manager.Settings;

namespace Inventory_Manager.User_Controls
{
    public partial class WelcomeScreenUserControl : UserControl
    {

        private AppSettings appSettings = new AppSettings();
        private HomePageUserControl homePageUserControl = new HomePageUserControl();
        private FirstSetupUserControl firstSetupUC = new FirstSetupUserControl();

        public WelcomeScreenUserControl()
        {
            InitializeComponent();
        }

        private void WelcomeScreenUserControl_Load(object sender, EventArgs e)
        {
            lblHomePgIntro.Text = "Welcome to inventory manager. This app allows for your business to enter new \n" +
"product data and modify old product data. To get started, click on the Get Started \n" +
"button or click on Manage Inventory or Search Stock.";
        }

        private void btnFTSGetStarted_Click(object sender, EventArgs e)
        {
        }

        #region Text Box Hint Handlers

        #endregion
    }
}
