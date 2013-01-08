using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimKit.UserInterface.CustomControls
{
    public partial class ErrorBlock : UserControl
    {
        #region Constructors

        public ErrorBlock(string errorMessage)
        {
            //Init the UI
            InitializeComponent();

            //Resize the UI based on the size of the message
            ResizeControl(errorMessage);
        }

        #endregion

        #region Methods

        private void ResizeControl(string errorMessage)
        {
            //Set the text of the label to the error message 
            this.errorMessageLabel.Text = errorMessage;
            
            //Reset the size of this user control
            this.Height = this.errorMessageLabel.Height + 30 + 15; //30 = top and bottom, 15 = padding
            
            //Re-place the bottom picture
            this.bottomPictureBox.Location = new Point(0, this.Height - 15);
        }

        #endregion
    }
}
