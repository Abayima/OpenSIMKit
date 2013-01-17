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
    public partial class CardNotFoundMessage : UserControl
    {
        private MainApplicationWindow parent;
        private List<Card> potentiallyConnectedCards;

        internal CardNotFoundMessage(MainApplicationWindow parent, List<Card> potentiallyConnectedCards)
        {
            this.parent = parent;
            this.potentiallyConnectedCards = potentiallyConnectedCards;

            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            var eventArgs = new MainApplicationWindow.ContentPanelStateChangeEventArgs
                {
                    ContentPanelState = MainApplicationWindow.ContentPanelStates.CardNotFound,
                    PotentiallyConnectedCards = this.potentiallyConnectedCards
                };

            this.parent.RaiseContentPanelStateChange(this, eventArgs);
        }
    }
}
