using Abstract_Factory_Pattern.Factories;

namespace Abstract_Factory_Pattern
{
    // Extendable as it handles any time of present or future Mobile Phone Factory.
    // e.g. Imagine we introduce an AppleFactory down the line. No need for code changes in here.
    public class ShoppingCart
    {
        private readonly MobilePhoneFactory _mobilePhoneFactory;

        public ShoppingCart(MobilePhoneFactory mobilePhoneFactory)
        {
            _mobilePhoneFactory = mobilePhoneFactory;
        }

        public string Checkout(bool isSmartPhone)
        {
            return isSmartPhone ?
                _mobilePhoneFactory.GetSmartPhone().GetModelDetails()
                : _mobilePhoneFactory.GetStandardPhone().GetModelDetails();
        }
    }
}
