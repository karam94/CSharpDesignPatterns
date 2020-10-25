using Factory_Method_Pattern.Models;

namespace Factory_Method_Pattern.Factories
{
    // Factory Method Pattern -> METHOD (Hence why we use an abstract class with 1 overridable method)
    // Abstract Factory Pattern -> AN OBJECT (With multiple/a group of factory methods with a common theme that can be overridden)
    public abstract class VehicleFactory
    {
        // This is the "Factory Method"
        public abstract Vehicle BuildVehicle();
    }
}
