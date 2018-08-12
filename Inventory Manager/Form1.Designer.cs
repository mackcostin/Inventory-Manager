namespace Inventory_Manager
{
    partial class Form1
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
            this.menuDock = new System.Windows.Forms.Panel();
            this.btnManageInventory = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.manageInventoryUserControl2 = new Inventory_Manager.ManageInventoryUserControl();
            this.manageInventoryUserControl = new Inventory_Manager.ManageInventoryUserControl();
            this.homePageUserControl1 = new Inventory_Manager.HomePageUserControl();
            this.menuDock.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuDock
            // 
            this.menuDock.AutoSize = true;
            this.menuDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.menuDock.Controls.Add(this.btnManageInventory);
            this.menuDock.Controls.Add(this.btnSearch);
            this.menuDock.Controls.Add(this.btnSettings);
            this.menuDock.Controls.Add(this.btnHome);
            this.menuDock.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuDock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuDock.Location = new System.Drawing.Point(0, 0);
            this.menuDock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuDock.Name = "menuDock";
            this.menuDock.Size = new System.Drawing.Size(304, 1003);
            this.menuDock.TabIndex = 2;
            // 
            // btnManageInventory
            // 
            this.btnManageInventory.AutoSize = true;
            this.btnManageInventory.FlatAppearance.BorderSize = 0;
            this.btnManageInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageInventory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageInventory.ForeColor = System.Drawing.Color.White;
            this.btnManageInventory.Image = global::Inventory_Manager.Properties.Resources.icons8_in_inventory_64;
            this.btnManageInventory.Location = new System.Drawing.Point(0, 258);
            this.btnManageInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManageInventory.Name = "btnManageInventory";
            this.btnManageInventory.Size = new System.Drawing.Size(300, 251);
            this.btnManageInventory.TabIndex = 3;
            this.btnManageInventory.Text = "Manage Inventory";
            this.btnManageInventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManageInventory.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::Inventory_Manager.Properties.Resources.icons8_search_50;
            this.btnSearch.Location = new System.Drawing.Point(0, 518);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(300, 223);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search Inventory";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.AutoSize = true;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::Inventory_Manager.Properties.Resources.icons8_settings_filled_50__1_;
            this.btnSettings.Location = new System.Drawing.Point(0, 751);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(300, 251);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::Inventory_Manager.Properties.Resources.icons8_home_filled_50;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(300, 251);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(304, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1271, 31);
            this.panel2.TabIndex = 3;
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.AutoSize = true;
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseApp.ForeColor = System.Drawing.Color.White;
            this.btnCloseApp.Image = global::Inventory_Manager.Properties.Resources.icons8_shutdown_30;
            this.btnCloseApp.Location = new System.Drawing.Point(1492, 34);
            this.btnCloseApp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(82, 65);
            this.btnCloseApp.TabIndex = 4;
            this.btnCloseApp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homePageUserControl1);
            this.panel1.Controls.Add(this.manageInventoryUserControl2);
            this.panel1.Controls.Add(this.manageInventoryUserControl);
            this.panel1.Location = new System.Drawing.Point(304, 109);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 894);
            this.panel1.TabIndex = 5;
            // 
            // manageInventoryUserControl2
            // 
            this.manageInventoryUserControl2.Location = new System.Drawing.Point(400, 377);
            this.manageInventoryUserControl2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.manageInventoryUserControl2.Name = "manageInventoryUserControl2";
            this.manageInventoryUserControl2.Size = new System.Drawing.Size(12, 12);
            this.manageInventoryUserControl2.TabIndex = 1;
            // 
            // manageInventoryUserControl
            // 
            this.manageInventoryUserControl.AutoSize = true;
            this.manageInventoryUserControl.Location = new System.Drawing.Point(0, 8);
            this.manageInventoryUserControl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.manageInventoryUserControl.Name = "manageInventoryUserControl";
            this.manageInventoryUserControl.Size = new System.Drawing.Size(1270, 905);
            this.manageInventoryUserControl.TabIndex = 0;
            this.manageInventoryUserControl.Load += new System.EventHandler(this.manageInventoryUserControl_Load);
            // 
            // homePageUserControl1
            // 
            this.homePageUserControl1.AutoSize = true;
            this.homePageUserControl1.Location = new System.Drawing.Point(0, 0);
            this.homePageUserControl1.Name = "homePageUserControl1";
            this.homePageUserControl1.Size = new System.Drawing.Size(1275, 895);
            this.homePageUserControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1575, 1003);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuDock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuDock.ResumeLayout(false);
            this.menuDock.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel menuDock;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnManageInventory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCloseApp;
        private ManageInventoryUserControl manageInventoryUserControl;
        private ManageInventoryUserControl manageInventoryUserControl2;
        private System.Windows.Forms.Panel panel1;
        private HomePageUserControl homePageUserControl1;
    }
}

