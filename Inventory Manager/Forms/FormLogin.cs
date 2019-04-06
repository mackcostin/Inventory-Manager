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
        private void TbxDBSvrName_Click(object sender, EventArgs e)
        {
            if (TbxDBSvrName.Text == svrNameHintText)
            {
                TbxDBSvrName.ForeColor = System.Drawing.Color.Black;
                TbxDBSvrName.Text = null;
            }
        }

        private void TbxDBName_Click(object sender, EventArgs e)
        {
            if (TbxDBName.Text == dbNameHintText)
            {
                TbxDBName.ForeColor = System.Drawing.Color.Black;
                TbxDBName.Text = null;
            }
        }

        private void TbxDBUsername_Click(object sender, EventArgs e)
        {
            if (TbxDBUsername.Text == usrNameHintText)
            {
                TbxDBUsername.ForeColor = System.Drawing.Color.Black;
                TbxDBUsername.Text = null;
            }
        }

        private void TbxDBPassword_Click(object sender, EventArgs e)
        {
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
            if (TbxDBSvrName.Text == "" || TbxDBSvrName.Text == svrNameHintText || TbxDBSvrName == null)
            {
                LblEnterSvrNamePrompt.Text = "Please enter a server name";
                return false;

            }
            else if (TbxDBSvrName.Text != "" || TbxDBSvrName.Text != svrNameHintText)
            {
                return true;
            }

            if (TbxDBName.Text == "" || TbxDBName.Text == dbNameHintText || TbxDBName == null)
            {
                LblEnterDBNamePrompt.Text = "Please enter a server name";
                return false;

            }
            else if (TbxDBName.Text != "" || TbxDBName.Text != dbNameHintText)
            {
                return true;
            }


            if (TbxDBUsername.Text == "" || TbxDBUsername.Text == usrNameHintText || TbxDBUsername == null)
            {
                LblEnterUserNamePrompt.Text = "Please enter a username";
                return false;
            }
            else if (TbxDBUsername.Text != "" || TbxDBUsername.Text != svrNameHintText)
            {
                return true;
            }


            if (TbxDBPassword.Text == "" || TbxDBPassword.Text == passwordHintText || TbxDBPassword == null)
            {
                LblEnterPasswordPrompt.Text = "Please enter a password";
                return false;
            }
            else if (TbxDBPassword.Text != "" || TbxDBPassword.Text != svrNameHintText)
            {
                TbxDBPassword.PasswordChar = '*';
                return true;
            }

            return true;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
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
            else
            {
                CheckFormEntries();
            }
        }

        private void OpenMainForm()
        {
            Application.Run(new MainForm());
        }
    }
}