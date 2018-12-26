namespace Inventory_Manager.User_Controls
{
    partial class WelcomeScreenUserControl
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
            this.lblHomePgIntro = new System.Windows.Forms.Label();
            this.lblHomePgHeader = new System.Windows.Forms.Label();
            this.btnGetStarted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHomePgIntro
            // 
            this.lblHomePgIntro.AutoSize = true;
            this.lblHomePgIntro.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePgIntro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHomePgIntro.Location = new System.Drawing.Point(57, 44);
            this.lblHomePgIntro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomePgIntro.Name = "lblHomePgIntro";
            this.lblHomePgIntro.Size = new System.Drawing.Size(35, 19);
            this.lblHomePgIntro.TabIndex = 3;
            this.lblHomePgIntro.Text = "text";
            // 
            // lblHomePgHeader
            // 
            this.lblHomePgHeader.AutoSize = true;
            this.lblHomePgHeader.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePgHeader.Location = new System.Drawing.Point(52, 0);
            this.lblHomePgHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomePgHeader.Name = "lblHomePgHeader";
            this.lblHomePgHeader.Size = new System.Drawing.Size(155, 37);
            this.lblHomePgHeader.TabIndex = 2;
            this.lblHomePgHeader.Text = "Welcome";
            // 
            // btnGetStarted
            // 
            this.btnGetStarted.Location = new System.Drawing.Point(628, 477);
            this.btnGetStarted.Name = "btnGetStarted";
            this.btnGetStarted.Size = new System.Drawing.Size(171, 74);
            this.btnGetStarted.TabIndex = 4;
            this.btnGetStarted.Text = "Get Started";
            this.btnGetStarted.UseVisualStyleBackColor = true;
            this.btnGetStarted.Click += new System.EventHandler(this.btnGetStarted_Click);
            // 
            // WelcomeScreenUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGetStarted);
            this.Controls.Add(this.lblHomePgIntro);
            this.Controls.Add(this.lblHomePgHeader);
            this.Name = "WelcomeScreenUserControl";
            this.Size = new System.Drawing.Size(850, 582);
            this.Load += new System.EventHandler(this.WelcomeScreenUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHomePgIntro;
        private System.Windows.Forms.Label lblHomePgHeader;
        private System.Windows.Forms.Button btnGetStarted;
    }
}
