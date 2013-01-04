using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SimKit.Framework
{
    internal class Card
    {
        #region Fields

        private bool isConnected;
        private CardMessage[] messages;
        private ConnectivityErrorInformation connectivityErrorInformation;

        #endregion

        #region Properties

        internal CardMessage[] Messages
        {
            get { return this.messages; }
        }

        #endregion

        #region Construtors

        public Card(int maxMessageLength, int numberOfMessages)
        {
            this.isConnected = true;
            this.messages = new CardMessage[numberOfMessages];
            for (var x = 0; x < numberOfMessages; x++)
                this.messages[x] = new CardMessage(maxMessageLength, string.Empty);
        }

        public Card(int maxMessageLength, string[] messages)
        {
            this.isConnected = true;
            this.messages = new CardMessage[messages.Length];
            for (var x = 0; x < messages.Length; x++)
                this.messages[x] = new CardMessage(maxMessageLength, messages[x]);
        }

        public Card(string connectivityErrorSummary)
        {
            this.isConnected = false;
            this.connectivityErrorInformation = new ConnectivityErrorInformation
                {
                    ErrorSummary = connectivityErrorSummary
                };
        }

        #endregion

        #region Nested Classes

        internal class CardMessage
        {
            #region Fields

            private int maxMessageLength = 256;
            private TextBox messageBox;

            #endregion

            #region Properties

            internal TextBox MessageBox
            {
                get 
                {
                    return this.messageBox; 
                }
            }

            #endregion 

            #region Constructors

            internal CardMessage(int maxMessageLength, string message)
            {
                this.maxMessageLength = maxMessageLength;
                this.messageBox = new TextBox { Text = message, MaxLength = maxMessageLength };
                this.messageBox.TextChanged += messageBox_TextChanged;
            }

            #endregion

            #region Event Handlers

            private void messageBox_TextChanged(object sender, EventArgs e)
            {
                //Get a local instance of the TextBox being edited
                var messageBox = sender as TextBox;

                //If the max chars has been reached let the user know
                if (messageBox.Text.Length == messageBox.MaxLength)
                    System.Windows.Forms.MessageBox.Show(
                        "Each message can contain up to " + messageBox.MaxLength + " characters.",
                        "No more will fit in this message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }

            #endregion
        }

        internal class ConnectivityErrorInformation
        {
            internal string ErrorSummary { get; set; }
        }

        #endregion
    }
}
