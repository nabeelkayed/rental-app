using System;
using System.Collections.Generic;
using System.Text;

namespace RentApp.Cards
{
    public class CreditCard : ICard
    {
        private decimal balance;
        private readonly string cardNumber;
        private readonly string securityCode;
        public CreditCard(decimal balance, string cardNumber, string securityCode)
        {
            this.balance = balance;
            this.cardNumber = cardNumber;
            this.securityCode = securityCode;
        }
        public decimal GetBalance()
        {
            return balance;
        }
        public string GetCardNumber()
        {
            return cardNumber;
        }
        public void Deposit(decimal amount)
        {
            //implement the Deposit by using the credit card approch
            balance += amount;
        }
        public decimal Withdraw(decimal amount, string securityCode)
        {
            if (this.securityCode == securityCode)
            {
                //implement the Withdraw by using the credit card approch
                balance -= amount;
                return amount;
            }
            return -1;
        }
    }
}