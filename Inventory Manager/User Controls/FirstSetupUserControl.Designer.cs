namespace Inventory_Manager.User_Controls
{
    partial class FirstSetupUserControl
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
            this.LblFTSSvrPassword.Location = new System.Drawing.Point(692, 222);
            this.LblFTSSvrPassword.Name = "LblFTSSvrPassword";
            this.LblFTSSvrPassword.Size = new System.Drawing.Size(53, 13);
            this.LblFTSSvrPassword.TabIndex = 17;
            this.LblFTSSvrPassword.Text = "Password";
            // 
            // TbxFTSSvrPassword
            // 
            this.TbxFTSSvrPassword.Location = new System.Drawing.Point(624, 238);
            this.TbxFTSSvrPassword.Name = "TbxFTSSvrPassword";
            this.TbxFTSSvrPassword.Size = new System.Drawing.Size(192, 20);
            this.TbxFTSSvrPassword.TabIndex = 16;
            this.TbxFTSSvrPassword.Text = "Enter Password Here";
            this.TbxFTSSvrPassword.Click += new System.EventHandler(this.TbxFTSSvrPassword_Click);
            // 
            // LblFTSSvrUsrName
            // 
            this.LblFTSSvrUsrName.AutoSize = true;
            this.LblFTSSvrUsrName.Location = new System.Drawing.Point(690, 172);
            this.LblFTSSvrUsrName.Name = "LblFTSSvrUsrName";
            this.LblFTSSvrUsrName.Size = new System.Drawing.Size(55, 13);
            this.LblFTSSvrUsrName.TabIndex = 15;
            this.LblFTSSvrUsrName.Text = "Username";
            // 
            // TbxFTSSvrUsrName
            // 
            this.TbxFTSSvrUsrName.Location = new System.Drawing.Point(624, 188);
            this.TbxFTSSvrUsrName.Name = "TbxFTSSvrUsrName";
            this.TbxFTSSvrUsrName.Size = new System.Drawing.Size(192, 20);
            this.TbxFTSSvrUsrName.TabIndex = 14;
            this.TbxFTSSvrUsrName.Text = "Enter Username Here";
            this.TbxFTSSvrUsrName.Click += new System.EventHandler(this.TbxFTSSvrUsrName_Click);
            this.TbxFTSSvrUsrName.TextChanged += new System.EventHandler(this.TbxFTSSvrUsrName_TextChanged);
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
            this.TbxFTSSvrName.TabIndex = 12;
            this.TbxFTSSvrName.Text = "Enter Server Name Here";
            this.TbxFTSSvrName.Click += new System.EventHandler(this.TbxFTSSvrName_Click);
            // 
            // BtnFTSFinish
            // 
            this.BtnFTSFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFTSFinish.Location = new System.Drawing.Point(635, 326);
            this.BtnFTSFinish.Name = "BtnFTSFinish";
            this.BtnFTSFinish.Size = new System.Drawing.Size(171, 74);
            this.BtnFTSFinish.TabIndex = 19;
            this.BtnFTSFinish.Text = "Finish";
            this.BtnFTSFinish.UseVisualStyleBackColor = true;
            this.BtnFTSFinish.Click += new System.EventHandler(this.BtnFTSFinish_Click);
            // 
            // FirstSetupUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "FirstSetupUserControl";
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
    }
}
