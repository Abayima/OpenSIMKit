using SimKit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimKit.UserInterface
{
    public partial class MainApplicationWindow : Form
    {
        #region Events

        internal event EventHandler<ContentPanelStateChangeEventArgs> ContentPanelStateChange;

        #endregion

        #region Fields

        private bool internetIsAvailable;

        #endregion

        #region Constructors

        public MainApplicationWindow()
        {
            //Run the splash screen and associated checks
            InitAndRunSplashScreen();

            //Init the form
            InitializeComponent();

            //Hook up any local event handlers
            InitializeInternalEvents();

            //If the internet is available then show the connection question content panel, else start looking for cards
            if (this.internetIsAvailable)
                RaiseContentPanelStateChange(this, new MainApplicationWindow.ContentPanelStateChangeEventArgs { ContentPanelState = ContentPanelStates.ConnectionQuestions });
            else
                RaiseContentPanelStateChange(this, new MainApplicationWindow.ContentPanelStateChangeEventArgs { ContentPanelState = ContentPanelStates.Waiting });
        }

        #endregion

        #region Methods

        internal void RaiseContentPanelStateChange(object sender, MainApplicationWindow.ContentPanelStateChangeEventArgs e)
        {
            ContentPanelStateChange(sender, e);
        }

        internal void OpenWebBrowserOrShowInternetAddressInMessageBox(string address)
        {
            if (this.internetIsAvailable)
                Process.Start(address);
            else
                MessageBox.Show(
                    "SIMKit couldn't find a connection to the Internet. You can find what you were looking for by going " +
                    "to the following address in your web browser:\n\n" + address,
                    "Are you connected to the Internet?",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void InitAndRunSplashScreen()
        {
            var splashScreen = new ApplicationLoading();
            splashScreen.ApplicationLoaded += splashScreen_ApplicationLoaded;
            Application.Run(splashScreen);
        }

        private void InitializeInternalEvents()
        {
            //Attached the event handler to change the state of the content panel
            ContentPanelStateChange += MainApplicationWindow_ContentPanelStateChange;
        }

        #endregion

        #region Event Handlers

        private void MainApplicationWindow_ContentPanelStateChange(object sender, MainApplicationWindow.ContentPanelStateChangeEventArgs e)
        {
            //Check we are on the UI thread
            if (this.contentPanel.InvokeRequired)
            {
                this.contentPanel.Invoke(new MethodInvoker(delegate { MainApplicationWindow_ContentPanelStateChange(sender, e); }));
                return;
            }

            //Remove the current state of the content panel
            this.contentPanel.Controls.Clear();

            switch (e.ContentPanelState)
            {
                case ContentPanelStates.EjectingCard:
                    this.contentPanel.Controls.Add(new ContentPanels.EjectingCardContentPanel(this, e.ConnectedCard));
                    break;
                case ContentPanelStates.ConnectionQuestions:
                    if (sender is ContentPanels.PreAlphaMessaging.WelcomeToThePreAlpha)
                        this.contentPanel.Controls.Add(new ContentPanels.ConnectionQuestionsContentPanel(this));
                    else
                        this.contentPanel.Controls.Add(new ContentPanels.PreAlphaMessaging.WelcomeToThePreAlpha(this));
                    break;
                case ContentPanelStates.CardNotFound:
                    if (sender is ContentPanels.PreAlphaMessaging.CardNotFoundMessage)
                        this.contentPanel.Controls.Add(new ContentPanels.ConnectionErrorContentPanel(this, e.PotentiallyConnectedCards));
                    else
                        this.contentPanel.Controls.Add(new ContentPanels.PreAlphaMessaging.CardNotFoundMessage(this, e.PotentiallyConnectedCards));
                    break;
                case ContentPanelStates.CardFound:
                    if (sender is ContentPanels.PreAlphaMessaging.CardFoundMessage)
                        this.contentPanel.Controls.Add(new ContentPanels.EditingCardContentPanel(this, e.ConnectedCard, false));
                    else
                        this.contentPanel.Controls.Add(new ContentPanels.PreAlphaMessaging.CardFoundMessage(this, e.ConnectedCard));
                    break;
                case ContentPanelStates.CardSaved:
                    this.contentPanel.Controls.Add(new ContentPanels.EditingCardContentPanel(this, e.ConnectedCard, true));
                    break;
                case ContentPanelStates.SavingCard:
                    this.contentPanel.Controls.Add(new ContentPanels.SavingCardContentPanel(this, e.ConnectedCard));
                    break;
                case ContentPanelStates.Waiting:
                default:
                    this.contentPanel.Controls.Add(new ContentPanels.WaitingContentPanel(this));
                    break;
            }
        }

        private void splashScreen_ApplicationLoaded(object sender, EventArgs e)
        {
            //Set the connectivity state
            var eventArgs = e as ApplicationLoading.ApplicationLoadingEventArgs;
            this.internetIsAvailable = eventArgs.InternetIsAvailable;

            //Close the splash screen
            (sender as ApplicationLoading).Close();
        }

        private void socialGithubButton_Click(object sender, EventArgs e)
        {
            OpenWebBrowserOrShowInternetAddressInMessageBox("http://www.github.com/abayima/opensimkit");
        }

        private void socialTwitterButton_Click(object sender, EventArgs e)
        {
            OpenWebBrowserOrShowInternetAddressInMessageBox("https://twitter.com/search?q=open%20sim%20kit&src=typd");
        }

        private void socialHomeButton_Click(object sender, EventArgs e)
        {
            OpenWebBrowserOrShowInternetAddressInMessageBox("http://www.opensimkit.com");
        }

        private void abayimaButton_Click(object sender, EventArgs e)
        {
            OpenWebBrowserOrShowInternetAddressInMessageBox("http://www.abayima.com");
        }

        private void devWikiLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWebBrowserOrShowInternetAddressInMessageBox("http://dev.opensimkit.com");
        }

        private void knightNewsChallengeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWebBrowserOrShowInternetAddressInMessageBox("http://blog.abayima.com/abayima-wins-in-the-2012-knight-news-challenge/");
        }

        #endregion

        #region Nested Classes

        internal class ContentPanelStateChangeEventArgs : EventArgs
        {
            internal ContentPanelStates ContentPanelState { get; set; }

            internal Card ConnectedCard { get; set;}

            internal List<Card> PotentiallyConnectedCards { get; set; }
        }

        internal enum ContentPanelStates
        {
            ConnectionQuestions,
            Waiting,
            CardFound,
            CardNotFound,
            SavingCard,
            CardSaved,
            EjectingCard,
        }

        #endregion
    }
}
