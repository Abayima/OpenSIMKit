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

        }

        #endregion
    }
}
