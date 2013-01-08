using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SimKit.Framework;

namespace SimKit.UserInterface.ContentPanels
{
    public partial class EditingCardContentPanel : UserControl
    {
        #region Fields

        private MainApplicationWindow parent;
        private Card card;

        #endregion

        #region Constructors

        internal EditingCardContentPanel(MainApplicationWindow parent, Card card, bool justSaved)
        {
            //Set the local instance of the parent form
            this.parent = parent;

            //Set the local reference to the Card object
            this.card = card;

            //Initialize the UI
            InitializeComponent();

            //Initialize the message boxes
            InitializeMessageBoxes();

            //If just saved then show the saved message
            if (justSaved)
                ToggleJustSavedMessage();
        }

        #endregion

        #region Methods

        private void InitializeMessageBoxes()
        {
            for (var x = 0; x < card.Messages.Length; x++)
            {
                this.messagesContainerPanel.Controls.Add(new Label { Text = "Message Slot #" + (x + 1), Width = 250, Margin = new Padding(0) });
                var messageBox = card.Messages[x].MessageBox;
                messageBox.Width = 250;
                messageBox.Height = 50;
                messageBox.Multiline = true;
                messageBox.Margin = new Padding(0, 0, 0, 10);
                this.messagesContainerPanel.Controls.Add(messageBox);
            }
        }

        private void ToggleJustSavedMessage()
        {
            if (this.justSavedPanel.InvokeRequired)
            {
                this.justSavedPanel.Invoke(new MethodInvoker(delegate { ToggleJustSavedMessage(); }));
                return;
            }

            this.justSavedPanel.Visible = !this.justSavedPanel.Visible;

            if (!this.justSavedPanel.Visible)
                return;

            //Create and start a timer to hide the just saved message
            var t = new Timer { Interval = 1000 };
            t.Tick += delegate(object sender, EventArgs e) { t.Enabled = false; ToggleJustSavedMessage(); };
            t.Enabled = true;
        }

        #endregion

        #region Event Handlers

        private void saveCardButton_Click(object sender, EventArgs e)
        {
            //Save the card to the card
            Dependencies.SystemContext.BeginSaveCard(this.card);

            //Build the event args to pass back up to the main application window
            var eventArgs = new MainApplicationWindow.ContentPanelStateChangeEventArgs
                {
                    ContentPanelState = MainApplicationWindow.ContentPanelStates.SavingCard,
                    ConnectedCard = this.card
                };

            //raise the event on the parent
            this.parent.RaiseContentPanelStateChange(this, eventArgs);
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            //Build the event args to pass back up to the main application window
            var eventArgs = new MainApplicationWindow.ContentPanelStateChangeEventArgs
                {
                    ContentPanelState = MainApplicationWindow.ContentPanelStates.EjectingCard,
                    ConnectedCard = this.card,
                };

            //raise the event on the parent
            this.parent.RaiseContentPanelStateChange(this, eventArgs);
        }

        #endregion
    }
}
