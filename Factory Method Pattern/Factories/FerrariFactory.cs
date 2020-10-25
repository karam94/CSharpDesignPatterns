using Factory_Method_Pattern.Models;

namespace Factory_Method_Pattern.Factories
{
    public class FerrariFactory : VehicleFactory
    {
        public override Vehicle BuildVehicle() => new Vehicle(Brand.Ferrari);
    }
}
