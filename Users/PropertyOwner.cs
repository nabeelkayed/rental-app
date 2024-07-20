using RentApp.Properties;
using RentApp.Cards;
using RentApp.Rental.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentApp.Users
{
    public class PropertyOwner
    {
        private string name;
        private readonly ICard _card;
        private readonly List<Property> Properties = new List<Property>();
        private readonly List<Contract> Contracts = new List<Contract>();

        public PropertyOwner(string name, ICard card)
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
        public String GetProperties()
        {
            string propartiesToReturn = "";
            foreach (Property p in Properties)
            {
                propartiesToReturn += p.GetDetails() + "\n";
            }
            return propartiesToReturn;
        }
        public string BuyProperty(Property property, string securityCode)
        {
            if (_card.GetBalance() < property.GetRentPrice())
            {
                return "The property owner does not has enough budget to buy this proprty";
            }

            decimal withdrawalAmount = _card.Withdraw(property.GetRentPrice(), securityCode);
            if (withdrawalAmount != -1)
            {
                Properties.Add(property);
                return "The buing action has been done successfully";
            }
            return "The security code is wrong";
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
                contractsToReturn += c.GetContractDetails() + "\n";
            }
            return contractsToReturn;
        }
        
    }
}