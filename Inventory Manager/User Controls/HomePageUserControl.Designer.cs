namespace Inventory_Manager.User_Controls
{
    partial class HomePageUserControl
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
            this.tbxSvrName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblSvrUsrName = new System.Windows.Forms.Label();
            this.tbxSvrUsrName = new System.Windows.Forms.TextBox();
            this.lblSvrPassword = new System.Windows.Forms.Label();
            this.tbxSvrPassword = new System.Windows.Forms.TextBox();
            this.lblDBName = new System.Windows.Forms.Label();
            this.cmbDatabases = new System.Windows.Forms.ComboBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxSvrName
            // 
            this.tbxSvrName.Location = new System.Drawing.Point(338, 141);
            this.tbxSvrName.Name = "tbxSvrName";
            this.tbxSvrName.Size = new System.Drawing.Size(192, 20);
            this.tbxSvrName.TabIndex = 0;
            this.tbxSvrName.Text = "Enter Server Name Here";
            this.tbxSvrName.Click += new System.EventHandler(this.tbxSvrName_Click);
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(417, 125);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(38, 13);
            this.lblServerName.TabIndex = 1;
            this.lblServerName.Text = "Server";
            // 
            // lblSvrUsrName
            // 
            this.lblSvrUsrName.AutoSize = true;
            this.lblSvrUsrName.Location = new System.Drawing.Point(405, 221);
            this.lblSvrUsrName.Name = "lblSvrUsrName";
            this.lblSvrUsrName.Size = new System.Drawing.Size(55, 13);
            this.lblSvrUsrName.TabIndex = 3;
            this.lblSvrUsrName.Text = "Username";
            // 
            // tbxSvrUsrName
            // 
            this.tbxSvrUsrName.Location = new System.Drawing.Point(338, 237);
            this.tbxSvrUsrName.Name = "tbxSvrUsrName";
            this.tbxSvrUsrName.Size = new System.Drawing.Size(192, 20);
            this.tbxSvrUsrName.TabIndex = 2;
            this.tbxSvrUsrName.Text = "Enter Username Here";
            this.tbxSvrUsrName.Click += new System.EventHandler(this.tbxSvrUsrName_Click);
            // 
            // lblSvrPassword
            // 
            this.lblSvrPassword.AutoSize = true;
            this.lblSvrPassword.Location = new System.Drawing.Point(407, 271);
            this.lblSvrPassword.Name = "lblSvrPassword";
            this.lblSvrPassword.Size = new System.Drawing.Size(53, 13);
            this.lblSvrPassword.TabIndex = 5;
            this.lblSvrPassword.Text = "Password";
            // 
            // tbxSvrPassword
            // 
            this.tbxSvrPassword.Location = new System.Drawing.Point(338, 287);
            this.tbxSvrPassword.Name = "tbxSvrPassword";
            this.tbxSvrPassword.Size = new System.Drawing.Size(192, 20);
            this.tbxSvrPassword.TabIndex = 4;
            this.tbxSvrPassword.Text = "Enter Password Here";
            this.tbxSvrPassword.Click += new System.EventHandler(this.tbxSvrPassword_Click);
            // 
            // lblDBName
            // 
            this.lblDBName.AutoSize = true;
            this.lblDBName.Location = new System.Drawing.Point(405, 320);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(53, 13);
            this.lblDBName.TabIndex = 7;
            this.lblDBName.Text = "Database";
            // 
            // cmbDatabases
            // 
            this.cmbDatabases.FormattingEnabled = true;
            this.cmbDatabases.Location = new System.Drawing.Point(338, 336);
            this.cmbDatabases.Name = "cmbDatabases";
            this.cmbDatabases.Size = new System.Drawing.Size(192, 21);
            this.cmbDatabases.TabIndex = 8;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(338, 162);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(192, 23);
            this.btnTestConnection.TabIndex = 9;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            // 
            // HomePageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.cmbDatabases);
            this.Controls.Add(this.lblDBName);
            this.Controls.Add(this.lblSvrPassword);
            this.Controls.Add(this.tbxSvrPassword);
            this.Controls.Add(this.lblSvrUsrName);
            this.Controls.Add(this.tbxSvrUsrName);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.tbxSvrName);
            this.Name = "HomePageUserControl";
            this.Size = new System.Drawing.Size(847, 581);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSvrName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label lblSvrUsrName;
        private System.Windows.Forms.TextBox tbxSvrUsrName;
        private System.Windows.Forms.Label lblSvrPassword;
        private System.Windows.Forms.TextBox tbxSvrPassword;
        private System.Windows.Forms.Label lblDBName;
        private System.Windows.Forms.ComboBox cmbDatabases;
        private System.Windows.Forms.Button btnTestConnection;
    }
}
