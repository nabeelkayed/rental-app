using System;
using System.Collections.Generic;
using System.Text;

namespace RentApp.Properties
{
    public class Apartment : Property 
    {
        private readonly int floor;
        public Apartment (string name, string address, double size , decimal rentPrice, decimal buyingPrice, int floor)
            : base(name, address,size, rentPrice, buyingPrice, false)
        {
            this.floor=floor;
        }
        public int GetFloor()
        {
            return floor;
        }
        public override string GetDetails()
        {
           return "Name: " + name + ", Address: " + address + ", Size: " + size + ", Rental Price: " + rentPrice + "$, Floor: " + floor;
        }
    }
}
