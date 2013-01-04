using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using SimKit.Framework;

namespace SimKit.UserInterface.ContentPanels
{
    public partial class WaitingContentPanel : UserControl
    {
        #region Fields

        private System.Timers.Timer checkSystemForCardsTimer;
        private MainApplicationWindow parent;

        #endregion

        #region Constructors

        public WaitingContentPanel(MainApplicationWindow parent)
        {
            //Set the parent to a reference of the MainApplicationWindow
            this.parent = parent;

            //Initialize the control UI
            InitializeComponent();

            //Hook up any local event handlers
            InitializeInternalEventsAndTimers();
        }

        #endregion

        #region Methods

        private void InitializeInternalEventsAndTimers()
        {
            //Instanciate the timer
            this.checkSystemForCardsTimer = new System.Timers.Timer(Dependencies.SystemContext.SystemPollInterval);

            //Hookup to the disposed method to cancle the timer
            this.Disposed += WaitingContentPanel_Disposed;

            //Attached the time elapsed event 
            this.checkSystemForCardsTimer.Elapsed += checkSystemForCardsTimer_Elapsed;

            //Start the Check System for Cards timer
            this.checkSystemForCardsTimer.Enabled = true;
        }

        private void checkSystemForCardsTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //Check the system to see if a card is present
            List<Card> potentiallyConnectedCards;
            var connectedCard = Dependencies.SystemContext.GetCardConnectedToSystem(out potentiallyConnectedCards);

            //If there is no feedback, stay with this content panel
            if (connectedCard == null && potentiallyConnectedCards.Count == 0)
                return;

            //Build the event args to pass back up to the main application window
            var eventArgs = new MainApplicationWindow.ContentPanelStateChangeEventArgs
                {
                    PotentiallyConnectedCards = potentiallyConnectedCards,
                    ConnectedCard = connectedCard,
                    ContentPanelState = (connectedCard != null)
                        ? MainApplicationWindow.ContentPanelStates.CardFound
                        : MainApplicationWindow.ContentPanelStates.CardNotFound
                };

            //Raise the ContentPanelStateChange event
            this.parent.RaiseContentPanelStateChange(this, eventArgs);

            //kill the timer
            this.checkSystemForCardsTimer.Enabled = false;
        }

        private void WaitingContentPanel_Disposed(object sender, EventArgs e)
        {
            this.checkSystemForCardsTimer.Enabled = false;
        }

        #endregion
    }
}
