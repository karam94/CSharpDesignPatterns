using Abstract_Factory_Pattern.Models;

namespace Abstract_Factory_Pattern.Factories
{
    public class NokiaFactory : MobilePhoneFactory
    {
        public override ISmartPhone GetSmartPhone() => new Nokia9();
        public override IStandardPhone GetStandardPhone() => new Nokia3310();
    }
}
