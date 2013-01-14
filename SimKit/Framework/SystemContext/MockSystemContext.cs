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
        private int getCardCount = 0;

        #endregion

        #region ISystemContent Members

        public event EventHandler<CardSavedEventArgs> CardSavedFinished;

        public double SystemPollInterval
        {
            get { return 500; }
        }

        public Card GetCardConnectedToSystem(out List<Card> potentiallyConnectedCards)
        {
            this.getCardCount += 1;

            if (this.hasCard)
            {
                potentiallyConnectedCards = new List<Card>();
                return new Card(256, 10);
            }
            else
            {
                if (getCardCount < 2)
                {
                    potentiallyConnectedCards = new List<Card>
                        {
                            new Card(SimKit.Properties.Resources.error_devices_nodevices),
                        };
                }
                else if (getCardCount < 3)
                {
                    potentiallyConnectedCards = new List<Card>
                        {
                            new Card(SimKit.Properties.Resources.error_devices_nodevices),
                            new Card(SimKit.Properties.Resources.error_devices_devicenotsupported.Replace("[DEVICE]", "Nokia N95")),
                        };
                }
                else
                {
                    potentiallyConnectedCards = new List<Card>();
                    return new Card(256, 10);
                }
                return null;
            }
        }

        public void BeginSaveCard(Card card)
        {
            ParameterizedThreadStart threadStart = delegate { BeginSaveCardAsync(card); };
            new Thread(threadStart).Start();
        }

        public void CardIsBeingRemoved(Card card)
        {
            this.getCardCount = 0;
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
