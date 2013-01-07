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
            this.cardSavedLabel = new System.Windows.Forms.Label();
            this.saveCardButton = new SIMKIT.UserInterface.CustomControls.ImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.saveCardButton)).BeginInit();
            this.panel1.SuspendLayout();
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
            // cardSavedLabel
            // 
            this.cardSavedLabel.AutoSize = true;
            this.cardSavedLabel.Location = new System.Drawing.Point(309, 197);
            this.cardSavedLabel.Name = "cardSavedLabel";
            this.cardSavedLabel.Size = new System.Drawing.Size(38, 13);
            this.cardSavedLabel.TabIndex = 3;
            this.cardSavedLabel.Text = "Saved";
            this.cardSavedLabel.Visible = false;
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
            // EditingCardContentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cardSavedLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messagesContainerPanel);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EditingCardContentPanel";
            this.Size = new System.Drawing.Size(500, 500);
            ((System.ComponentModel.ISupportInitialize)(this.saveCardButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel messagesContainerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cardSavedLabel;
        private SIMKIT.UserInterface.CustomControls.ImageButton saveCardButton;
        private System.Windows.Forms.Panel panel1;

    }
}
