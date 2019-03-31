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
    public partial class UCHomePage : UserControl
    {
        public UCHomePage()
        {
            InitializeComponent();
        }

        private void UCHomePage_Load(object sender, EventArgs e)
        {
            LblSvrName.Text = "Server: " + AppSettings.GetDBSettings()[0];
            LblDBName.Text = "Database:  " + AppSettings.GetDBSettings()[1];
            LblUsrName.Text = "User: " + AppSettings.GetDBSettings()[2];
        }
    }
}
