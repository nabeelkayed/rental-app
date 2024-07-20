using RentApp.Payment.Service;
using RentApp.Properties;
using RentApp.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentApp.Rental.Service
{
    public class RentalService
    {
        private readonly IPaymentService _payment;
        private readonly List<Contract> Contracts = new List<Contract>();

        public RentalService(IPaymentService payment)
        {
            _payment = payment;
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
        public string RentProperty(Customer customer, string cardSecurityCode, PropertyOwner propertyOwner, Property property, DateTime starDate, DateTime endDate)
        {
            if (property.GetIsRented())
            {
                return "The property is already rented";
            }
            else if(!customer.CheckBalance(property.GetRentPrice())){
                return "The customer does not has enough budget to rent this proprty";
            }
            else
            {
                bool transactionHappend = _payment.CreateTransaction(customer.GetCard(), cardSecurityCode, propertyOwner.GetCard(), property.GetRentPrice());
                if (transactionHappend)
                {
                    property.SetIsRented(true);
                    Contract contract = new Contract(property, propertyOwner, customer, starDate, endDate, property.GetRentPrice());
                    AddContract(contract.CreateContractCopy());
                    customer.AddContract(contract.CreateContractCopy());
                    propertyOwner.AddContract(contract.CreateContractCopy());
                    return "The rent action has been done successfully";
                }
                return "The security code is wrong";
            }
        }
    }
}