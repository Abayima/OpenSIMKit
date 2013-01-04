namespace SimKit.UserInterface
{
    partial class MainApplicationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApplicationWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.socialHomeButton = new SIMKIT.UserInterface.CustomControls.ImageButton();
            this.socialTwitterButton = new SIMKIT.UserInterface.CustomControls.ImageButton();
            this.socialFacebookButton = new SIMKIT.UserInterface.CustomControls.ImageButton();
            this.socialGithubButton = new SIMKIT.UserInterface.CustomControls.ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialHomeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialTwitterButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialFacebookButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialGithubButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Open SIMKit is free and open source\r\nsoftware designed to turn the worlds\r\nfeatur" +
    "e phones into e-readers!\r\n";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.Black;
            this.contentPanel.Location = new System.Drawing.Point(282, 110);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(500, 500);
            this.contentPanel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimKit.Properties.Resources.app_main_header;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // socialHomeButton
            // 
            this.socialHomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.socialHomeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.socialHomeButton.DownImage = null;
            this.socialHomeButton.HoverImage = global::SimKit.Properties.Resources.app_button_social_home_over;
            this.socialHomeButton.Location = new System.Drawing.Point(199, 189);
            this.socialHomeButton.Name = "socialHomeButton";
            this.socialHomeButton.NormalImage = global::SimKit.Properties.Resources.app_button_social_home_out;
            this.socialHomeButton.Size = new System.Drawing.Size(50, 50);
            this.socialHomeButton.TabIndex = 5;
            this.socialHomeButton.TabStop = false;
            this.socialHomeButton.Click += new System.EventHandler(this.socialHomeButton_Click);
            // 
            // socialTwitterButton
            // 
            this.socialTwitterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.socialTwitterButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.socialTwitterButton.DownImage = null;
            this.socialTwitterButton.HoverImage = global::SimKit.Properties.Resources.app_button_social_twitter_over;
            this.socialTwitterButton.Location = new System.Drawing.Point(143, 189);
            this.socialTwitterButton.Name = "socialTwitterButton";
            this.socialTwitterButton.NormalImage = global::SimKit.Properties.Resources.app_button_social_twitter_out;
            this.socialTwitterButton.Size = new System.Drawing.Size(50, 50);
            this.socialTwitterButton.TabIndex = 4;
            this.socialTwitterButton.TabStop = false;
            this.socialTwitterButton.Click += new System.EventHandler(this.socialTwitterButton_Click);
            // 
            // socialFacebookButton
            // 
            this.socialFacebookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.socialFacebookButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.socialFacebookButton.DownImage = null;
            this.socialFacebookButton.HoverImage = global::SimKit.Properties.Resources.app_button_social_facebook_over;
            this.socialFacebookButton.Location = new System.Drawing.Point(87, 189);
            this.socialFacebookButton.Name = "socialFacebookButton";
            this.socialFacebookButton.NormalImage = global::SimKit.Properties.Resources.app_button_social_facebook_out;
            this.socialFacebookButton.Size = new System.Drawing.Size(50, 50);
            this.socialFacebookButton.TabIndex = 3;
            this.socialFacebookButton.TabStop = false;
            this.socialFacebookButton.Click += new System.EventHandler(this.socialFacebookButton_Click);
            // 
            // socialGithubButton
            // 
            this.socialGithubButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.socialGithubButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.socialGithubButton.DownImage = null;
            this.socialGithubButton.HoverImage = global::SimKit.Properties.Resources.app_button_social_github_over;
            this.socialGithubButton.Location = new System.Drawing.Point(31, 189);
            this.socialGithubButton.Name = "socialGithubButton";
            this.socialGithubButton.NormalImage = global::SimKit.Properties.Resources.app_button_social_github_out;
            this.socialGithubButton.Size = new System.Drawing.Size(50, 50);
            this.socialGithubButton.TabIndex = 2;
            this.socialGithubButton.TabStop = false;
            this.socialGithubButton.Click += new System.EventHandler(this.socialGithubButton_Click);
            // 
            // MainApplicationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(794, 622);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.socialHomeButton);
            this.Controls.Add(this.socialTwitterButton);
            this.Controls.Add(this.socialFacebookButton);
            this.Controls.Add(this.socialGithubButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainApplicationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIM Kit - Turning the worlds feature phones into ereaders!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialHomeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialTwitterButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialFacebookButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialGithubButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private SIMKIT.UserInterface.CustomControls.ImageButton socialGithubButton;
        private SIMKIT.UserInterface.CustomControls.ImageButton socialFacebookButton;
        private SIMKIT.UserInterface.CustomControls.ImageButton socialTwitterButton;
        private SIMKIT.UserInterface.CustomControls.ImageButton socialHomeButton;
        private System.Windows.Forms.Panel contentPanel;
        private ContentPanels.WaitingContentPanel waitingContentPanel1;
    }
}