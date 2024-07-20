using System;
using System.Collections.Generic;
using System.Text;

namespace RentApp.Cards
{
    public interface ICard
    {
        decimal GetBalance();
        string GetCardNumber();
        void Deposit(decimal amount);
        decimal Withdraw(decimal amount,string securityCode);
    }
}