using Abstract_Factory_Pattern.Models;

namespace Abstract_Factory_Pattern.Factories
{
    public class SamsungFactory : MobilePhoneFactory
    {
        public override ISmartPhone GetSmartPhone() => new SamsungGalaxy();
        public override IStandardPhone GetStandardPhone() => new SamsungGuru();
    }
}
