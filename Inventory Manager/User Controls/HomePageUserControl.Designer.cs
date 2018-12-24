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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblIntroParagraph = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(4, 4);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(226, 51);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblIntroParagraph
            // 
            this.lblIntroParagraph.AutoSize = true;
            this.lblIntroParagraph.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroParagraph.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblIntroParagraph.Location = new System.Drawing.Point(19, 73);
            this.lblIntroParagraph.Name = "lblIntroParagraph";
            this.lblIntroParagraph.Size = new System.Drawing.Size(47, 23);
            this.lblIntroParagraph.TabIndex = 1;
            this.lblIntroParagraph.Text = "text";
            this.lblIntroParagraph.Click += new System.EventHandler(this.lblIntroParagraph_Click);
            // 
            // HomePageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblIntroParagraph);
            this.Controls.Add(this.lblWelcome);
            this.Name = "HomePageUserControl";
            this.Size = new System.Drawing.Size(1275, 895);
            this.Load += new System.EventHandler(this.HomePageUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblIntroParagraph;
    }
}
