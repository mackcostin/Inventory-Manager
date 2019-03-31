namespace Inventory_Manager.User_Controls
{
    partial class UCFirstSetup
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstSetupDesc = new System.Windows.Forms.Label();
            this.lblHomePgHeader = new System.Windows.Forms.Label();
            this.BtnFTSTestConnection = new System.Windows.Forms.Button();
            this.LblFTSSvrPassword = new System.Windows.Forms.Label();
            this.TbxFTSSvrPassword = new System.Windows.Forms.TextBox();
            this.LblFTSSvrUsrName = new System.Windows.Forms.Label();
            this.TbxFTSSvrUsrName = new System.Windows.Forms.TextBox();
            this.LblFTSServerName = new System.Windows.Forms.Label();
            this.TbxFTSSvrName = new System.Windows.Forms.TextBox();
            this.BtnFTSFinish = new System.Windows.Forms.Button();
            this.btnSkipSetup = new System.Windows.Forms.Button();
            this.lblEnterSvrNamePrompt = new System.Windows.Forms.Label();
            this.lblEnterSvrUsrNamePrompt = new System.Windows.Forms.Label();
            this.lblEnterSvrPwdPrompt = new System.Windows.Forms.Label();
            this.TbxFTSEnterDBName = new System.Windows.Forms.TextBox();
            this.LblEnterDBName = new System.Windows.Forms.Label();
            this.lblDBNamePrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstSetupDesc
            // 
            this.lblFirstSetupDesc.AutoSize = true;
            this.lblFirstSetupDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstSetupDesc.Location = new System.Drawing.Point(56, 56);
            this.lblFirstSetupDesc.Name = "lblFirstSetupDesc";
            this.lblFirstSetupDesc.Size = new System.Drawing.Size(46, 17);
            this.lblFirstSetupDesc.TabIndex = 0;
            this.lblFirstSetupDesc.Text = "label1";
            // 
            // lblHomePgHeader
            // 
            this.lblHomePgHeader.AutoSize = true;
            this.lblHomePgHeader.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePgHeader.Location = new System.Drawing.Point(52, 0);
            this.lblHomePgHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomePgHeader.Name = "lblHomePgHeader";
            this.lblHomePgHeader.Size = new System.Drawing.Size(235, 37);
            this.lblHomePgHeader.TabIndex = 11;
            this.lblHomePgHeader.Text = "First Time Setup";
            // 
            // BtnFTSTestConnection
            // 
            this.BtnFTSTestConnection.Location = new System.Drawing.Point(624, 113);
            this.BtnFTSTestConnection.Name = "BtnFTSTestConnection";
            this.BtnFTSTestConnection.Size = new System.Drawing.Size(192, 23);
            this.BtnFTSTestConnection.TabIndex = 18;
            this.BtnFTSTestConnection.Text = "Test Connection";
            this.BtnFTSTestConnection.UseVisualStyleBackColor = true;
            // 
            // LblFTSSvrPassword
            // 
            this.LblFTSSvrPassword.AutoSize = true;
            this.LblFTSSvrPassword.Location = new System.Drawing.Point(692, 271);
            this.LblFTSSvrPassword.Name = "LblFTSSvrPassword";
            this.LblFTSSvrPassword.Size = new System.Drawing.Size(53, 13);
            this.LblFTSSvrPassword.TabIndex = 17;
            this.LblFTSSvrPassword.Text = "Password";
            // 
            // TbxFTSSvrPassword
            // 
            this.TbxFTSSvrPassword.Location = new System.Drawing.Point(624, 287);
            this.TbxFTSSvrPassword.Name = "TbxFTSSvrPassword";
            this.TbxFTSSvrPassword.Size = new System.Drawing.Size(192, 20);
            this.TbxFTSSvrPassword.TabIndex = 3;
            this.TbxFTSSvrPassword.Text = "Enter Password Here";
            this.TbxFTSSvrPassword.Click += new System.EventHandler(this.TbxFTSSvrPassword_Click);
            this.TbxFTSSvrPassword.TextChanged += new System.EventHandler(this.TbxFTSSvrPassword_TextChanged);
            this.TbxFTSSvrPassword.Leave += new System.EventHandler(this.TbxFTSSvrPassword_Leave);
            // 
            // LblFTSSvrUsrName
            // 
            this.LblFTSSvrUsrName.AutoSize = true;
            this.LblFTSSvrUsrName.Location = new System.Drawing.Point(690, 209);
            this.LblFTSSvrUsrName.Name = "LblFTSSvrUsrName";
            this.LblFTSSvrUsrName.Size = new System.Drawing.Size(55, 13);
            this.LblFTSSvrUsrName.TabIndex = 15;
            this.LblFTSSvrUsrName.Text = "Username";
            // 
            // TbxFTSSvrUsrName
            // 
            this.TbxFTSSvrUsrName.Location = new System.Drawing.Point(624, 225);
            this.TbxFTSSvrUsrName.Name = "TbxFTSSvrUsrName";
            this.TbxFTSSvrUsrName.Size = new System.Drawing.Size(192, 20);
            this.TbxFTSSvrUsrName.TabIndex = 2;
            this.TbxFTSSvrUsrName.Text = "Enter Username Here";
            this.TbxFTSSvrUsrName.Click += new System.EventHandler(this.TbxFTSSvrUsrName_Click);
            this.TbxFTSSvrUsrName.TextChanged += new System.EventHandler(this.TbxFTSSvrUsrName_TextChanged);
            this.TbxFTSSvrUsrName.Leave += new System.EventHandler(this.TbxFTSSvrUsrName_Leave);
            // 
            // LblFTSServerName
            // 
            this.LblFTSServerName.AutoSize = true;
            this.LblFTSServerName.Location = new System.Drawing.Point(699, 76);
            this.LblFTSServerName.Name = "LblFTSServerName";
            this.LblFTSServerName.Size = new System.Drawing.Size(38, 13);
            this.LblFTSServerName.TabIndex = 13;
            this.LblFTSServerName.Text = "Server";
            // 
            // TbxFTSSvrName
            // 
            this.TbxFTSSvrName.Location = new System.Drawing.Point(624, 92);
            this.TbxFTSSvrName.Name = "TbxFTSSvrName";
            this.TbxFTSSvrName.Size = new System.Drawing.Size(192, 20);
            this.TbxFTSSvrName.TabIndex = 0;
            this.TbxFTSSvrName.Text = "Enter Server Name Here";
            this.TbxFTSSvrName.Click += new System.EventHandler(this.TbxFTSSvrName_Click);
            this.TbxFTSSvrName.TextChanged += new System.EventHandler(this.TbxFTSSvrName_TextChanged);
            this.TbxFTSSvrName.Leave += new System.EventHandler(this.TbxFTSSvrName_Leave);
            // 
            // BtnFTSFinish
            // 
            this.BtnFTSFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFTSFinish.Location = new System.Drawing.Point(624, 337);
            this.BtnFTSFinish.Name = "BtnFTSFinish";
            this.BtnFTSFinish.Size = new System.Drawing.Size(192, 74);
            this.BtnFTSFinish.TabIndex = 4;
            this.BtnFTSFinish.Text = "Finish";
            this.BtnFTSFinish.UseVisualStyleBackColor = true;
            this.BtnFTSFinish.Click += new System.EventHandler(this.BtnFTSFinish_Click);
            // 
            // btnSkipSetup
            // 
            this.btnSkipSetup.Location = new System.Drawing.Point(921, 497);
            this.btnSkipSetup.Name = "btnSkipSetup";
            this.btnSkipSetup.Size = new System.Drawing.Size(93, 25);
            this.btnSkipSetup.TabIndex = 5;
            this.btnSkipSetup.Text = "Skip this step";
            this.btnSkipSetup.UseVisualStyleBackColor = true;
            this.btnSkipSetup.Click += new System.EventHandler(this.BtnSkipSetup_Click);
            // 
            // lblEnterSvrNamePrompt
            // 
            this.lblEnterSvrNamePrompt.AutoSize = true;
            this.lblEnterSvrNamePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterSvrNamePrompt.ForeColor = System.Drawing.Color.Red;
            this.lblEnterSvrNamePrompt.Location = new System.Drawing.Point(627, 139);
            this.lblEnterSvrNamePrompt.Name = "lblEnterSvrNamePrompt";
            this.lblEnterSvrNamePrompt.Size = new System.Drawing.Size(0, 13);
            this.lblEnterSvrNamePrompt.TabIndex = 21;
            // 
            // lblEnterSvrUsrNamePrompt
            // 
            this.lblEnterSvrUsrNamePrompt.AutoSize = true;
            this.lblEnterSvrUsrNamePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterSvrUsrNamePrompt.ForeColor = System.Drawing.Color.Red;
            this.lblEnterSvrUsrNamePrompt.Location = new System.Drawing.Point(627, 249);
            this.lblEnterSvrUsrNamePrompt.Name = "lblEnterSvrUsrNamePrompt";
            this.lblEnterSvrUsrNamePrompt.Size = new System.Drawing.Size(0, 13);
            this.lblEnterSvrUsrNamePrompt.TabIndex = 22;
            // 
            // lblEnterSvrPwdPrompt
            // 
            this.lblEnterSvrPwdPrompt.AutoSize = true;
            this.lblEnterSvrPwdPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterSvrPwdPrompt.ForeColor = System.Drawing.Color.Red;
            this.lblEnterSvrPwdPrompt.Location = new System.Drawing.Point(627, 350);
            this.lblEnterSvrPwdPrompt.Name = "lblEnterSvrPwdPrompt";
            this.lblEnterSvrPwdPrompt.Size = new System.Drawing.Size(0, 13);
            this.lblEnterSvrPwdPrompt.TabIndex = 23;
            // 
            // TbxFTSEnterDBName
            // 
            this.TbxFTSEnterDBName.Location = new System.Drawing.Point(624, 168);
            this.TbxFTSEnterDBName.Name = "TbxFTSEnterDBName";
            this.TbxFTSEnterDBName.Size = new System.Drawing.Size(192, 20);
            this.TbxFTSEnterDBName.TabIndex = 1;
            this.TbxFTSEnterDBName.Text = "Enter Database Name Here";
            this.TbxFTSEnterDBName.Click += new System.EventHandler(this.TbxEnterDBName_Click);
            this.TbxFTSEnterDBName.Leave += new System.EventHandler(this.TbxFTSEnterDBName_Leave);
            // 
            // LblEnterDBName
            // 
            this.LblEnterDBName.AutoSize = true;
            this.LblEnterDBName.Location = new System.Drawing.Point(644, 152);
            this.LblEnterDBName.Name = "LblEnterDBName";
            this.LblEnterDBName.Size = new System.Drawing.Size(155, 13);
            this.LblEnterDBName.TabIndex = 25;
            this.LblEnterDBName.Text = "Enter a name for your database";
            // 
            // lblDBNamePrompt
            // 
            this.lblDBNamePrompt.AutoSize = true;
            this.lblDBNamePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBNamePrompt.ForeColor = System.Drawing.Color.Red;
            this.lblDBNamePrompt.Location = new System.Drawing.Point(627, 191);
            this.lblDBNamePrompt.Name = "lblDBNamePrompt";
            this.lblDBNamePrompt.Size = new System.Drawing.Size(0, 13);
            this.lblDBNamePrompt.TabIndex = 26;
            // 
            // UCFirstSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDBNamePrompt);
            this.Controls.Add(this.LblEnterDBName);
            this.Controls.Add(this.TbxFTSEnterDBName);
            this.Controls.Add(this.lblEnterSvrPwdPrompt);
            this.Controls.Add(this.lblEnterSvrUsrNamePrompt);
            this.Controls.Add(this.lblEnterSvrNamePrompt);
            this.Controls.Add(this.btnSkipSetup);
            this.Controls.Add(this.BtnFTSFinish);
            this.Controls.Add(this.BtnFTSTestConnection);
            this.Controls.Add(this.LblFTSSvrPassword);
            this.Controls.Add(this.TbxFTSSvrPassword);
            this.Controls.Add(this.LblFTSSvrUsrName);
            this.Controls.Add(this.TbxFTSSvrUsrName);
            this.Controls.Add(this.LblFTSServerName);
            this.Controls.Add(this.TbxFTSSvrName);
            this.Controls.Add(this.lblHomePgHeader);
            this.Controls.Add(this.lblFirstSetupDesc);
            this.Name = "UCFirstSetup";
            this.Size = new System.Drawing.Size(1034, 542);
            this.Load += new System.EventHandler(this.FirstSetupUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstSetupDesc;
        private System.Windows.Forms.Label lblHomePgHeader;
        private System.Windows.Forms.Button BtnFTSTestConnection;
        private System.Windows.Forms.Label LblFTSSvrPassword;
        private System.Windows.Forms.TextBox TbxFTSSvrPassword;
        private System.Windows.Forms.Label LblFTSSvrUsrName;
        private System.Windows.Forms.TextBox TbxFTSSvrUsrName;
        private System.Windows.Forms.Label LblFTSServerName;
        private System.Windows.Forms.TextBox TbxFTSSvrName;
        private System.Windows.Forms.Button BtnFTSFinish;
        private System.Windows.Forms.Button btnSkipSetup;
        private System.Windows.Forms.Label lblEnterSvrNamePrompt;
        private System.Windows.Forms.Label lblEnterSvrUsrNamePrompt;
        private System.Windows.Forms.Label lblEnterSvrPwdPrompt;
        private System.Windows.Forms.TextBox TbxFTSEnterDBName;
        private System.Windows.Forms.Label LblEnterDBName;
        private System.Windows.Forms.Label lblDBNamePrompt;
    }
}
