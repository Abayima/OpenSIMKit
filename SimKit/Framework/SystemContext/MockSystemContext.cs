using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SimKit.Framework.SystemContext
{
    class MockSystemContext : ISystemContext
    {
        #region Fields

        private bool hasCard;

        #endregion

        #region ISystemContent Members

        public event EventHandler<CardSavedEventArgs> CardSavedFinished;

        public double SystemPollInterval
        {
            get { return 500; }
        }

        public Card GetCardConnectedToSystem(out List<Card> potentiallyConnectedCards)
        {
            if (this.hasCard)
            {
                potentiallyConnectedCards = new List<Card>();
                return new Card(256, 3);
            }
            else
            {
                potentiallyConnectedCards = new List<Card>
                    {
                        new Card("There is a Nokia N34 connected by USB cable is not supported by SIMKit"),
                    };
                return null;
            }
        }

        public void BeginSaveCard(Card card)
        {
            ParameterizedThreadStart threadStart = delegate { BeginSaveCardAsync(card); };
            new Thread(threadStart).Start();
        }

        #endregion

        #region Constructors

        internal MockSystemContext(bool hasCard)
        {
            this.hasCard = hasCard;
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
