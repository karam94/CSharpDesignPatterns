using System;
using Factory_Method_Pattern.Factories;
using Factory_Method_Pattern.Models;

namespace Factory_Method_Pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // A Honda is ordered
            var hondaShoppingCart = new ShoppingCart(new VehicleOrder(Brand.Honda), new HondaFactory());
            var hondaOrderResponse = hondaShoppingCart.Checkout();
            Console.WriteLine(hondaOrderResponse + "\n");

            // A Ferrari is ordered
            var ferrariShoppingCart = new ShoppingCart(new VehicleOrder(Brand.Ferrari), new FerrariFactory());
            var ferrariOrderResponse = ferrariShoppingCart.Checkout();
            Console.WriteLine(ferrariOrderResponse + "\n");
        }
    }
}
