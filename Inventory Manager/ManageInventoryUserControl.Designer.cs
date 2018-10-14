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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblEnterPrice = new System.Windows.Forms.Label();
            this.tbxEnterItemPrice = new System.Windows.Forms.TextBox();
            this.btnConfirmSelection = new System.Windows.Forms.Button();
            this.btnRemoveItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterItemName
            // 
            this.lblEnterItemName.AutoSize = true;
            this.lblEnterItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterItemName.Location = new System.Drawing.Point(40, 73);
            this.lblEnterItemName.Name = "lblEnterItemName";
            this.lblEnterItemName.Size = new System.Drawing.Size(123, 13);
            this.lblEnterItemName.TabIndex = 0;
            this.lblEnterItemName.Text = "Enter the Item Name";
            // 
            // tbxItemName
            // 
            this.tbxItemName.AllowDrop = true;
            this.tbxItemName.ForeColor = System.Drawing.Color.Black;
            this.tbxItemName.Location = new System.Drawing.Point(43, 90);
            this.tbxItemName.Name = "tbxItemName";
            this.tbxItemName.Size = new System.Drawing.Size(209, 20);
            this.tbxItemName.TabIndex = 1;
            this.tbxItemName.Text = "Enter item name here";
            this.tbxItemName.Click += new System.EventHandler(this.tbxItemName_Click);
            this.tbxItemName.TextChanged += new System.EventHandler(this.tbxItemName_TextChanged);
            this.tbxItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxItemName_KeyDown);
            // 
            // lblInventoryManager
            // 
            this.lblInventoryManager.AutoSize = true;
            this.lblInventoryManager.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryManager.Location = new System.Drawing.Point(36, 0);
            this.lblInventoryManager.Name = "lblInventoryManager";
            this.lblInventoryManager.Size = new System.Drawing.Size(311, 38);
            this.lblInventoryManager.TabIndex = 2;
            this.lblInventoryManager.Text = "Inventory Manager";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(43, 472);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(110, 53);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(442, 65);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(319, 394);
            this.checkedListBox1.TabIndex = 5;
            // 
            // lblEnterPrice
            // 
            this.lblEnterPrice.AutoSize = true;
            this.lblEnterPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPrice.Location = new System.Drawing.Point(40, 129);
            this.lblEnterPrice.Name = "lblEnterPrice";
            this.lblEnterPrice.Size = new System.Drawing.Size(95, 13);
            this.lblEnterPrice.TabIndex = 6;
            this.lblEnterPrice.Text = "Enter the price ";
            // 
            // tbxEnterItemPrice
            // 
            this.tbxEnterItemPrice.AllowDrop = true;
            this.tbxEnterItemPrice.ForeColor = System.Drawing.Color.Black;
            this.tbxEnterItemPrice.Location = new System.Drawing.Point(43, 145);
            this.tbxEnterItemPrice.Name = "tbxEnterItemPrice";
            this.tbxEnterItemPrice.Size = new System.Drawing.Size(209, 20);
            this.tbxEnterItemPrice.TabIndex = 7;
            this.tbxEnterItemPrice.Text = "Enter item price here";
            this.tbxEnterItemPrice.Click += new System.EventHandler(this.tbxEnterItemPrice_Click);
            this.tbxEnterItemPrice.Leave += new System.EventHandler(this.tbxEnterItemPrice_Leave);
            // 
            // btnConfirmSelection
            // 
            this.btnConfirmSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConfirmSelection.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmSelection.ForeColor = System.Drawing.Color.White;
            this.btnConfirmSelection.Location = new System.Drawing.Point(543, 465);
            this.btnConfirmSelection.Name = "btnConfirmSelection";
            this.btnConfirmSelection.Size = new System.Drawing.Size(218, 60);
            this.btnConfirmSelection.TabIndex = 8;
            this.btnConfirmSelection.Text = "Confirm Selection";
            this.btnConfirmSelection.UseVisualStyleBackColor = false;
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.Location = new System.Drawing.Point(181, 472);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(110, 53);
            this.btnRemoveItems.TabIndex = 9;
            this.btnRemoveItems.Text = "Remove Selected";
            this.btnRemoveItems.UseVisualStyleBackColor = true;
            this.btnRemoveItems.Click += new System.EventHandler(this.btnRemoveItems_Click);
            // 
            // ManageInventoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoveItems);
            this.Controls.Add(this.btnConfirmSelection);
            this.Controls.Add(this.tbxEnterItemPrice);
            this.Controls.Add(this.lblEnterPrice);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblInventoryManager);
            this.Controls.Add(this.tbxItemName);
            this.Controls.Add(this.lblEnterItemName);
            this.Name = "ManageInventoryUserControl";
            this.Size = new System.Drawing.Size(850, 582);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterItemName;
        private System.Windows.Forms.TextBox tbxItemName;
        private System.Windows.Forms.Label lblInventoryManager;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblEnterPrice;
        private System.Windows.Forms.TextBox tbxEnterItemPrice;
        private System.Windows.Forms.Button btnConfirmSelection;
        private System.Windows.Forms.Button btnRemoveItems;
    }
}
