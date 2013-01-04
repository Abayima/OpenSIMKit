using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SimKit.Framework;

namespace SimKit.UserInterface.Modals
{
    public partial class SystemStartModal : UserControl
    {
        #region Events

        internal event EventHandler<EventArgs> ModalClose;

        #endregion

        #region Constructors

        public SystemStartModal(int parentWidth, int parentHeight)
        {
            InitializeComponent();
            SetupModalUICalculations(parentWidth, parentHeight);
        }

        #endregion

        #region Methods

        private void SetupModalUICalculations(int parentWidth, int parentHeight)
        {
            this.Width = parentWidth;
            this.Height = parentHeight;
            this.modalContent.Top = (this.Height - this.modalContent.Height) / 2 - 10;
            this.modalContent.Left = (this.Width - this.modalContent.Width) / 2;
            this.Refresh();
        }

        #endregion

        #region UI Event Handlers

        private void continueButton_Click(object sender, EventArgs e)
        {
            //Collect the users choices from the UI elements
            var recordUse = this.registerUseCheckbox.Checked;
            var recordUserData = this.collectUsageDataCheckbox.Checked;

            //Register the users connectivity choices with the framework
            Dependencies.ConnectivityContext.SetUserConnectivityChoices(recordUse, recordUserData);

            //Fire the modal close event
            ModalClose(this, EventArgs.Empty);
        }

        #endregion
    }
}
