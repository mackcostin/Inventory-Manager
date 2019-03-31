using System;
using System.Windows.Forms;
using System.Threading;
using Inventory_Manager.Data_Access;
using Inventory_Manager.Settings;

namespace Inventory_Manager.User_Controls
{
    public partial class UCFirstSetup : UserControl
    {
        private const string svrNameHintText = "Enter Server Name Here";
        private const string dbNameHintText = "Enter Database Name Here";
        private const string usrNameHintText = "Enter Username Here";
        private const string passwordHintText = "Enter Password Here";
        private string svrName;
        private string svrDBName;
        private string svrUsrName;
        private string svrPwd;

        #region Initialize UC
        public UCFirstSetup()
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



        #region Button Event Handlers
        private void BtnFTSFinish_Click(object sender, EventArgs e)
        {
            if(DBCreate.CreateDB(TbxFTSSvrName.Text,TbxFTSEnterDBName.Text, TbxFTSSvrUsrName.Text, TbxFTSSvrPassword.Text) == true)
            {
                AppSettings.SaveDBSettings(
                    TbxFTSSvrName.Text,
                    TbxFTSEnterDBName.Text,
                    TbxFTSSvrUsrName.Text,
                    TbxFTSSvrPassword.Text);
                AppSettings.SaveStartupSettings(true);

                ((Form)this.TopLevelControl).Close();
                Thread thread = new Thread(OpenMainForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                CheckFormEntries();
            }
        }

        private void BtnSkipSetup_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            Thread thread = new Thread(OpenMainForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        #endregion

        #region Text Box Event Handlers
        private void TbxFTSSvrName_TextChanged(object sender, EventArgs e)
        {
            svrName = TbxFTSSvrName.Text;
        }

        private void TbxFTSSvrUsrName_TextChanged(object sender, EventArgs e)
        {
            svrUsrName = TbxFTSSvrUsrName.Text;
        }

        private void TbxFTSSvrPassword_TextChanged(object sender, EventArgs e)
        {
            svrPwd = TbxFTSSvrPassword.Text;
        }
        #endregion

        #region Basic Text Box Formatting Event Handlers

        #region Text Box Click Event Handlers
        private void TbxFTSSvrName_Click(object sender, EventArgs e)
            {
                if (TbxFTSSvrName.Text == svrNameHintText)
                {
                    TbxFTSSvrName.Text = null;
                }
            }

        private void TbxEnterDBName_Click(object sender, EventArgs e)
        {
            if (TbxFTSEnterDBName.Text == dbNameHintText)
            {
                TbxFTSEnterDBName.Text = null;
            }
        }

        private void TbxFTSSvrUsrName_Click(object sender, EventArgs e)
        {
            if (TbxFTSSvrUsrName.Text == usrNameHintText)
            {
                TbxFTSSvrUsrName.Text = null;
            }
        }

            private void TbxFTSSvrPassword_Click(object sender, EventArgs e)
            {
                if (TbxFTSSvrPassword.Text == passwordHintText)
                {
                    TbxFTSSvrPassword.Text = null;
                    TbxFTSSvrPassword.PasswordChar = '*';
                }
            }
            #endregion

        #region Text Box Leave Event Handlers
        private void TbxFTSSvrName_Leave(object sender, EventArgs e)
        {
            if (TbxFTSSvrName == null || TbxFTSSvrName.Text == "")
            {
                TbxFTSSvrName.Text = svrNameHintText;
            }
        }

        private void TbxFTSEnterDBName_Leave(object sender, EventArgs e)
        {
            if (TbxFTSEnterDBName == null || TbxFTSEnterDBName.Text == "")
            {
                TbxFTSEnterDBName.Text = dbNameHintText;
            }
        }

        private void TbxFTSSvrUsrName_Leave(object sender, EventArgs e)
        {
            if (TbxFTSSvrUsrName == null || TbxFTSSvrUsrName.Text == "")
            {
                TbxFTSSvrUsrName.Text = usrNameHintText;
            }
        }

        private void TbxFTSSvrPassword_Leave(object sender, EventArgs e)
        {
            if (TbxFTSSvrPassword == null || TbxFTSSvrPassword.Text == "")
            {
                TbxFTSSvrPassword.Text = usrNameHintText;
            }
        }
        #endregion
        #endregion


        /// <summary>
        /// Checks if Text Boxes have been filled in
        /// </summary>
        /// <returns>bool</returns>
        private bool CheckFormEntries()
        {
            if (TbxFTSSvrName.Text == "" || TbxFTSSvrName.Text == svrNameHintText || TbxFTSSvrName == null)
            {
                lblEnterSvrNamePrompt.Text = "Please enter a server name";
                return false;

            }
            else if (TbxFTSSvrName.Text != "" || TbxFTSSvrName.Text != svrNameHintText)
            {
                TbxFTSSvrName.Text = svrName;
                return true;
            }

            if (TbxFTSEnterDBName.Text == "" || TbxFTSEnterDBName.Text == dbNameHintText || TbxFTSSvrName == null)
            {
                lblDBNamePrompt.Text = "Please enter a server name";
                return false;

            }
            else if (TbxFTSEnterDBName.Text != "" || TbxFTSEnterDBName.Text != dbNameHintText)
            {
                lblDBNamePrompt.Text = svrDBName;
                return true;
            }


            if (TbxFTSSvrUsrName.Text == "" || TbxFTSSvrUsrName.Text == usrNameHintText || TbxFTSSvrUsrName == null)
            {
                lblEnterSvrUsrNamePrompt.Text = "Please enter a username";
                return false;
            }
            else if (TbxFTSSvrUsrName.Text != "" || TbxFTSSvrUsrName.Text != svrNameHintText)
            {
                TbxFTSSvrUsrName.Text = svrUsrName;
                return true;
            }


            if (TbxFTSSvrPassword.Text == "" || TbxFTSSvrPassword.Text == passwordHintText || TbxFTSSvrPassword == null)
            {
                lblEnterSvrPwdPrompt.Text = "Please enter a password";
                return false;
            }
            else if (TbxFTSSvrPassword.Text != "" || TbxFTSSvrPassword.Text != svrNameHintText)
            {
                TbxFTSSvrPassword.PasswordChar = '*';
                TbxFTSSvrPassword.Text = svrUsrName;
                return true;
            }

            return true;
        }

        private void OpenMainForm()
        {
            Application.Run(new MainForm());
        }

    }


}
