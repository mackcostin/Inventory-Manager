namespace Inventory_Manager
{
    partial class MainForm
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
            this.userControlPanel = new System.Windows.Forms.Panel();
            this.menuDock.SuspendLayout();
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
            this.menuDock.Name = "menuDock";
            this.menuDock.Size = new System.Drawing.Size(203, 652);
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
            this.btnManageInventory.Location = new System.Drawing.Point(0, 168);
            this.btnManageInventory.Name = "btnManageInventory";
            this.btnManageInventory.Size = new System.Drawing.Size(200, 163);
            this.btnManageInventory.TabIndex = 3;
            this.btnManageInventory.Text = "Manage Inventory";
            this.btnManageInventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManageInventory.UseVisualStyleBackColor = true;
            this.btnManageInventory.Click += new System.EventHandler(this.btnManageInventory_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::Inventory_Manager.Properties.Resources.icons8_search_50;
            this.btnSearch.Location = new System.Drawing.Point(0, 337);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 145);
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
            this.btnSettings.Location = new System.Drawing.Point(0, 488);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 163);
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
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 163);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(203, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 20);
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
            this.btnCloseApp.Location = new System.Drawing.Point(995, 22);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(55, 42);
            this.btnCloseApp.TabIndex = 4;
            this.btnCloseApp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // userControlPanel
            // 
            this.userControlPanel.Location = new System.Drawing.Point(203, 71);
            this.userControlPanel.Name = "userControlPanel";
            this.userControlPanel.Size = new System.Drawing.Size(847, 581);
            this.userControlPanel.TabIndex = 5;
            this.userControlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.userControlPanel_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1050, 652);
            this.Controls.Add(this.userControlPanel);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuDock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuDock.ResumeLayout(false);
            this.menuDock.PerformLayout();
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
        private System.Windows.Forms.Panel userControlPanel;
    }
}

