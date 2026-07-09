using System;
using System.Collections.Generic;
using System.Text;

namespace WorldRank.CustomException
{
    public class NotTheSameCurrency: WalletException
    {
        public NotTheSameCurrency(Currency cur, Currency cur2)
        {
            if (cur == cur2)
            {
                throw new WalletException("You can't have the same currency");
            }
        }
    }
}
