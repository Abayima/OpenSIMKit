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
    public partial class SavingCardContentPanel : UserControl
    {
        #region Fields

        private MainApplicationWindow parent;
        private Card card;

        #endregion

        #region Constructors

        internal SavingCardContentPanel(MainApplicationWindow parent, Card card)
        {
            //Save the reference to the parent
            this.parent = parent;

            //Save the reference to the card object
            this.card = card;

            //Initialize the UI
            InitializeComponent();

            //Attach any event handlers
            AttacheInternalEventHandlers();

            //Start saving the card
            SaveCardAndHandleReturn();
        }

        #endregion

        #region Event Handlers

        private void SystemContext_CardSavedFinished(object sender, Framework.SystemContext.CardSavedEventArgs e)
        {
            //Build the event args to pass up to the main application window
            var eventArgs = new MainApplicationWindow.ContentPanelStateChangeEventArgs
            {
                ContentPanelState = MainApplicationWindow.ContentPanelStates.CardSaved,
                ConnectedCard = this.card
            };

            //Raise the event on the main application window
            this.parent.RaiseContentPanelStateChange(this, eventArgs);
        }

        #endregion

        #region Methods

        private void AttacheInternalEventHandlers()
        {
            //Attache to the SystemContext Card Saved Finished event
            Dependencies.SystemContext.CardSavedFinished += SystemContext_CardSavedFinished;
        }

        private void SaveCardAndHandleReturn()
        {
            //Call the system context and save the card object
            Dependencies.SystemContext.BeginSaveCard(this.card);
        }

        #endregion
    }
}
