using System;
using System.Collections.Generic;
using System.Text;

namespace SimKit.Framework.ConnectivityContext
{
    class MockConnectivityContext : IConnectivityContext
    {
        #region Fields

        private UserConnectivityChoicesEnum userConnectivityChoices = UserConnectivityChoicesEnum.NoConnectivity;

        #endregion

        #region IConnectivityContext Members

        public void SetUserConnectivityChoices(bool recordUse, bool recordUserData)
        {
            //If the user concents, record the use of SIMKit
            if (recordUse)
                RecordUse();

            //Set the UserConnectivityChoicesEnum based on the recodeUserData bool
            if (recordUserData)
                userConnectivityChoices = UserConnectivityChoicesEnum.UserAllowsFullConnectivity;
            else
                userConnectivityChoices = UserConnectivityChoicesEnum.UserDoesNotAllowFullConnectivity;
        }

        #endregion

        #region Methods

        private void RecordUse()
        {
            Console.Write("Recording use of SIMKit");
        }

        #endregion
    }
}
