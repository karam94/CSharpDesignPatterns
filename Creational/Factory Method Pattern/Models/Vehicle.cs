namespace Factory_Method_Pattern.Models
{
    public class Vehicle
    {
        private readonly Brand _brand;

        public Vehicle(Brand brand)
        {
            _brand = brand;
        }

        public Brand GetBrand() => _brand;
    }
}