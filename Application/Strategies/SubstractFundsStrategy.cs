using WorldRank.Domain.Entity;
using WorldRank.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Strategies
{
    public class SubstractFundsStrategy : IFundsStrategy
    {
        public FundsOperation Operation => FundsOperation.Subtract;

        public void Execute(Wallet wallet, decimal amount)
        {
            wallet.Withdraw(amount);
        }
    }
}
