namespace Inventory_Manager
{
    partial class HomePageUserControl
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
            this.lblHomePgIntro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHomePgHeader
            // 
            this.lblHomePgHeader.AutoSize = true;
            this.lblHomePgHeader.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePgHeader.Location = new System.Drawing.Point(54, 0);
            this.lblHomePgHeader.Name = "lblHomePgHeader";
            this.lblHomePgHeader.Size = new System.Drawing.Size(226, 51);
            this.lblHomePgHeader.TabIndex = 0;
            this.lblHomePgHeader.Text = "Welcome";
            // 
            // lblHomePgIntro
            // 
            this.lblHomePgIntro.AutoSize = true;
            this.lblHomePgIntro.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePgIntro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHomePgIntro.Location = new System.Drawing.Point(62, 68);
            this.lblHomePgIntro.Name = "lblHomePgIntro";
            this.lblHomePgIntro.Size = new System.Drawing.Size(47, 23);
            this.lblHomePgIntro.TabIndex = 1;
            this.lblHomePgIntro.Text = "text";
            // 
            // HomePageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHomePgIntro);
            this.Controls.Add(this.lblHomePgHeader);
            this.Name = "HomePageUserControl";
            this.Size = new System.Drawing.Size(1275, 895);
            this.Load += new System.EventHandler(this.HomePageUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHomePgHeader;
        private System.Windows.Forms.Label lblHomePgIntro;
    }
}
