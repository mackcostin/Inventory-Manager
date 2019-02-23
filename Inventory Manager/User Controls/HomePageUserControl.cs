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
    public partial class HomePageUserControl : UserControl
    {
        private const string svrNameHintText = "Enter Server Name Here";
        private const string usrNameHintText = "Enter Username Here";
        private const string passwordHintText = "Enter Password Here";

        public HomePageUserControl()
        {
            InitializeComponent();
        }

        #region Textbox Hint Handlers
        private void TbxSvrName_Click(object sender, EventArgs e)
        {
            if (tbxSvrName.Text == svrNameHintText)
            {
                tbxSvrName.Text = null;
            }
        }

        private void TbxSvrUsrName_Click(object sender, EventArgs e)
        {
            if (tbxSvrUsrName.Text == usrNameHintText)
            {
                tbxSvrUsrName.Text = null;
            }
        }

        private void TbxSvrPassword_Click(object sender, EventArgs e)
        {
            if (tbxSvrPassword.Text == passwordHintText)
            {
                tbxSvrPassword.Text = null;
            }
        }
        #endregion

    }
}
