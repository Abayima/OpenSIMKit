using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SimKit.Framework.SystemContext
{
    class MockSystemContext : ISystemContext
    {
        #region ISystemContent Members

        public event EventHandler<CardSavedEventArgs> CardSavedFinished;

        public double SystemPollInterval
        {
            get { return 500; }
        }

        public Card GetCardConnectedToSystem(out List<Card> potentiallyConnectedCards)
        {
            potentiallyConnectedCards = new List<Card>();
            return new Card(256, 3);
        }

        public void BeginSaveCard(Card card)
        {
            ParameterizedThreadStart threadStart = delegate { BeginSaveCardAsync(card); };
            new Thread(threadStart).Start();
        }

        #endregion

        #region Methods

        private void BeginSaveCardAsync(Card card)
        {
            System.Threading.Thread.Sleep(2000);

            if (this.CardSavedFinished != null)
                CardSavedFinished(this, new CardSavedEventArgs());
        }

        #endregion
    }
}
