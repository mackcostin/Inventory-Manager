using Inventory_Manager.Data_Access;
using Inventory_Manager.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manager.Forms
{
    public partial class FormLogin : Form
    {
        private const string svrNameHintText = "Enter a Server Name";
        private const string dbNameHintText = "Enter a Database Name";
        private const string usrNameHintText = "Enter a Username";
        private const string passwordHintText = "Enter a Password";

        public FormLogin()
        {
            InitializeComponent();
        }


        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        #region Text Box Click Event Handlers
        private void TbxDBSvrName_Enter(object sender, EventArgs e)
        {
            TbxDBSvrName.SelectAll();
            if (TbxDBSvrName.Text == svrNameHintText)
            {
                TbxDBSvrName.ForeColor = System.Drawing.Color.Black;
                TbxDBSvrName.Text = null;
            }
        }

        private void TbxDBName_Enter(object sender, EventArgs e)
        {
            TbxDBName.SelectAll();
            if (TbxDBName.Text == dbNameHintText)
            {
                TbxDBName.ForeColor = System.Drawing.Color.Black;
                TbxDBName.Text = null;
            }
        }

        private void TbxDBUsername_Enter(object sender, EventArgs e)
        {
            TbxDBUsername.SelectAll();
            if (TbxDBUsername.Text == usrNameHintText)
            {
                TbxDBUsername.ForeColor = System.Drawing.Color.Black;
                TbxDBUsername.Text = null;
            }
        }

        private void TbxDBPassword_Enter(object sender, EventArgs e)
        {
            TbxDBPassword.SelectAll();
            if (TbxDBPassword.Text == passwordHintText)
            {
                TbxDBPassword.ForeColor = System.Drawing.Color.Black;
                TbxDBPassword.Text = null;
                TbxDBPassword.PasswordChar = '*';
            }
        }
        #endregion

        #region Text Box Leave Event Handlers
        private void TbxSvrName_Leave(object sender, EventArgs e)
        {
            if (TbxDBSvrName == null || TbxDBSvrName.Text == "")
            {
                TbxDBSvrName.ForeColor = System.Drawing.Color.Gray;
                TbxDBSvrName.Text = svrNameHintText;
            }
        }

        private void TbxDBName_Leave(object sender, EventArgs e)
        {
            if (TbxDBName == null || TbxDBName.Text == "")
            {
                TbxDBName.ForeColor = System.Drawing.Color.Gray;
                TbxDBName.Text = dbNameHintText;
            }
        }

        private void TbxDBUsername_Leave(object sender, EventArgs e)
        {
            if (TbxDBUsername == null || TbxDBUsername.Text == "")
            {
                TbxDBUsername.ForeColor = System.Drawing.Color.Gray;
                TbxDBUsername.Text = usrNameHintText;
            }
        }

        private void TbxDBPassword_Leave(object sender, EventArgs e)
        {
            if (TbxDBPassword == null || TbxDBPassword.Text == "")
            {
                TbxDBPassword.ForeColor = System.Drawing.Color.Gray;
                TbxDBPassword.PasswordChar = '\0';
                TbxDBPassword.Text = passwordHintText;
            }
        }
        #endregion

        private bool CheckFormEntries()
        {
            if (string.IsNullOrWhiteSpace(TbxDBSvrName.Text) == false && TbxDBSvrName.Text != svrNameHintText &&
                string.IsNullOrWhiteSpace(TbxDBName.Text) == false && TbxDBName.Text != dbNameHintText &&
                string.IsNullOrWhiteSpace(TbxDBUsername.Text) == false && TbxDBUsername.Text != usrNameHintText &&
                string.IsNullOrWhiteSpace(TbxDBPassword.Text) == false && TbxDBPassword.Text != passwordHintText)
            {
                return true;
            }

            if (TbxDBSvrName.Text == "" || TbxDBSvrName.Text == svrNameHintText || TbxDBSvrName == null)
            {
                LblEnterSvrNamePrompt.Text = "Please enter a server name";
            }
            else
            {
                LblEnterSvrNamePrompt.Text = null;
            }

            if (TbxDBName.Text == "" || TbxDBName.Text == dbNameHintText || TbxDBName == null)
            {
                LblEnterDBNamePrompt.Text = "Please enter a database name";
            }
            else
            {
                LblEnterDBNamePrompt.Text = null;
            }


            if (TbxDBUsername.Text == "" || TbxDBUsername.Text == usrNameHintText || TbxDBUsername == null)
            {
                LblEnterUserNamePrompt.Text = "Please enter a username";
            }
            else
            {
                LblEnterUserNamePrompt.Text = null;
            }

            if (TbxDBPassword.Text == "" || TbxDBPassword.Text == passwordHintText || TbxDBPassword == null)
            {
                LblEnterPasswordPrompt.Text = "Please enter a password";
            }
            else
            {
                LblEnterPasswordPrompt.Text = null;
            }
            return false;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (CheckFormEntries() == true)
            {
                if (DBConnect.ConnectDB(TbxDBSvrName.Text, TbxDBName.Text, TbxDBUsername.Text, TbxDBPassword.Text) == true)
                {
                    AppSettings.SaveDBSettings(
                        TbxDBSvrName.Text,
                        TbxDBName.Text,
                        TbxDBUsername.Text,
                        TbxDBPassword.Text);
                    AppSettings.SaveStartupSettings(true);

                    this.Close();
                    Thread thread = new Thread(OpenMainForm);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
            }
        }

        private void OpenMainForm()
        {
            Application.Run(new MainForm());
        }

        private void BtnCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}