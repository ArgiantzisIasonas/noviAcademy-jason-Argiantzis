using WorldRank.Domain.Entity;
using WorldRank.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Strategies
{
    public class AddFundsStrategy : IFundsStrategy
    {
        public FundsOperation Operation => FundsOperation.Add;

        public void Execute(Wallet wallet, decimal amount)
        {
            wallet.Deposit(amount);
        }
    }
}
