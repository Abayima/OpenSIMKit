using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimKit.UserInterface.ContentPanels.PreAlphaMessaging
{
    public partial class WelcomeToThePreAlpha : UserControl
    {
        private MainApplicationWindow parent;

        public WelcomeToThePreAlpha(MainApplicationWindow parent)
        {
            this.parent = parent;

            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            var eventArgs = new MainApplicationWindow.ContentPanelStateChangeEventArgs
                {
                    ContentPanelState = MainApplicationWindow.ContentPanelStates.ConnectionQuestions
                };

            parent.RaiseContentPanelStateChange(this, eventArgs);
        }
    }
}
