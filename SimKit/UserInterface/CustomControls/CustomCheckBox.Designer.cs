namespace SimKit.UserInterface.CustomControls
{
    partial class CustomCheckBox
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.rightButton = new SIMKIT.UserInterface.CustomControls.ImageButton();
            this.leftButton = new SIMKIT.UserInterface.CustomControls.ImageButton();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftButton)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.leftButton);
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(50, 45);
            this.leftPanel.TabIndex = 2;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.rightButton);
            this.rightPanel.ForeColor = System.Drawing.Color.Black;
            this.rightPanel.Location = new System.Drawing.Point(50, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(50, 45);
            this.rightPanel.TabIndex = 1;
            // 
            // rightButton
            // 
            this.rightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rightButton.DownImage = null;
            this.rightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightButton.HoverImage = global::SimKit.Properties.Resources.app_button_right_grey_over;
            this.rightButton.Location = new System.Drawing.Point(0, 0);
            this.rightButton.Margin = new System.Windows.Forms.Padding(0);
            this.rightButton.Name = "rightButton";
            this.rightButton.NormalImage = global::SimKit.Properties.Resources.app_button_right_grey_out;
            this.rightButton.Size = new System.Drawing.Size(50, 45);
            this.rightButton.TabIndex = 0;
            this.rightButton.TabStop = false;
            this.rightButton.Text = "No";
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.leftButton.DownImage = null;
            this.leftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftButton.HoverImage = global::SimKit.Properties.Resources.app_button_left_blue_over;
            this.leftButton.Location = new System.Drawing.Point(0, 0);
            this.leftButton.Margin = new System.Windows.Forms.Padding(0);
            this.leftButton.Name = "leftButton";
            this.leftButton.NormalImage = global::SimKit.Properties.Resources.app_button_left_blue_out;
            this.leftButton.Size = new System.Drawing.Size(50, 45);
            this.leftButton.TabIndex = 0;
            this.leftButton.TabStop = false;
            this.leftButton.Text = "Yes";
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // CustomCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CustomCheckBox";
            this.Size = new System.Drawing.Size(100, 45);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SIMKIT.UserInterface.CustomControls.ImageButton leftButton;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private SIMKIT.UserInterface.CustomControls.ImageButton rightButton;
    }
}
