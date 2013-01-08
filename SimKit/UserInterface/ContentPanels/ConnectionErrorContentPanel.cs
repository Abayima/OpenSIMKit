using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SimKit.Framework;
using SimKit.UserInterface.CustomControls;

namespace SimKit.UserInterface.ContentPanels
{
    public partial class ConnectionErrorContentPanel : UserControl
    {
        #region Fields

        private MainApplicationWindow parent;
        private List<Card> potentiallyConnectedCards;

        #endregion

        #region Constructors

        internal ConnectionErrorContentPanel(MainApplicationWindow parent, List<Card> potentiallyConnectedCards)
        {
            //Set the local instance of the parent
            this.parent = parent;

            //Set the local instance of the potentially connected cards
            this.potentiallyConnectedCards = potentiallyConnectedCards;

            //Initialize the UI
            InitializeComponent();

            //Display the connection errors
            DisplayConnectionErrors();
        }

        #endregion

        #region Methods

        private void DisplayConnectionErrors()
        {
            foreach (var card in this.potentiallyConnectedCards)
                this.connectionErrorsPanel.Controls.Add(new ErrorBlock(card.ConnectivityError.ErrorSummary));
        }

        #endregion

        #region Event Handlers

        private void rescanButton_Click(object sender, EventArgs e)
        {
            //Build the event args to pass up to the parent
            var eventArgs = new MainApplicationWindow.ContentPanelStateChangeEventArgs
                {
                    ContentPanelState = MainApplicationWindow.ContentPanelStates.Waiting
                };

            //Raise the content panel change event on the parent
            this.parent.RaiseContentPanelStateChange(this, eventArgs);
        }

        private void instructionHelpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.parent.OpenWebBrowserOrShowInternetAddressInMessageBox(SimKit.Properties.Resources.link_help_stepbystep);
        }

        private void devicesHelpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.parent.OpenWebBrowserOrShowInternetAddressInMessageBox(SimKit.Properties.Resources.link_help_devices);
        }

        private void contributeHelpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.parent.OpenWebBrowserOrShowInternetAddressInMessageBox(SimKit.Properties.Resources.link_help_contribute);
        }

        #endregion
    }
}
