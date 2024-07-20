using RentApp.Properties;
using RentApp.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentApp.Rental.Service
{
    public class Contract
    {
        private readonly Property property;
        private readonly PropertyOwner propertyOwner;
        private readonly Customer customer;
        private readonly DateTime startDate;
        private readonly DateTime endDate;
        private readonly decimal rentPrice;
        public Contract(Property property, PropertyOwner propertyOwner, Customer customer, DateTime startDate, DateTime endDate, decimal rentPrice)
        {
            this.property = property;
            this.propertyOwner = propertyOwner;
            this.customer = customer;
            this.startDate = startDate;
            this.endDate = endDate;
            this.rentPrice = rentPrice;
        }
        public Contract CreateContractCopy()
        {
          return new Contract(property, propertyOwner, customer, startDate, endDate, rentPrice);
        }
        public string GetContractDetails()
        {
            return customer.GetName() + " have rent " + property.GetName() + " from " + propertyOwner.GetName()
                    + " for the period from " + startDate.ToShortDateString() + " to " + endDate.Date.ToShortDateString() + " with rent price: " + rentPrice + "$" + "\n" +
                "Proparity details -> " + property.GetDetails() + "\n";
        }
    }
}