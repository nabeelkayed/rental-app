using RentApp.Cards;
using RentApp.Rental.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentApp.Users
{
    public class Customer
    {
        private string name;
        private readonly ICard _card;
        private readonly List<Contract> Contracts = new List<Contract>();

        public Customer(string name, ICard card)
        {
            this.name = name;
            _card = card;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string value)
        {
            name = value;
        }
        public ICard GetCard()
        {
            return _card;
        }
        public void AddContract(Contract contract)
        {
            Contracts.Add(contract);
        }
        public string GetContracts()
        {
            string contractsToReturn = "";
            foreach (Contract c in Contracts)
            {
                contractsToReturn += c.GetContractDetails() +"\n";
            }
            return contractsToReturn;
        }
        public bool CheckBalance(decimal value)
        {
           return _card.GetBalance() >= value;
        }
    
    }
}