using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SimKit.UserInterface.CustomControls;
using SimKit.Framework;

namespace SimKit.UserInterface.ContentPanels
{
    public partial class ConnectionQuestionsContentPanel : UserControl
    {
        #region Fields

        private MainApplicationWindow parent;
        private CustomCheckBox customCheckbox1 = new CustomCheckBox();
        private CustomCheckBox customCheckbox2 = new CustomCheckBox();

        #endregion

        #region Constructors

        public ConnectionQuestionsContentPanel(MainApplicationWindow parent)
        {
            //Set the local instance of the parent window
            this.parent = parent;

            //Init the UI
            InitializeComponent();

            //Add and configure the custom check boxes
            AddAndConfigureCustomCheckboxes();
        }

        #endregion

        #region Methods

        private void AddAndConfigureCustomCheckboxes()
        {
            this.customCheckboxContainer1.Controls.Add(this.customCheckbox1);
            this.customCheckboxContainer2.Controls.Add(this.customCheckbox2);
        }

        #endregion

        #region Event Handlers

        private void imageButton1_Click(object sender, EventArgs e)
        {
            //Collect the users choices from the UI elements
            var recordUse = this.customCheckbox1.Selected;
            var recordUserData = this.customCheckbox2.Selected;

            //Register the users connectivity choices with the framework
            var connectivityContext = Dependencies.ConnectivityContext;

            connectivityContext.SetUserConnectivityChoices(recordUse, recordUserData);

            //Build the event args to pass back up to the parent
            var eventArgs = new MainApplicationWindow.ContentPanelStateChangeEventArgs
                {
                    ContentPanelState = MainApplicationWindow.ContentPanelStates.Waiting
                };

            //Call the content pane even on the parent
            this.parent.RaiseContentPanelStateChange(this, eventArgs);
        }

        #endregion
    }
}
