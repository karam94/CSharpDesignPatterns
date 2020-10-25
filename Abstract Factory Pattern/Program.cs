using System;
using Abstract_Factory_Pattern.Factories;

namespace Abstract_Factory_Pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var shoppingCart = new ShoppingCart(new NokiaFactory());
            // A Nokia Smart Phone
            Console.WriteLine(shoppingCart.Checkout(true));
            // A Nokia Normal Phone
            Console.WriteLine(shoppingCart.Checkout(false));

            shoppingCart = new ShoppingCart(new SamsungFactory());
            // A Samsung Smart Phone
            Console.WriteLine(shoppingCart.Checkout(true));
            // A Samsung Normal Phone
            Console.WriteLine(shoppingCart.Checkout(false));
        }
    }
}
