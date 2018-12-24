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
            this.lblEnterPriceHint = new System.Windows.Forms.Label();
            this.lblEnterItemNameHint = new System.Windows.Forms.Label();
            this.lblEnterItemNumber = new System.Windows.Forms.Label();
            this.tbxEnterItemNumber = new System.Windows.Forms.TextBox();
            this.lblEnterItemNumberHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterItemName
            // 
            this.lblEnterItemName.AutoSize = true;
            this.lblEnterItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterItemName.Location = new System.Drawing.Point(40, 73);
            this.lblEnterItemName.Name = "lblEnterItemName";
            this.lblEnterItemName.Size = new System.Drawing.Size(176, 13);
            this.lblEnterItemName.TabIndex = 0;
            this.lblEnterItemName.Text = "Enter the InventoryItem Name";
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
            // 
            // lblInventoryManager
            // 
            this.lblInventoryManager.AutoSize = true;
            this.lblInventoryManager.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryManager.Location = new System.Drawing.Point(36, 0);
            this.lblInventoryManager.Name = "lblInventoryManager";
            this.lblInventoryManager.Size = new System.Drawing.Size(311, 38);
            this.lblInventoryManager.TabIndex = 0;
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
            this.checkedListBox1.TabIndex = 6;
            // 
            // lblEnterPrice
            // 
            this.lblEnterPrice.AutoSize = true;
            this.lblEnterPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPrice.Location = new System.Drawing.Point(40, 129);
            this.lblEnterPrice.Name = "lblEnterPrice";
            this.lblEnterPrice.Size = new System.Drawing.Size(95, 13);
            this.lblEnterPrice.TabIndex = 0;
            this.lblEnterPrice.Text = "Enter the price ";
            // 
            // tbxEnterItemPrice
            // 
            this.tbxEnterItemPrice.AllowDrop = true;
            this.tbxEnterItemPrice.ForeColor = System.Drawing.Color.Black;
            this.tbxEnterItemPrice.Location = new System.Drawing.Point(43, 145);
            this.tbxEnterItemPrice.Name = "tbxEnterItemPrice";
            this.tbxEnterItemPrice.Size = new System.Drawing.Size(209, 20);
            this.tbxEnterItemPrice.TabIndex = 2;
            this.tbxEnterItemPrice.Text = "Enter item price here";
            this.tbxEnterItemPrice.Click += new System.EventHandler(this.tbxEnterItemPrice_Click);
            this.tbxEnterItemPrice.TextChanged += new System.EventHandler(this.tbxEnterItemPrice_TextChanged);
            // 
            // btnConfirmSelection
            // 
            this.btnConfirmSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConfirmSelection.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmSelection.ForeColor = System.Drawing.Color.White;
            this.btnConfirmSelection.Location = new System.Drawing.Point(543, 465);
            this.btnConfirmSelection.Name = "btnConfirmSelection";
            this.btnConfirmSelection.Size = new System.Drawing.Size(218, 60);
            this.btnConfirmSelection.TabIndex = 7;
            this.btnConfirmSelection.Text = "Confirm Selection";
            this.btnConfirmSelection.UseVisualStyleBackColor = false;
            this.btnConfirmSelection.Click += new System.EventHandler(this.btnConfirmSelection_Click);
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.Location = new System.Drawing.Point(181, 472);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(110, 53);
            this.btnRemoveItems.TabIndex = 5;
            this.btnRemoveItems.Text = "Remove Selected";
            this.btnRemoveItems.UseVisualStyleBackColor = true;
            this.btnRemoveItems.Click += new System.EventHandler(this.btnRemoveItems_Click);
            // 
            // lblEnterPriceHint
            // 
            this.lblEnterPriceHint.AutoSize = true;
            this.lblEnterPriceHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPriceHint.ForeColor = System.Drawing.Color.Red;
            this.lblEnterPriceHint.Location = new System.Drawing.Point(40, 168);
            this.lblEnterPriceHint.Name = "lblEnterPriceHint";
            this.lblEnterPriceHint.Size = new System.Drawing.Size(0, 13);
            this.lblEnterPriceHint.TabIndex = 0;
            // 
            // lblEnterItemNameHint
            // 
            this.lblEnterItemNameHint.AutoSize = true;
            this.lblEnterItemNameHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterItemNameHint.ForeColor = System.Drawing.Color.Red;
            this.lblEnterItemNameHint.Location = new System.Drawing.Point(40, 113);
            this.lblEnterItemNameHint.Name = "lblEnterItemNameHint";
            this.lblEnterItemNameHint.Size = new System.Drawing.Size(0, 13);
            this.lblEnterItemNameHint.TabIndex = 0;
            // 
            // lblEnterItemNumber
            // 
            this.lblEnterItemNumber.AutoSize = true;
            this.lblEnterItemNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterItemNumber.Location = new System.Drawing.Point(40, 181);
            this.lblEnterItemNumber.Name = "lblEnterItemNumber";
            this.lblEnterItemNumber.Size = new System.Drawing.Size(191, 13);
            this.lblEnterItemNumber.TabIndex = 0;
            this.lblEnterItemNumber.Text = "Enter the InventoryItem Number ";
            // 
            // tbxEnterItemNumber
            // 
            this.tbxEnterItemNumber.AllowDrop = true;
            this.tbxEnterItemNumber.ForeColor = System.Drawing.Color.Black;
            this.tbxEnterItemNumber.Location = new System.Drawing.Point(43, 197);
            this.tbxEnterItemNumber.Name = "tbxEnterItemNumber";
            this.tbxEnterItemNumber.Size = new System.Drawing.Size(209, 20);
            this.tbxEnterItemNumber.TabIndex = 3;
            this.tbxEnterItemNumber.Text = "Enter item number here";
            this.tbxEnterItemNumber.Click += new System.EventHandler(this.tbxEnterItemNumber_Click);
            this.tbxEnterItemNumber.TextChanged += new System.EventHandler(this.tbxEnterItemNumber_TextChanged);
            // 
            // lblEnterItemNumberHint
            // 
            this.lblEnterItemNumberHint.AutoSize = true;
            this.lblEnterItemNumberHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterItemNumberHint.ForeColor = System.Drawing.Color.Red;
            this.lblEnterItemNumberHint.Location = new System.Drawing.Point(40, 220);
            this.lblEnterItemNumberHint.Name = "lblEnterItemNumberHint";
            this.lblEnterItemNumberHint.Size = new System.Drawing.Size(0, 13);
            this.lblEnterItemNumberHint.TabIndex = 0;
            // 
            // ManageInventoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEnterItemNumberHint);
            this.Controls.Add(this.tbxEnterItemNumber);
            this.Controls.Add(this.lblEnterItemNumber);
            this.Controls.Add(this.lblEnterItemNameHint);
            this.Controls.Add(this.lblEnterPriceHint);
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
        private System.Windows.Forms.Label lblEnterPriceHint;
        private System.Windows.Forms.Label lblEnterItemNameHint;
        private System.Windows.Forms.Label lblEnterItemNumber;
        private System.Windows.Forms.TextBox tbxEnterItemNumber;
        private System.Windows.Forms.Label lblEnterItemNumberHint;
    }
}
