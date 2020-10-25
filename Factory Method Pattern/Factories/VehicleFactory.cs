using Factory_Method_Pattern.Models;

namespace Factory_Method_Pattern.Factories
{
    public abstract class VehicleFactory
    {
        // This is the "Factory Method"
        public abstract Vehicle BuildVehicle();
    }
}
