using RentApp.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentApp.Payment.Service
{
    public interface IPaymentService
    {
        bool CreateTransaction(ICard fromCard, string securityCode, ICard toCard, decimal amount);
    }
}