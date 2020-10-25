using System;
using Simple_Factory_Pattern.Models;

namespace Simple_Factory_Pattern
{
    public class ShoppingCart
    {
        private readonly VehicleOrder _vehicleOrder;

        public ShoppingCart(VehicleOrder vehicleOrder)
        {
            _vehicleOrder = vehicleOrder;
        }

        public string Checkout()
        {
            try
            {
                // By encapsulating all the logic to create a Vehicle within a VehicleFactory
                // We abstract it out of the ShoppingCart class and in to its own re-usable class.
                var carToBuild = VehicleFactory.BuildVehicle(_vehicleOrder.GetBrand());
                return $"Vehicle built of brand {carToBuild.GetBrand()} for Order ID: ${_vehicleOrder.GetId()}";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
