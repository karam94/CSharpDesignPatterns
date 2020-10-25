using System;
using Simple_Factory_Pattern.Models;

namespace Simple_Factory_Pattern
{
    public class VehicleFactory
    {
        public static Vehicle BuildVehicle(Brand brand)
        {
            return brand switch
            {
                Brand.Honda => new Vehicle(Brand.Honda),
                Brand.Ferrari => new Vehicle(Brand.Ferrari),
                Brand.Yamaha => new Vehicle(Brand.Yamaha),
                _ => throw new NotSupportedException("The factory unfortunately cannot construct " +
                                                     $"vehicles of the brand {brand} at the current time.")
            };
        }
    }
}
