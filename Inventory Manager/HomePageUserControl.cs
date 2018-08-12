using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manager
{
    public partial class HomePageUserControl : UserControl
    {
        public HomePageUserControl()
        {
            InitializeComponent();
        }

        private void lblIntroParagraph_Click(object sender, EventArgs e)
        {
        }

        private void HomePageUserControl_Load(object sender, EventArgs e)
        {
            lblIntroParagraph.Text = "Welcome to inventory manager. This app allows for your business to enter new \n" +
    "product data and modify old product data. To get started, click on the Get Started \n" +
    "button or click on Manage Inventory or Search Stock.";
        }
    }
}
