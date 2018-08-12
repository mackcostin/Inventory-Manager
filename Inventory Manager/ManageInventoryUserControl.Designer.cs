namespace Inventory_Manager
{
    partial class ManageInventoryUserControl
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
            this.lblEnterItemName = new System.Windows.Forms.Label();
            this.tbxItemName = new System.Windows.Forms.TextBox();
            this.lblInventoryManager = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterItemName
            // 
            this.lblEnterItemName.AutoSize = true;
            this.lblEnterItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterItemName.Location = new System.Drawing.Point(60, 112);
            this.lblEnterItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterItemName.Name = "lblEnterItemName";
            this.lblEnterItemName.Size = new System.Drawing.Size(182, 20);
            this.lblEnterItemName.TabIndex = 0;
            this.lblEnterItemName.Text = "Enter the Item Name";
            this.lblEnterItemName.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxItemName
            // 
            this.tbxItemName.AllowDrop = true;
            this.tbxItemName.ForeColor = System.Drawing.Color.Gray;
            this.tbxItemName.Location = new System.Drawing.Point(65, 138);
            this.tbxItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxItemName.Name = "tbxItemName";
            this.tbxItemName.Size = new System.Drawing.Size(312, 26);
            this.tbxItemName.TabIndex = 1;
            this.tbxItemName.Text = "Enter item name here";
            // 
            // lblInventoryManager
            // 
            this.lblInventoryManager.AutoSize = true;
            this.lblInventoryManager.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryManager.Location = new System.Drawing.Point(54, 0);
            this.lblInventoryManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInventoryManager.Name = "lblInventoryManager";
            this.lblInventoryManager.Size = new System.Drawing.Size(468, 56);
            this.lblInventoryManager.TabIndex = 2;
            this.lblInventoryManager.Text = "Inventory Manager";
            this.lblInventoryManager.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ManageInventoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblInventoryManager);
            this.Controls.Add(this.tbxItemName);
            this.Controls.Add(this.lblEnterItemName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageInventoryUserControl";
            this.Size = new System.Drawing.Size(1275, 895);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterItemName;
        private System.Windows.Forms.TextBox tbxItemName;
        private System.Windows.Forms.Label lblInventoryManager;
    }
}
