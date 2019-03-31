using Inventory_Manager.Settings;
using System;
using System.Windows.Forms;

namespace Inventory_Manager.User_Controls
{
    public partial class UCSettings : UserControl
    {
        public UCSettings()
        {
            InitializeComponent();
        }

        private void UCSettings_Load(object sender, EventArgs e)
        {
            TbxSvrName.Text = AppSettings.GetDBSettings()[0];
            TbxDBName.Text = AppSettings.GetDBSettings()[1];
            TbxSvrUsrName.Text = AppSettings.GetDBSettings()[2];
            TbxSvrPass.Text = AppSettings.GetDBSettings()[3];
            
        }
    }
}
