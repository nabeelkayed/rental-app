using System;
using System.Collections.Generic;
using System.Text;

namespace RentApp.Properties
{
    public abstract class Property
    {
        protected string name;
        protected string address;
        protected double size;
        protected decimal rentPrice;
        protected decimal buyingPrice;
        protected bool isRented;

        public Property(string name, string address, double size, decimal rentPrice, decimal buyingPrice, bool isRented)
        {
            this.name = name;
            this.address = address;
            this.size = size;
            this.rentPrice = rentPrice;
            this.buyingPrice = buyingPrice;
            this.isRented = isRented;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string value)
        {
            name = value;
        }
        public string GetAddress()
        {
            return address;
        }
        public void SetAddress(string value)
        {
            address = value;
        }
        public double GetSize()
        {
            return size;
        }
        public void SetSize(double value)
        {
            size = value;
        }
        public decimal GetRentPrice()
        {
            return rentPrice;
        }
        public void SetRentPrice(decimal value)
        {
            rentPrice = value;
        }
        public decimal GetBuyingPrice()
        {
            return buyingPrice;
        }
        public void SetBuyingPrice(decimal value)
        {
            buyingPrice = value;
        }
        public bool GetIsRented()
        {
            return isRented;
        }
        public void SetIsRented(bool value)
        {
            isRented = value;
        }
        public abstract string GetDetails();
    }
}