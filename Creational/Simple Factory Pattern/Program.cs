using System;
using Simple_Factory_Pattern.Models;

namespace Simple_Factory_Pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // A Honda is ordered
            var hondaShoppingCart = new ShoppingCart(new VehicleOrder(Brand.Honda));
            var hondaOrderResponse = hondaShoppingCart.Checkout();
            Console.WriteLine(hondaOrderResponse + "\n");

            // A Ferrari is ordered
            var ferrariShoppingCart = new ShoppingCart(new VehicleOrder(Brand.Ferrari));
            var ferrariOrderResponse = ferrariShoppingCart.Checkout();
            Console.WriteLine(ferrariOrderResponse + "\n");

            // A Lamborghini is ordered but cannot be built
            var lamborghiniShoppingCart = new ShoppingCart(new VehicleOrder(Brand.Lamborghini));
            var lamborghiniOrderResponse = lamborghiniShoppingCart.Checkout();
            Console.WriteLine(lamborghiniOrderResponse + "\n");
        }
    }
}
