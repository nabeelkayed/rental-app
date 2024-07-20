using System;
using System.Collections.Generic;
using System.Text;

namespace RentApp.Properties
{
    public class Shop : Property
    {
        private readonly bool hasParking;

        public Shop(string name, string address, double size, decimal rentPrice, decimal buyingPrice, bool hasParking)
            : base(name, address, size, rentPrice, buyingPrice, false)
        {
            this.hasParking = hasParking;
        }
        public bool GetHasParking()
        {
            return hasParking;
        }
        public override string GetDetails()
        {
            return "Name: " + name + ", Address: " + address + ", Size: " + size + ", Rental Price: " + rentPrice + "$, Has Parking: " + hasParking;
        }
    }
}