namespace SimKit.UserInterface.Modals
{
    partial class SystemStartModal
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
            this.modalContent = new System.Windows.Forms.Panel();
            this.continueButton = new System.Windows.Forms.Button();
            this.registerUseCheckbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.collectUsageDataCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.modalContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // modalContent
            // 
            this.modalContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.modalContent.Controls.Add(this.continueButton);
            this.modalContent.Controls.Add(this.registerUseCheckbox);
            this.modalContent.Controls.Add(this.label3);
            this.modalContent.Controls.Add(this.collectUsageDataCheckbox);
            this.modalContent.Controls.Add(this.label2);
            this.modalContent.Controls.Add(this.label1);
            this.modalContent.Controls.Add(this.pictureBox1);
            this.modalContent.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modalContent.ForeColor = System.Drawing.Color.Black;
            this.modalContent.Location = new System.Drawing.Point(143, 75);
            this.modalContent.Name = "modalContent";
            this.modalContent.Size = new System.Drawing.Size(419, 322);
            this.modalContent.TabIndex = 0;
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(267, 271);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(75, 23);
            this.continueButton.TabIndex = 6;
            this.continueButton.Text = "continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // registerUseCheckbox
            // 
            this.registerUseCheckbox.AutoSize = true;
            this.registerUseCheckbox.Checked = true;
            this.registerUseCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.registerUseCheckbox.Location = new System.Drawing.Point(327, 197);
            this.registerUseCheckbox.Name = "registerUseCheckbox";
            this.registerUseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.registerUseCheckbox.TabIndex = 5;
            this.registerUseCheckbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = "Allow SIMKIT to register that this app was turned\r\non (collecting this very basic" +
    " usage data helps us\r\nkeep SIMKIT free, please keep this in mind before \r\nunchec" +
    "king this option).";
            // 
            // collectUsageDataCheckbox
            // 
            this.collectUsageDataCheckbox.AutoSize = true;
            this.collectUsageDataCheckbox.Checked = true;
            this.collectUsageDataCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.collectUsageDataCheckbox.Location = new System.Drawing.Point(327, 140);
            this.collectUsageDataCheckbox.Name = "collectUsageDataCheckbox";
            this.collectUsageDataCheckbox.Size = new System.Drawing.Size(15, 14);
            this.collectUsageDataCheckbox.TabIndex = 3;
            this.collectUsageDataCheckbox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Allow SIMKIT to collect anonymous data about\r\nthe way you use this app (not inclu" +
    "ding the \r\nmessages you write).\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "SIMKIT is free and open source software designed\r\nto turn the worlds feature phon" +
    "es into e-readers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SimKit.Properties.Resources.app_header_modal_systemstart;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SystemStartModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.modalContent);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SystemStartModal";
            this.Size = new System.Drawing.Size(800, 500);
            this.modalContent.ResumeLayout(false);
            this.modalContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel modalContent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.CheckBox registerUseCheckbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox collectUsageDataCheckbox;
        private System.Windows.Forms.Label label2;
    }
}
