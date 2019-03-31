namespace Inventory_Manager.User_Controls
{
    partial class UCSettings
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
            this.lblDBNamePrompt = new System.Windows.Forms.Label();
            this.LblEnterDBName = new System.Windows.Forms.Label();
            this.TbxDBName = new System.Windows.Forms.TextBox();
            this.lblEnterSvrUsrNamePrompt = new System.Windows.Forms.Label();
            this.lblEnterSvrNamePrompt = new System.Windows.Forms.Label();
            this.BtnFTSTestConnection = new System.Windows.Forms.Button();
            this.LblFTSSvrPassword = new System.Windows.Forms.Label();
            this.TbxSvrPass = new System.Windows.Forms.TextBox();
            this.LblFTSSvrUsrName = new System.Windows.Forms.Label();
            this.TbxSvrUsrName = new System.Windows.Forms.TextBox();
            this.LblFTSServerName = new System.Windows.Forms.Label();
            this.TbxSvrName = new System.Windows.Forms.TextBox();
            this.lblHomePgHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDBNamePrompt
            // 
            this.lblDBNamePrompt.AutoSize = true;
            this.lblDBNamePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBNamePrompt.ForeColor = System.Drawing.Color.Red;
            this.lblDBNamePrompt.Location = new System.Drawing.Point(340, 264);
            this.lblDBNamePrompt.Name = "lblDBNamePrompt";
            this.lblDBNamePrompt.Size = new System.Drawing.Size(0, 13);
            this.lblDBNamePrompt.TabIndex = 38;
            // 
            // LblEnterDBName
            // 
            this.LblEnterDBName.AutoSize = true;
            this.LblEnterDBName.Location = new System.Drawing.Point(357, 225);
            this.LblEnterDBName.Name = "LblEnterDBName";
            this.LblEnterDBName.Size = new System.Drawing.Size(155, 13);
            this.LblEnterDBName.TabIndex = 37;
            this.LblEnterDBName.Text = "Enter a name for your database";
            // 
            // TbxDBName
            // 
            this.TbxDBName.Location = new System.Drawing.Point(337, 241);
            this.TbxDBName.Name = "TbxDBName";
            this.TbxDBName.Size = new System.Drawing.Size(192, 20);
            this.TbxDBName.TabIndex = 36;
            this.TbxDBName.Text = "Enter Database Name Here";
            // 
            // lblEnterSvrUsrNamePrompt
            // 
            this.lblEnterSvrUsrNamePrompt.AutoSize = true;
            this.lblEnterSvrUsrNamePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterSvrUsrNamePrompt.ForeColor = System.Drawing.Color.Red;
            this.lblEnterSvrUsrNamePrompt.Location = new System.Drawing.Point(340, 322);
            this.lblEnterSvrUsrNamePrompt.Name = "lblEnterSvrUsrNamePrompt";
            this.lblEnterSvrUsrNamePrompt.Size = new System.Drawing.Size(0, 13);
            this.lblEnterSvrUsrNamePrompt.TabIndex = 35;
            // 
            // lblEnterSvrNamePrompt
            // 
            this.lblEnterSvrNamePrompt.AutoSize = true;
            this.lblEnterSvrNamePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterSvrNamePrompt.ForeColor = System.Drawing.Color.Red;
            this.lblEnterSvrNamePrompt.Location = new System.Drawing.Point(340, 212);
            this.lblEnterSvrNamePrompt.Name = "lblEnterSvrNamePrompt";
            this.lblEnterSvrNamePrompt.Size = new System.Drawing.Size(0, 13);
            this.lblEnterSvrNamePrompt.TabIndex = 34;
            // 
            // BtnFTSTestConnection
            // 
            this.BtnFTSTestConnection.Location = new System.Drawing.Point(337, 186);
            this.BtnFTSTestConnection.Name = "BtnFTSTestConnection";
            this.BtnFTSTestConnection.Size = new System.Drawing.Size(192, 23);
            this.BtnFTSTestConnection.TabIndex = 33;
            this.BtnFTSTestConnection.Text = "Test Connection";
            this.BtnFTSTestConnection.UseVisualStyleBackColor = true;
            // 
            // LblFTSSvrPassword
            // 
            this.LblFTSSvrPassword.AutoSize = true;
            this.LblFTSSvrPassword.Location = new System.Drawing.Point(405, 344);
            this.LblFTSSvrPassword.Name = "LblFTSSvrPassword";
            this.LblFTSSvrPassword.Size = new System.Drawing.Size(53, 13);
            this.LblFTSSvrPassword.TabIndex = 32;
            this.LblFTSSvrPassword.Text = "Password";
            // 
            // TbxSvrPass
            // 
            this.TbxSvrPass.Location = new System.Drawing.Point(337, 360);
            this.TbxSvrPass.Name = "TbxSvrPass";
            this.TbxSvrPass.Size = new System.Drawing.Size(192, 20);
            this.TbxSvrPass.TabIndex = 31;
            this.TbxSvrPass.Text = "Enter Password Here";
            // 
            // LblFTSSvrUsrName
            // 
            this.LblFTSSvrUsrName.AutoSize = true;
            this.LblFTSSvrUsrName.Location = new System.Drawing.Point(403, 282);
            this.LblFTSSvrUsrName.Name = "LblFTSSvrUsrName";
            this.LblFTSSvrUsrName.Size = new System.Drawing.Size(55, 13);
            this.LblFTSSvrUsrName.TabIndex = 30;
            this.LblFTSSvrUsrName.Text = "Username";
            // 
            // TbxSvrUsrName
            // 
            this.TbxSvrUsrName.Location = new System.Drawing.Point(337, 298);
            this.TbxSvrUsrName.Name = "TbxSvrUsrName";
            this.TbxSvrUsrName.Size = new System.Drawing.Size(192, 20);
            this.TbxSvrUsrName.TabIndex = 29;
            this.TbxSvrUsrName.Text = "Enter Username Here";
            // 
            // LblFTSServerName
            // 
            this.LblFTSServerName.AutoSize = true;
            this.LblFTSServerName.Location = new System.Drawing.Point(412, 149);
            this.LblFTSServerName.Name = "LblFTSServerName";
            this.LblFTSServerName.Size = new System.Drawing.Size(38, 13);
            this.LblFTSServerName.TabIndex = 28;
            this.LblFTSServerName.Text = "Server";
            // 
            // TbxSvrName
            // 
            this.TbxSvrName.Location = new System.Drawing.Point(337, 165);
            this.TbxSvrName.Name = "TbxSvrName";
            this.TbxSvrName.Size = new System.Drawing.Size(192, 20);
            this.TbxSvrName.TabIndex = 27;
            this.TbxSvrName.Text = "Enter Server Name Here";
            // 
            // lblHomePgHeader
            // 
            this.lblHomePgHeader.AutoSize = true;
            this.lblHomePgHeader.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePgHeader.Location = new System.Drawing.Point(52, 0);
            this.lblHomePgHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomePgHeader.Name = "lblHomePgHeader";
            this.lblHomePgHeader.Size = new System.Drawing.Size(128, 37);
            this.lblHomePgHeader.TabIndex = 39;
            this.lblHomePgHeader.Text = "Settings";
            // 
            // UCSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHomePgHeader);
            this.Controls.Add(this.lblDBNamePrompt);
            this.Controls.Add(this.LblEnterDBName);
            this.Controls.Add(this.TbxDBName);
            this.Controls.Add(this.lblEnterSvrUsrNamePrompt);
            this.Controls.Add(this.lblEnterSvrNamePrompt);
            this.Controls.Add(this.BtnFTSTestConnection);
            this.Controls.Add(this.LblFTSSvrPassword);
            this.Controls.Add(this.TbxSvrPass);
            this.Controls.Add(this.LblFTSSvrUsrName);
            this.Controls.Add(this.TbxSvrUsrName);
            this.Controls.Add(this.LblFTSServerName);
            this.Controls.Add(this.TbxSvrName);
            this.Name = "UCSettings";
            this.Size = new System.Drawing.Size(847, 581);
            this.Load += new System.EventHandler(this.UCSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDBNamePrompt;
        private System.Windows.Forms.Label LblEnterDBName;
        private System.Windows.Forms.TextBox TbxDBName;
        private System.Windows.Forms.Label lblEnterSvrUsrNamePrompt;
        private System.Windows.Forms.Label lblEnterSvrNamePrompt;
        private System.Windows.Forms.Button BtnFTSTestConnection;
        private System.Windows.Forms.Label LblFTSSvrPassword;
        private System.Windows.Forms.TextBox TbxSvrPass;
        private System.Windows.Forms.Label LblFTSSvrUsrName;
        private System.Windows.Forms.TextBox TbxSvrUsrName;
        private System.Windows.Forms.Label LblFTSServerName;
        private System.Windows.Forms.TextBox TbxSvrName;
        private System.Windows.Forms.Label lblHomePgHeader;
    }
}
