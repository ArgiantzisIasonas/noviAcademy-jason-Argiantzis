using Domain.Entity;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Strategies
{
    public interface IFundsStrategy
    {
        FundsOperation Operation { get; }

        void Execute(Wallet wallet , decimal amount)
        {

        }
    }
}
