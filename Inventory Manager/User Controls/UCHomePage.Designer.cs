namespace Inventory_Manager.User_Controls
{
    partial class UCHomePage
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
            this.lblHomePgHeader = new System.Windows.Forms.Label();
            this.LblSvrName = new System.Windows.Forms.Label();
            this.LblUsrName = new System.Windows.Forms.Label();
            this.LblDBName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHomePgHeader
            // 
            this.lblHomePgHeader.AutoSize = true;
            this.lblHomePgHeader.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePgHeader.Location = new System.Drawing.Point(52, 0);
            this.lblHomePgHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomePgHeader.Name = "lblHomePgHeader";
            this.lblHomePgHeader.Size = new System.Drawing.Size(103, 37);
            this.lblHomePgHeader.TabIndex = 10;
            this.lblHomePgHeader.Text = "Home";
            // 
            // LblSvrName
            // 
            this.LblSvrName.AutoSize = true;
            this.LblSvrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSvrName.Location = new System.Drawing.Point(710, 72);
            this.LblSvrName.Name = "LblSvrName";
            this.LblSvrName.Size = new System.Drawing.Size(75, 13);
            this.LblSvrName.TabIndex = 11;
            this.LblSvrName.Text = "LblSvrName";
            // 
            // LblUsrName
            // 
            this.LblUsrName.AutoSize = true;
            this.LblUsrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsrName.Location = new System.Drawing.Point(710, 104);
            this.LblUsrName.Name = "LblUsrName";
            this.LblUsrName.Size = new System.Drawing.Size(75, 13);
            this.LblUsrName.TabIndex = 13;
            this.LblUsrName.Text = "LblUsrName";
            // 
            // LblDBName
            // 
            this.LblDBName.AutoSize = true;
            this.LblDBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDBName.Location = new System.Drawing.Point(710, 88);
            this.LblDBName.Name = "LblDBName";
            this.LblDBName.Size = new System.Drawing.Size(73, 13);
            this.LblDBName.TabIndex = 14;
            this.LblDBName.Text = "LblDBName";
            // 
            // UCHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblDBName);
            this.Controls.Add(this.LblUsrName);
            this.Controls.Add(this.LblSvrName);
            this.Controls.Add(this.lblHomePgHeader);
            this.Name = "UCHomePage";
            this.Size = new System.Drawing.Size(847, 581);
            this.Load += new System.EventHandler(this.UCHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHomePgHeader;
        private System.Windows.Forms.Label LblSvrName;
        private System.Windows.Forms.Label LblUsrName;
        private System.Windows.Forms.Label LblDBName;
    }
}
