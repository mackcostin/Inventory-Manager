namespace Inventory_Manager.Forms
{
    partial class SetupForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlSetupUCContainer = new System.Windows.Forms.Panel();
            this.btnSetupCloseApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 20);
            this.panel2.TabIndex = 4;
            // 
            // PnlSetupUCContainer
            // 
            this.PnlSetupUCContainer.Location = new System.Drawing.Point(0, 70);
            this.PnlSetupUCContainer.Name = "PnlSetupUCContainer";
            this.PnlSetupUCContainer.Size = new System.Drawing.Size(1034, 542);
            this.PnlSetupUCContainer.TabIndex = 5;
            // 
            // btnSetupCloseApp
            // 
            this.btnSetupCloseApp.AutoSize = true;
            this.btnSetupCloseApp.FlatAppearance.BorderSize = 0;
            this.btnSetupCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetupCloseApp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetupCloseApp.ForeColor = System.Drawing.Color.White;
            this.btnSetupCloseApp.Image = global::Inventory_Manager.Properties.Resources.icons8_shutdown_30;
            this.btnSetupCloseApp.Location = new System.Drawing.Point(979, 22);
            this.btnSetupCloseApp.Name = "btnSetupCloseApp";
            this.btnSetupCloseApp.Size = new System.Drawing.Size(55, 42);
            this.btnSetupCloseApp.TabIndex = 6;
            this.btnSetupCloseApp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSetupCloseApp.UseVisualStyleBackColor = true;
            this.btnSetupCloseApp.Click += new System.EventHandler(this.btnSetupCloseApp_Click);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 613);
            this.Controls.Add(this.btnSetupCloseApp);
            this.Controls.Add(this.PnlSetupUCContainer);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetupForm";
            this.Load += new System.EventHandler(this.SetupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlSetupUCContainer;
        private System.Windows.Forms.Button btnSetupCloseApp;
    }
}