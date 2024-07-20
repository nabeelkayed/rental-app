using RentApp.Rental.Service;
using RentApp.Payment.Service;
using RentApp.Properties;
using RentApp.Users;
using RentApp.Cards;
using System;

namespace RentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var propertyOwner = new PropertyOwner("Ahmad Kayed", new PayPalCard(5000, "156389535135623", "1234"));
            var customer = new Customer("Nabeel Kayed", new CreditCard(2000, "156389535135623", "1234"));

            var paymentService = new PaymentService();
            var rentalService = new RentalService(paymentService);

            var apartment = new Apartment("Downtown Apartment", "123 Main St", 80, 1500,3000, 5);
            var house = new House("Suburban House", "456 Maple St", 200, 2500,3500, true);
            var firstShop = new Shop("Burger Shop", "568 Eflrm St", 70, 200,500, false);
            var secondShop = new Shop("Corner Shop", "789 Elm St", 50, 200, 700, false);

            Console.WriteLine("---------------------------------------------------------------------------------------");

            Console.WriteLine("Customer balance before renting: " + customer.GetCard().GetBalance() + "$");
            Console.WriteLine("Property owner balance before buying and renting: " + propertyOwner.GetCard().GetBalance() + "$");

            Console.WriteLine("---------------------------------------------------------------------------------------");

            var buyAction1 = propertyOwner.BuyProperty(apartment,"1234");
            Console.WriteLine(buyAction1 + "\n");
            var buyAction2 = propertyOwner.BuyProperty(firstShop, "1234");
            Console.WriteLine(buyAction2 + "\n");
            var buyAction3 = propertyOwner.BuyProperty(secondShop, "1234");
            Console.WriteLine(buyAction3 + "\n");
            var buyAction4 = propertyOwner.BuyProperty(house, "1234");
            Console.WriteLine(buyAction4 + "\n");
            var buyAction5 = propertyOwner.BuyProperty(firstShop, "12345");
            Console.WriteLine(buyAction5 + "\n");

            Console.WriteLine("---------------------------------------------------------------------------------------");

            Console.WriteLine("Property owner Properties:\n" + propertyOwner.GetProperties());

            Console.WriteLine("---------------------------------------------------------------------------------------");

            var rentAction1 = rentalService.RentProperty(customer, "1234", propertyOwner, apartment, DateTime.Now, DateTime.Now.AddMonths(1));
            Console.WriteLine(rentAction1+"\n");
            var rentAction2 = rentalService.RentProperty(customer, "1234", propertyOwner, firstShop, DateTime.Now, DateTime.Now.AddMonths(2));
            Console.WriteLine(rentAction2 + "\n");
            var rentAction3 = rentalService.RentProperty(customer, "1234", propertyOwner, apartment, DateTime.Now, DateTime.Now.AddMonths(3));
            Console.WriteLine(rentAction3 + "\n");
            var rentAction4 = rentalService.RentProperty(customer, "1234", propertyOwner, house, DateTime.Now, DateTime.Now.AddMonths(4));
            Console.WriteLine(rentAction4 + "\n");
            var rentAction5 = rentalService.RentProperty(customer, "12345", propertyOwner, secondShop, DateTime.Now, DateTime.Now.AddMonths(5));
            Console.WriteLine(rentAction5 + "\n");

            Console.WriteLine("---------------------------------------------------------------------------------------");

            Console.WriteLine("Customer Contracts:\n" + customer.GetContracts());
            Console.WriteLine("Property Owner Contracts:\n" +  propertyOwner.GetContracts());
            Console.WriteLine("Rental Service Contracts:\n" +rentalService.GetContracts());

            Console.WriteLine("---------------------------------------------------------------------------------------");

            Console.WriteLine("Customer balance after renting: " + customer.GetCard().GetBalance() + "$");
            Console.WriteLine("Property owner balance after renting: " + propertyOwner.GetCard().GetBalance() + "$");
            
            Console.WriteLine("---------------------------------------------------------------------------------------");

        }
    }
}