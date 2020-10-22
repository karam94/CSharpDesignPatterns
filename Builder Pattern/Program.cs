using System;
using System.Collections.Generic;

namespace Builder_Pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var upgradeInventory = new List<Upgrade>();
            upgradeInventory.Add(Upgrade.BiggerWheels);
            upgradeInventory.Add(Upgrade.NitroBoost);
            upgradeInventory.Add(Upgrade.HeatedSeats);

            var carBuilder = new CarBuilder(upgradeInventory);
            var director = new CarBuilderDirector(carBuilder);

            Console.WriteLine("Karam's Car:");
            Console.WriteLine(director.BuildSilverHondaCivic().ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Mum's Car:");
            Console.WriteLine(director.BuildRedToyotaYaris().ToString());
            Console.WriteLine("\n");

            Console.WriteLine("A Custom Car:");
            var customCar = carBuilder
                                .WithMake(Brand.Nissan)
                                .WithModel("Skyline")
                                .WithNumberOfDoors(4)
                                .WithColour(Colour.Black)
                                .Build();
            Console.WriteLine(customCar.ToString());
            Console.WriteLine("\n");

            // Note that since the Leather Seats upgrade is out of stock
            // our car is built with only TWO upgrades, rather than three.
            Console.WriteLine("A very expensive (and fast) Custom Car:");
            var expensiveCustomCar = carBuilder
                                .WithMake(Brand.Nissan)
                                .WithModel("Skyline")
                                .WithNumberOfDoors(4)
                                .WithColour(Colour.Black)
                                .WithUpgrade(Upgrade.LeatherSeats)
                                .WithUpgrade(Upgrade.BiggerWheels)
                                .WithUpgrade(Upgrade.NitroBoost)
                                .Build();
            Console.WriteLine(expensiveCustomCar.ToString());
            Console.WriteLine("\n");
        }
    }
}
