using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Manager.Data_Access;

namespace Inventory_Manager.User_Controls
{
    public partial class FirstSetupUserControl : UserControl
    {
        private const string svrNameHintText = "Enter Server Name Here";
        private const string usrNameHintText = "Enter Username Here";
        private const string passwordHintText = "Enter Password Here";
        private DBCreate createDB = new DBCreate();

        #region Initialize UC
        public FirstSetupUserControl()
        {
            InitializeComponent();
        }

        private void FirstSetupUserControl_Load(object sender, EventArgs e)
        {
            lblFirstSetupDesc.Text = "Welcome to Business Manager!\n\n" +
                "Lets get started: \n" +
                "Start by entering a SQL Server to create\n " +
                "the database on and then enter the Server\n" +
                "username and password into the text boxes.\n" +
                "When you click finish and your credentials\n" +
                "are correct, Business Manager will create\n" +
                "the database and the tables it requires to\n" +
                "work.";
        }
        #endregion

        #region Text Box Click Event Handlers
        private void TbxFTSSvrName_Click(object sender, EventArgs e)
        {
            if(TbxFTSSvrName.Text == svrNameHintText)
            {
                TbxFTSSvrName.Text = null;
            }
        }

        private void TbxFTSSvrUsrName_Click(object sender, EventArgs e)
        {
            if(TbxFTSSvrUsrName.Text == usrNameHintText)
            {
                TbxFTSSvrUsrName.Text = null;
            }
        }

        private void TbxFTSSvrPassword_Click(object sender, EventArgs e)
        {
            if(TbxFTSSvrPassword.Text == passwordHintText)
            {
                TbxFTSSvrPassword.Text = null;
            }
        }
        #endregion

        #region Text Box Text Changed Event Handlers
        private void TbxFTSSvrUsrName_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void BtnFTSFinish_Click(object sender, EventArgs e)
        {
            createDB.CreateDB(TbxFTSSvrName.Text, TbxFTSSvrUsrName.Text, TbxFTSSvrPassword.Text);
        }
    }
}
