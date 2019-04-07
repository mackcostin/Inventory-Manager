namespace Inventory_Manager.Forms
{
    partial class FormLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblEnterPasswordPrompt = new System.Windows.Forms.Label();
            this.LblEnterUserNamePrompt = new System.Windows.Forms.Label();
            this.LblEnterDBNamePrompt = new System.Windows.Forms.Label();
            this.LblEnterSvrNamePrompt = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxDBPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxDBUsername = new System.Windows.Forms.TextBox();
            this.TbxDBName = new System.Windows.Forms.TextBox();
            this.TbxDBSvrName = new System.Windows.Forms.TextBox();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEnterPasswordPrompt
            // 
            this.LblEnterPasswordPrompt.AutoSize = true;
            this.LblEnterPasswordPrompt.BackColor = System.Drawing.Color.Transparent;
            this.LblEnterPasswordPrompt.ForeColor = System.Drawing.Color.Red;
            this.LblEnterPasswordPrompt.Location = new System.Drawing.Point(142, 287);
            this.LblEnterPasswordPrompt.Name = "LblEnterPasswordPrompt";
            this.LblEnterPasswordPrompt.Size = new System.Drawing.Size(0, 13);
            this.LblEnterPasswordPrompt.TabIndex = 27;
            // 
            // LblEnterUserNamePrompt
            // 
            this.LblEnterUserNamePrompt.AutoSize = true;
            this.LblEnterUserNamePrompt.BackColor = System.Drawing.Color.Transparent;
            this.LblEnterUserNamePrompt.ForeColor = System.Drawing.Color.Red;
            this.LblEnterUserNamePrompt.Location = new System.Drawing.Point(142, 226);
            this.LblEnterUserNamePrompt.Name = "LblEnterUserNamePrompt";
            this.LblEnterUserNamePrompt.Size = new System.Drawing.Size(0, 13);
            this.LblEnterUserNamePrompt.TabIndex = 26;
            // 
            // LblEnterDBNamePrompt
            // 
            this.LblEnterDBNamePrompt.AutoSize = true;
            this.LblEnterDBNamePrompt.BackColor = System.Drawing.Color.Transparent;
            this.LblEnterDBNamePrompt.ForeColor = System.Drawing.Color.Red;
            this.LblEnterDBNamePrompt.Location = new System.Drawing.Point(142, 166);
            this.LblEnterDBNamePrompt.Name = "LblEnterDBNamePrompt";
            this.LblEnterDBNamePrompt.Size = new System.Drawing.Size(0, 13);
            this.LblEnterDBNamePrompt.TabIndex = 25;
            // 
            // LblEnterSvrNamePrompt
            // 
            this.LblEnterSvrNamePrompt.AutoSize = true;
            this.LblEnterSvrNamePrompt.BackColor = System.Drawing.Color.Transparent;
            this.LblEnterSvrNamePrompt.ForeColor = System.Drawing.Color.Red;
            this.LblEnterSvrNamePrompt.Location = new System.Drawing.Point(142, 108);
            this.LblEnterSvrNamePrompt.Name = "LblEnterSvrNamePrompt";
            this.LblEnterSvrNamePrompt.Size = new System.Drawing.Size(0, 13);
            this.LblEnterSvrNamePrompt.TabIndex = 24;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(142, 310);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(193, 54);
            this.BtnLogin.TabIndex = 23;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "Inventory Manager";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(207, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Password";
            // 
            // TbxDBPassword
            // 
            this.TbxDBPassword.ForeColor = System.Drawing.Color.Gray;
            this.TbxDBPassword.Location = new System.Drawing.Point(142, 264);
            this.TbxDBPassword.Name = "TbxDBPassword";
            this.TbxDBPassword.Size = new System.Drawing.Size(193, 20);
            this.TbxDBPassword.TabIndex = 20;
            this.TbxDBPassword.Text = "Enter a Password";
            this.TbxDBPassword.Enter += new System.EventHandler(this.TbxDBPassword_Enter);
            this.TbxDBPassword.Leave += new System.EventHandler(this.TbxDBPassword_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(207, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(196, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Datbase Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(205, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Server Name";
            // 
            // TbxDBUsername
            // 
            this.TbxDBUsername.ForeColor = System.Drawing.Color.Gray;
            this.TbxDBUsername.Location = new System.Drawing.Point(142, 203);
            this.TbxDBUsername.Name = "TbxDBUsername";
            this.TbxDBUsername.Size = new System.Drawing.Size(193, 20);
            this.TbxDBUsername.TabIndex = 16;
            this.TbxDBUsername.Text = "Enter a Username";
            this.TbxDBUsername.Enter += new System.EventHandler(this.TbxDBUsername_Enter);
            this.TbxDBUsername.Leave += new System.EventHandler(this.TbxDBUsername_Leave);
            // 
            // TbxDBName
            // 
            this.TbxDBName.ForeColor = System.Drawing.Color.Gray;
            this.TbxDBName.Location = new System.Drawing.Point(142, 143);
            this.TbxDBName.Name = "TbxDBName";
            this.TbxDBName.Size = new System.Drawing.Size(193, 20);
            this.TbxDBName.TabIndex = 15;
            this.TbxDBName.Text = "Enter a Database Name";
            this.TbxDBName.Enter += new System.EventHandler(this.TbxDBName_Enter);
            this.TbxDBName.Leave += new System.EventHandler(this.TbxDBName_Leave);
            // 
            // TbxDBSvrName
            // 
            this.TbxDBSvrName.ForeColor = System.Drawing.Color.Gray;
            this.TbxDBSvrName.Location = new System.Drawing.Point(142, 85);
            this.TbxDBSvrName.Name = "TbxDBSvrName";
            this.TbxDBSvrName.Size = new System.Drawing.Size(193, 20);
            this.TbxDBSvrName.TabIndex = 14;
            this.TbxDBSvrName.Text = "Enter a Server Name";
            this.TbxDBSvrName.Enter += new System.EventHandler(this.TbxDBSvrName_Enter);
            this.TbxDBSvrName.Leave += new System.EventHandler(this.TbxSvrName_Leave);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.AutoSize = true;
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseApp.ForeColor = System.Drawing.Color.White;
            this.btnCloseApp.Image = global::Inventory_Manager.Properties.Resources.icons8_shutdown_30;
            this.btnCloseApp.Location = new System.Drawing.Point(417, 2);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(55, 42);
            this.btnCloseApp.TabIndex = 29;
            this.btnCloseApp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.BtnCloseApp_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(474, 399);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.LblEnterPasswordPrompt);
            this.Controls.Add(this.LblEnterUserNamePrompt);
            this.Controls.Add(this.LblEnterDBNamePrompt);
            this.Controls.Add(this.LblEnterSvrNamePrompt);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbxDBPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxDBUsername);
            this.Controls.Add(this.TbxDBName);
            this.Controls.Add(this.TbxDBSvrName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEnterPasswordPrompt;
        private System.Windows.Forms.Label LblEnterUserNamePrompt;
        private System.Windows.Forms.Label LblEnterDBNamePrompt;
        private System.Windows.Forms.Label LblEnterSvrNamePrompt;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbxDBPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxDBUsername;
        private System.Windows.Forms.TextBox TbxDBName;
        private System.Windows.Forms.TextBox TbxDBSvrName;
        private System.Windows.Forms.Button btnCloseApp;
    }
}