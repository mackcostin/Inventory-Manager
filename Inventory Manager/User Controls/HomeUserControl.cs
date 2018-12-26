using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manager.User_Controls
{
    public partial class HomeUserControl : UserControl
    {
        private const string svrNameHintText = "Enter Server Name Here";
        private const string dbUsrNameHintText = "Enter Username Here";
        private const string dbPasswordHintText = "Enter Password Here";

        public HomeUserControl()
        {
            InitializeComponent();
        }

        #region TextBox Hints Removal
        private void tbxSvrName_Click(object sender, EventArgs e)
        {
            if (tbxSvrName.Text == svrNameHintText)
            {
                tbxSvrName.Text = null;
            }
        }

        private void tbxSvrUsrName_Click(object sender, EventArgs e)
        {
            if(tbxSvrUsrName.Text == dbUsrNameHintText)
            {
                tbxSvrUsrName.Text = null;
            }
        }

        private void tbxSvrPassword_Click(object sender, EventArgs e)
        {
            if (tbxSvrPassword.Text == dbPasswordHintText)
            {
                tbxSvrPassword.Text = null;
            }
        }
        #endregion
    }
}
