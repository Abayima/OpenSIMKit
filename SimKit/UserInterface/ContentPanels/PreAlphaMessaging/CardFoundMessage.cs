using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SimKit.Framework;

namespace SimKit.UserInterface.ContentPanels.PreAlphaMessaging
{
    public partial class CardFoundMessage : UserControl
    {
        private MainApplicationWindow parent;
        private Card connectedCard;

        internal CardFoundMessage(MainApplicationWindow parent, Card connectedCard)
        {
            this.parent = parent;
            this.connectedCard = connectedCard;

            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            var eventArgs = new MainApplicationWindow.ContentPanelStateChangeEventArgs
                {
                    ContentPanelState = MainApplicationWindow.ContentPanelStates.CardFound,
                    ConnectedCard = this.connectedCard,
                };

            this.parent.RaiseContentPanelStateChange(this, eventArgs);
        }
    }
}
