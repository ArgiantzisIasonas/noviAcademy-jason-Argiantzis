using System;
using System.Collections.Generic;
using System.Text;
using WorldRank.CustomException;

namespace WorldRank
{
    public class Wallet
    {
        public decimal Balance { get;  set; }
        public Currency Currency { get;   set; }
        public bool IsBlocked { get; }

        public Wallet(decimal initialBalance, Currency currency_const,bool isBlocked)
        {
          
           new InsufficientFundException(initialBalance);
            Balance = initialBalance;
            Currency = currency_const;
            IsBlocked = false;
        }
    }
}
