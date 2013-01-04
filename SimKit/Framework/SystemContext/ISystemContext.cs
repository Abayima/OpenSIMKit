using System;
using System.Collections.Generic;
using System.Text;

namespace SimKit.Framework.SystemContext
{
    internal interface ISystemContext
    {
        event EventHandler<CardSavedEventArgs> CardSavedFinished;

        double SystemPollInterval { get; }

        Card GetCardConnectedToSystem(out List<Card> potentiallyConnectedCards);

        void BeginSaveCard(Card card);
    }
}


