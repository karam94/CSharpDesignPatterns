using Abstract_Factory_Pattern.Models;

namespace Abstract_Factory_Pattern.Factories
{
    // Factory Method Pattern -> METHOD (Hence why we use an abstract class with 1 overridable method)
    // Abstract Factory Pattern -> AN OBJECT (With multiple/a group of factory methods with a common theme that can be overridden)
    public abstract class MobilePhoneFactory
    {
        // Each factory will have multiple factory methods
        public abstract ISmartPhone GetSmartPhone();
        public abstract IStandardPhone GetStandardPhone();
    }
}
