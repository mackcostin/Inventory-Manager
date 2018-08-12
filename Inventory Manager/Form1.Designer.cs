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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnManageInventory = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.manageInventoryUserControl = new Inventory_Manager.ManageInventoryUserControl();
            this.manageInventoryUserControl2 = new Inventory_Manager.ManageInventoryUserControl();
            this.menuDock.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuDock
            // 
            this.menuDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.menuDock.Controls.Add(this.btnManageInventory);
            this.menuDock.Controls.Add(this.btnSearch);
            this.menuDock.Controls.Add(this.btnSettings);
            this.menuDock.Controls.Add(this.btnHome);
            this.menuDock.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuDock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuDock.Location = new System.Drawing.Point(0, 0);
            this.menuDock.Name = "menuDock";
            this.menuDock.Size = new System.Drawing.Size(200, 652);
            this.menuDock.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 20);
            this.panel2.TabIndex = 3;
            // 
            // btnManageInventory
            // 
            this.btnManageInventory.FlatAppearance.BorderSize = 0;
            this.btnManageInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageInventory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageInventory.ForeColor = System.Drawing.Color.White;
            this.btnManageInventory.Image = global::Inventory_Manager.Properties.Resources.icons8_in_inventory_64;
            this.btnManageInventory.Location = new System.Drawing.Point(0, 169);
            this.btnManageInventory.Name = "btnManageInventory";
            this.btnManageInventory.Size = new System.Drawing.Size(200, 163);
            this.btnManageInventory.TabIndex = 3;
            this.btnManageInventory.Text = "Manage Inventory";
            this.btnManageInventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManageInventory.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::Inventory_Manager.Properties.Resources.icons8_search_50;
            this.btnSearch.Location = new System.Drawing.Point(0, 338);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 145);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search Inventory";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::Inventory_Manager.Properties.Resources.icons8_settings_filled_50__1_;
            this.btnSettings.Location = new System.Drawing.Point(0, 489);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 163);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
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
            // 
            // btnCloseApp
            // 
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
            // panel1
            // 
            this.panel1.Controls.Add(this.manageInventoryUserControl2);
            this.panel1.Controls.Add(this.manageInventoryUserControl);
            this.panel1.Location = new System.Drawing.Point(200, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 582);
            this.panel1.TabIndex = 5;
            // 
            // manageInventoryUserControl
            // 
            this.manageInventoryUserControl.Location = new System.Drawing.Point(0, -3);
            this.manageInventoryUserControl.Name = "manageInventoryUserControl";
            this.manageInventoryUserControl.Size = new System.Drawing.Size(847, 582);
            this.manageInventoryUserControl.TabIndex = 0;
            this.manageInventoryUserControl.Load += new System.EventHandler(this.manageInventoryUserControl_Load);
            // 
            // manageInventoryUserControl2
            // 
            this.manageInventoryUserControl2.Location = new System.Drawing.Point(267, 245);
            this.manageInventoryUserControl2.Name = "manageInventoryUserControl2";
            this.manageInventoryUserControl2.Size = new System.Drawing.Size(8, 8);
            this.manageInventoryUserControl2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuDock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuDock.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuDock;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnManageInventory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.Panel panel1;
        private ManageInventoryUserControl manageInventoryUserControl;
        private ManageInventoryUserControl manageInventoryUserControl2;
    }
}

