namespace SimKit.UserInterface.CustomControls
{
    partial class ErrorBlock
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.centerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bottomPictureBox = new System.Windows.Forms.PictureBox();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimKit.Properties.Resources.app_errorblock_top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 15);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // centerPanel
            // 
            this.centerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.centerPanel.AutoSize = true;
            this.centerPanel.BackgroundImage = global::SimKit.Properties.Resources.app_errorblock_mid;
            this.centerPanel.Controls.Add(this.errorMessageLabel);
            this.centerPanel.Location = new System.Drawing.Point(0, 15);
            this.centerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(190, 45);
            this.centerPanel.TabIndex = 1;
            // 
            // bottomPictureBox
            // 
            this.bottomPictureBox.Image = global::SimKit.Properties.Resources.app_errorblock_bottom;
            this.bottomPictureBox.Location = new System.Drawing.Point(0, 60);
            this.bottomPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.bottomPictureBox.Name = "bottomPictureBox";
            this.bottomPictureBox.Size = new System.Drawing.Size(190, 15);
            this.bottomPictureBox.TabIndex = 2;
            this.bottomPictureBox.TabStop = false;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(60)))), ((int)(((byte)(53)))));
            this.errorMessageLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.ForeColor = System.Drawing.Color.White;
            this.errorMessageLabel.Location = new System.Drawing.Point(30, 8);
            this.errorMessageLabel.Margin = new System.Windows.Forms.Padding(30, 8, 3, 0);
            this.errorMessageLabel.MaximumSize = new System.Drawing.Size(150, 0);
            this.errorMessageLabel.MinimumSize = new System.Drawing.Size(150, 30);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(150, 30);
            this.errorMessageLabel.TabIndex = 0;
            this.errorMessageLabel.Text = "label1";
            // 
            // ErrorBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.bottomPictureBox);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ErrorBlock";
            this.Size = new System.Drawing.Size(190, 75);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.centerPanel.ResumeLayout(false);
            this.centerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel centerPanel;
        private System.Windows.Forms.PictureBox bottomPictureBox;
        private System.Windows.Forms.Label errorMessageLabel;
    }
}
