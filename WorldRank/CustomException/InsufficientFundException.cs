using System;
using System.Collections.Generic;
using System.Text;

namespace WorldRank.CustomException
{
    public class InsufficientFundException : WalletException
    {
       public InsufficientFundException(decimal balance) {
            if (balance < 0)
            {
                throw new WalletException("You can't have negative balance sorry");
            }
        }
    }
}
