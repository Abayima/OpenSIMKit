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
    public partial class EjectingCardContentPanel : UserControl
    {
        internal  EjectingCardContentPanel(MainApplicationWindow parent, Card card)
        {
            //Init the UI
            InitializeComponent();

            //Let the system know the card is being removed
            Dependencies.SystemContext.CardIsBeingRemoved(card);

            //Set a timer to wait then reset the content panel
            var t = new Timer { Interval = 2000 };
            t.Tick += delegate(object sender, EventArgs e)
                {
                    t.Enabled = false;
                    var eventArgs = new MainApplicationWindow.ContentPanelStateChangeEventArgs
                        {
                            ContentPanelState = MainApplicationWindow.ContentPanelStates.Waiting,
                        };
                    parent.RaiseContentPanelStateChange(this, eventArgs);
                };
            t.Enabled = true;
        }
    }
}
