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
            this.saveCardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messagesContainerPanel
            // 
            this.messagesContainerPanel.AutoScroll = true;
            this.messagesContainerPanel.Location = new System.Drawing.Point(16, 54);
            this.messagesContainerPanel.Name = "messagesContainerPanel";
            this.messagesContainerPanel.Size = new System.Drawing.Size(274, 425);
            this.messagesContainerPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "You are currently editing a SIM card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 78);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edit the text in any of the message \r\nboxes in the list on the left.\r\n\r\nWhen you " +
    "have finished editing, click\r\nthe save button below to store these\r\nmessages on " +
    "the card.";
            // 
            // cardSavedLabel
            // 
            this.cardSavedLabel.AutoSize = true;
            this.cardSavedLabel.Location = new System.Drawing.Point(306, 146);
            this.cardSavedLabel.Name = "cardSavedLabel";
            this.cardSavedLabel.Size = new System.Drawing.Size(38, 13);
            this.cardSavedLabel.TabIndex = 3;
            this.cardSavedLabel.Text = "Saved";
            this.cardSavedLabel.Visible = false;
            // 
            // saveCardButton
            // 
            this.saveCardButton.Location = new System.Drawing.Point(406, 141);
            this.saveCardButton.Name = "saveCardButton";
            this.saveCardButton.Size = new System.Drawing.Size(75, 23);
            this.saveCardButton.TabIndex = 4;
            this.saveCardButton.Text = "Save";
            this.saveCardButton.UseVisualStyleBackColor = true;
            this.saveCardButton.Click += new System.EventHandler(this.saveCardButton_Click);
            // 
            // EditingCardContentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.saveCardButton);
            this.Controls.Add(this.cardSavedLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messagesContainerPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EditingCardContentPanel";
            this.Size = new System.Drawing.Size(500, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel messagesContainerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cardSavedLabel;
        private System.Windows.Forms.Button saveCardButton;

    }
}
