using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SimKit.UserInterface
{
    public partial class ApplicationLoading : Form
    {
        #region Events

        public event EventHandler<EventArgs> ApplicationLoaded;

        #endregion

        #region Fields

        private BackgroundWorker checkInternetBackgroundWorker = new BackgroundWorker { WorkerReportsProgress = true };
        private bool internetIsAvailable = false;

        #endregion

        #region Constructors

        public ApplicationLoading()
        {
            InitializeComponent();
            checkInternetBackgroundWorker.DoWork += checkInternetBackgroundWorker_DoWork;
            checkInternetBackgroundWorker.RunWorkerCompleted += checkInternetBackgroundWorker_RunWorkerCompleted;
            checkInternetBackgroundWorker.RunWorkerAsync();
        }

        #endregion

        #region Methods

        private void checkInternetBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var eventArgs = new ApplicationLoadingEventArgs { InternetIsAvailable = this.internetIsAvailable };
            ApplicationLoaded(this, eventArgs);
        }

        private void checkInternetBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(2000);

            var request = WebRequest.Create("http://www.google.com");
            try
            {
                var response = request.GetResponse();
                this.internetIsAvailable = true;
            }
            catch (Exception ex)
            {
                this.internetIsAvailable = false;
            }
        }

        #endregion

        #region Nested Classes

        public class ApplicationLoadingEventArgs : EventArgs
        {
            public bool InternetIsAvailable { get; set; }
        }

        #endregion
    }
}
