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

namespace Inventory_Manager.Forms
{
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {
            PnlSetupUCContainer.Controls.Add(new UCFirstSetup());
        }

        private void btnSetupCloseApp_Click(object sender, EventArgs e)
        {
            DialogResult closeDialog = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (closeDialog == DialogResult.Yes)
            {
                Environment.Exit(0);
            };
        }
    }
}
