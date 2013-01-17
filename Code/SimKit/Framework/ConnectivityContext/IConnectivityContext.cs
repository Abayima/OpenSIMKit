using System;
using System.Collections.Generic;
using System.Text;

namespace SimKit.Framework.ConnectivityContext
{
    internal interface IConnectivityContext
    {
        void SetUserConnectivityChoices(bool recordUse, bool recordUserData);
    }
}
