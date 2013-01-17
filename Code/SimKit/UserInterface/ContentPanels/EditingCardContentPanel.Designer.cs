namespace SimKit.UserInterface.ContentPanels
{
    partial class EditingCardContentPanel
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
            this.messagesContainerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveCardButton = new SIMKIT.UserInterface.CustomControls.ImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.justSavedPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.disconnectButton = new SIMKIT.UserInterface.CustomControls.ImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            ((System.ComponentModel.ISupportInitialize)(this.saveCardButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.justSavedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectButton)).BeginInit();
            this.SuspendLayout();
            // 
            // messagesContainerPanel
            // 
            this.messagesContainerPanel.AutoScroll = true;
            this.messagesContainerPanel.Location = new System.Drawing.Point(16, 71);
            this.messagesContainerPanel.Name = "messagesContainerPanel";
            this.messagesContainerPanel.Size = new System.Drawing.Size(274, 408);
            this.messagesContainerPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(78, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "You are currently editing a SIM card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 90);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edit the text in any of the message \r\nboxes in the list on the left.\r\n\r\nWhen you " +
    "have finished editing, \r\nclick the save button below to \r\nstore these messages o" +
    "n the card.";
            // 
            // saveCardButton
            // 
            this.saveCardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveCardButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveCardButton.DownImage = null;
            this.saveCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCardButton.HoverImage = global::SimKit.Properties.Resources.app_button_blue_over;
            this.saveCardButton.Location = new System.Drawing.Point(3, 3);
            this.saveCardButton.Name = "saveCardButton";
            this.saveCardButton.NormalImage = global::SimKit.Properties.Resources.app_button_blue_out;
            this.saveCardButton.Size = new System.Drawing.Size(110, 50);
            this.saveCardButton.TabIndex = 4;
            this.saveCardButton.TabStop = false;
            this.saveCardButton.Text = "Save";
            this.saveCardButton.Click += new System.EventHandler(this.saveCardButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveCardButton);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(372, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 56);
            this.panel1.TabIndex = 5;
            // 
            // justSavedPanel
            // 
            this.justSavedPanel.Controls.Add(this.label3);
            this.justSavedPanel.Controls.Add(this.pictureBox1);
            this.justSavedPanel.Location = new System.Drawing.Point(299, 173);
            this.justSavedPanel.Name = "justSavedPanel";
            this.justSavedPanel.Size = new System.Drawing.Size(70, 56);
            this.justSavedPanel.TabIndex = 6;
            this.justSavedPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "saved";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimKit.Properties.Resources.app_blue_tick;
            this.pictureBox1.Location = new System.Drawing.Point(9, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 14);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.disconnectButton);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(372, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 56);
            this.panel2.TabIndex = 6;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disconnectButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.disconnectButton.DownImage = null;
            this.disconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectButton.HoverImage = global::SimKit.Properties.Resources.app_red_button_over;
            this.disconnectButton.Location = new System.Drawing.Point(3, 3);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.NormalImage = global::SimKit.Properties.Resources.app_red_button_out;
            this.disconnectButton.Size = new System.Drawing.Size(110, 50);
            this.disconnectButton.TabIndex = 4;
            this.disconnectButton.TabStop = false;
            this.disconnectButton.Text = "Eject";
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 90);
            this.label4.TabIndex = 7;
            this.label4.Text = "If you have finished working with\r\nthis card, you can eject it and work\r\nwith ano" +
    "ther.\r\n\r\nClick the eject button below and\r\nfollow the instructions.";
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Gray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 298;
            this.lineShape1.X2 = 492;
            this.lineShape1.Y1 = 259;
            this.lineShape1.Y2 = 259;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(500, 500);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // EditingCardContentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.justSavedPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messagesContainerPanel);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EditingCardContentPanel";
            this.Size = new System.Drawing.Size(500, 500);
            ((System.ComponentModel.ISupportInitialize)(this.saveCardButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.justSavedPanel.ResumeLayout(false);
            this.justSavedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.disconnectButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel messagesContainerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private SIMKIT.UserInterface.CustomControls.ImageButton saveCardButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel justSavedPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private SIMKIT.UserInterface.CustomControls.ImageButton disconnectButton;
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;

    }
}
