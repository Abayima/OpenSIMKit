using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SimKit.Framework.ConnectivityContext
{
    internal class VersionAlphaConnectivityContext : IConnectivityContext
    {
        #region Fields

        private UserConnectivityChoicesEnum userConnectivityChoice;

        #endregion

        #region IConnectivityContent Members

        public void SetUserConnectivityChoices(bool recordUse, bool recordUserData)
        {
            //If its ok to record the initial use of the product then do so
            if (recordUse)
                RecordUse();

            //Set the user chose for recording further activity
            this.userConnectivityChoice = (recordUserData)
                ? UserConnectivityChoicesEnum.UserAllowsFullConnectivity
                : UserConnectivityChoicesEnum.UserDoesNotAllowFullConnectivity;
        }

        #endregion

        #region Methods

        private void RecordUse()
        {
            try
            {
                //Make a call to the opensimkit api
                var request = WebRequest.Create(SimKit.Properties.Resources.api_record_app_use);
                var response = request.GetResponse();
            }
            catch (Exception e)
            {
                Dependencies.LoggingContext.Error("VersionAlphaConnectivityContext:RecordUse()", e);
            }
        }

        #endregion
    }
}
