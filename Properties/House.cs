using System;
using System.Collections.Generic;
using System.Text;

namespace RentApp.Properties
{
    public class House : Property
    {
        private readonly bool hasGarden;
        public House(string name, string address, double size, decimal rentPrice, decimal buyingPrice, bool hasGarden)
            : base(name, address, size, rentPrice, buyingPrice,false)
        {
            this.hasGarden= hasGarden;
        }
        public bool GetHasGarden()
        {
            return hasGarden;
        }
        public override string GetDetails()
        {
            return "Name: " + name + ", Address: " + address + ", Size: " + size + ", Rental Price: " + rentPrice + "$, Has Garden: " + hasGarden;
        }
    }
}