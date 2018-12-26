namespace Inventory_Manager.User_Controls
{
    partial class HomeUserControl
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
            this.lblSvrName = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.tbxSvrName = new System.Windows.Forms.TextBox();
            this.btnTestSvrConnection = new System.Windows.Forms.Button();
            this.lblSvrUsrName = new System.Windows.Forms.Label();
            this.tbxSvrUsrName = new System.Windows.Forms.TextBox();
            this.tbxSvrPassword = new System.Windows.Forms.TextBox();
            this.lblSvrPassword = new System.Windows.Forms.Label();
            this.lblDBName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlConnectionStatus = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblSvrName
            // 
            this.lblSvrName.AutoSize = true;
            this.lblSvrName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvrName.Location = new System.Drawing.Point(411, 149);
            this.lblSvrName.Name = "lblSvrName";
            this.lblSvrName.Size = new System.Drawing.Size(47, 17);
            this.lblSvrName.TabIndex = 0;
            this.lblSvrName.Text = "Server";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(53, 0);
            this.lblHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(103, 37);
            this.lblHome.TabIndex = 3;
            this.lblHome.Text = "Home";
            // 
            // tbxSvrName
            // 
            this.tbxSvrName.ForeColor = System.Drawing.Color.Black;
            this.tbxSvrName.Location = new System.Drawing.Point(337, 169);
            this.tbxSvrName.Name = "tbxSvrName";
            this.tbxSvrName.Size = new System.Drawing.Size(193, 20);
            this.tbxSvrName.TabIndex = 4;
            this.tbxSvrName.Text = "Enter Server Name Here";
            this.tbxSvrName.Click += new System.EventHandler(this.tbxSvrName_Click);
            // 
            // btnTestSvrConnection
            // 
            this.btnTestSvrConnection.Location = new System.Drawing.Point(337, 191);
            this.btnTestSvrConnection.Name = "btnTestSvrConnection";
            this.btnTestSvrConnection.Size = new System.Drawing.Size(193, 23);
            this.btnTestSvrConnection.TabIndex = 5;
            this.btnTestSvrConnection.Text = "Test Connection";
            this.btnTestSvrConnection.UseVisualStyleBackColor = true;
            // 
            // lblSvrUsrName
            // 
            this.lblSvrUsrName.AutoSize = true;
            this.lblSvrUsrName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvrUsrName.Location = new System.Drawing.Point(399, 238);
            this.lblSvrUsrName.Name = "lblSvrUsrName";
            this.lblSvrUsrName.Size = new System.Drawing.Size(67, 17);
            this.lblSvrUsrName.TabIndex = 6;
            this.lblSvrUsrName.Text = "Username";
            // 
            // tbxSvrUsrName
            // 
            this.tbxSvrUsrName.Location = new System.Drawing.Point(337, 258);
            this.tbxSvrUsrName.Name = "tbxSvrUsrName";
            this.tbxSvrUsrName.Size = new System.Drawing.Size(193, 20);
            this.tbxSvrUsrName.TabIndex = 7;
            this.tbxSvrUsrName.Text = "Enter Username Here";
            this.tbxSvrUsrName.Click += new System.EventHandler(this.tbxSvrUsrName_Click);
            // 
            // tbxSvrPassword
            // 
            this.tbxSvrPassword.Location = new System.Drawing.Point(337, 313);
            this.tbxSvrPassword.Name = "tbxSvrPassword";
            this.tbxSvrPassword.Size = new System.Drawing.Size(193, 20);
            this.tbxSvrPassword.TabIndex = 9;
            this.tbxSvrPassword.Text = "Enter Password Here";
            this.tbxSvrPassword.Click += new System.EventHandler(this.tbxSvrPassword_Click);
            // 
            // lblSvrPassword
            // 
            this.lblSvrPassword.AutoSize = true;
            this.lblSvrPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvrPassword.Location = new System.Drawing.Point(399, 293);
            this.lblSvrPassword.Name = "lblSvrPassword";
            this.lblSvrPassword.Size = new System.Drawing.Size(63, 17);
            this.lblSvrPassword.TabIndex = 8;
            this.lblSvrPassword.Text = "Password";
            // 
            // lblDBName
            // 
            this.lblDBName.AutoSize = true;
            this.lblDBName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBName.Location = new System.Drawing.Point(399, 348);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(67, 17);
            this.lblDBName.TabIndex = 10;
            this.lblDBName.Text = "Database";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(337, 368);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // pnlConnectionStatus
            // 
            this.pnlConnectionStatus.BackColor = System.Drawing.Color.Red;
            this.pnlConnectionStatus.Location = new System.Drawing.Point(321, 169);
            this.pnlConnectionStatus.Name = "pnlConnectionStatus";
            this.pnlConnectionStatus.Size = new System.Drawing.Size(17, 45);
            this.pnlConnectionStatus.TabIndex = 13;
            this.pnlConnectionStatus.Visible = false;
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlConnectionStatus);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblDBName);
            this.Controls.Add(this.tbxSvrPassword);
            this.Controls.Add(this.lblSvrPassword);
            this.Controls.Add(this.tbxSvrUsrName);
            this.Controls.Add(this.lblSvrUsrName);
            this.Controls.Add(this.btnTestSvrConnection);
            this.Controls.Add(this.tbxSvrName);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblSvrName);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(847, 581);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSvrName;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.TextBox tbxSvrName;
        private System.Windows.Forms.Button btnTestSvrConnection;
        private System.Windows.Forms.Label lblSvrUsrName;
        private System.Windows.Forms.TextBox tbxSvrUsrName;
        private System.Windows.Forms.TextBox tbxSvrPassword;
        private System.Windows.Forms.Label lblSvrPassword;
        private System.Windows.Forms.Label lblDBName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnlConnectionStatus;
    }
}
