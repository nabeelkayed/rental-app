using RentApp.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentApp.Payment.Service
{
    public class PaymentService : IPaymentService
    {
        public bool CreateTransaction(ICard fromCard, string fromCardSecurityCode, ICard toCard, decimal amount)
        {
            decimal withdrawalAmount = fromCard.Withdraw(amount, fromCardSecurityCode);
            if (withdrawalAmount != -1)
            {
                toCard.Deposit(withdrawalAmount);
                return true;
            }
            return false;
         
        }
    }
}