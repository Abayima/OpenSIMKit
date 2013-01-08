namespace SimKit.UserInterface.ContentPanels
{
    partial class ConnectionErrorContentPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionErrorContentPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectionErrorsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.contributeHelpLink = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.devicesHelpLink = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.instructionHelpLink = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rescanButton = new SIMKIT.UserInterface.CustomControls.ImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rescanButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "There is not SIM card connected that\r\nSIMKit can work with";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 56);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // connectionErrorsPanel
            // 
            this.connectionErrorsPanel.AutoScroll = true;
            this.connectionErrorsPanel.Location = new System.Drawing.Point(28, 225);
            this.connectionErrorsPanel.Name = "connectionErrorsPanel";
            this.connectionErrorsPanel.Size = new System.Drawing.Size(216, 252);
            this.connectionErrorsPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(220)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(271, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 252);
            this.panel1.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.contributeHelpLink);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(3, 182);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 55);
            this.panel5.TabIndex = 4;
            // 
            // contributeHelpLink
            // 
            this.contributeHelpLink.AutoSize = true;
            this.contributeHelpLink.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contributeHelpLink.Location = new System.Drawing.Point(93, 33);
            this.contributeHelpLink.Name = "contributeHelpLink";
            this.contributeHelpLink.Size = new System.Drawing.Size(32, 14);
            this.contributeHelpLink.TabIndex = 2;
            this.contributeHelpLink.TabStop = true;
            this.contributeHelpLink.Text = "here";
            this.contributeHelpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contributeHelpLink_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 42);
            this.label7.TabIndex = 1;
            this.label7.Text = "To get invloved and contribute\r\nto the development of Open\r\nSIMKit, click";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SimKit.Properties.Resources.app_blue_questionmark;
            this.pictureBox3.Location = new System.Drawing.Point(9, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(14, 14);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.devicesHelpLink);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(3, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 54);
            this.panel4.TabIndex = 3;
            // 
            // devicesHelpLink
            // 
            this.devicesHelpLink.AutoSize = true;
            this.devicesHelpLink.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devicesHelpLink.Location = new System.Drawing.Point(87, 33);
            this.devicesHelpLink.Name = "devicesHelpLink";
            this.devicesHelpLink.Size = new System.Drawing.Size(32, 14);
            this.devicesHelpLink.TabIndex = 2;
            this.devicesHelpLink.TabStop = true;
            this.devicesHelpLink.Text = "here";
            this.devicesHelpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.devicesHelpLink_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 42);
            this.label6.TabIndex = 1;
            this.label6.Text = "For a full list of supported\r\ndevices and ways to connect\r\nthem, click";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SimKit.Properties.Resources.app_blue_questionmark;
            this.pictureBox2.Location = new System.Drawing.Point(9, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(14, 14);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.instructionHelpLink);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(3, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 54);
            this.panel3.TabIndex = 1;
            // 
            // instructionHelpLink
            // 
            this.instructionHelpLink.AutoSize = true;
            this.instructionHelpLink.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionHelpLink.Location = new System.Drawing.Point(26, 33);
            this.instructionHelpLink.Name = "instructionHelpLink";
            this.instructionHelpLink.Size = new System.Drawing.Size(32, 14);
            this.instructionHelpLink.TabIndex = 2;
            this.instructionHelpLink.TabStop = true;
            this.instructionHelpLink.Text = "here";
            this.instructionHelpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.instructionHelpLink_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "For step by step instructions\r\non using Open SIMKit, click";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimKit.Properties.Resources.app_blue_questionmark;
            this.pictureBox1.Location = new System.Drawing.Point(9, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 14);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Need some help?";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rescanButton);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(322, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 56);
            this.panel2.TabIndex = 10;
            // 
            // rescanButton
            // 
            this.rescanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rescanButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rescanButton.DownImage = null;
            this.rescanButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rescanButton.HoverImage = global::SimKit.Properties.Resources.app_button_blue_over;
            this.rescanButton.Location = new System.Drawing.Point(3, 3);
            this.rescanButton.Name = "rescanButton";
            this.rescanButton.NormalImage = global::SimKit.Properties.Resources.app_button_blue_out;
            this.rescanButton.Size = new System.Drawing.Size(110, 50);
            this.rescanButton.TabIndex = 8;
            this.rescanButton.TabStop = false;
            this.rescanButton.Text = "Check again";
            this.rescanButton.Click += new System.EventHandler(this.rescanButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 38);
            this.label4.TabIndex = 11;
            this.label4.Text = "If  you want to  rescan your  system \r\nfor SIM cards, click the button here.";
            // 
            // ConnectionErrorContentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.connectionErrorsPanel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ConnectionErrorContentPanel";
            this.Size = new System.Drawing.Size(500, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rescanButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel connectionErrorsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private SIMKIT.UserInterface.CustomControls.ImageButton rescanButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel instructionHelpLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel devicesHelpLink;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.LinkLabel contributeHelpLink;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
