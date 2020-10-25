using System;
using Factory_Method_Pattern.Factories;
using Factory_Method_Pattern.Models;

namespace Factory_Method_Pattern
{
    public class ShoppingCart
    {
        private readonly VehicleOrder _vehicleOrder;
        private readonly VehicleFactory _vehicleFactory;

        public ShoppingCart(VehicleOrder vehicleOrder, VehicleFactory vehicleFactory)
        {
            _vehicleOrder = vehicleOrder;
            _vehicleFactory = vehicleFactory;
        }

        public string Checkout()
        {
            try
            {
                // The Shopping Cart is extensible to work with any type of current or future vehicle factory
                // since all current or future vehicle factories will extend the VehicleFactory abstract class.
                // Therefore the Shopping Cart can now handle any type of VehicleFactory, without needing to
                // change any of its implementation details.
                var carToBuild = _vehicleFactory.BuildVehicle();
                return $"Vehicle built of brand {carToBuild.GetBrand()} for Order ID: ${_vehicleOrder.GetId()}";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
