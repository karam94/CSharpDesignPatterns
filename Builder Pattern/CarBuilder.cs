using System.Collections.Generic;
using System.Linq;

namespace Builder_Pattern
{
    public class CarBuilder : ICarBuilder
    {
        private Car _car;
        private readonly IEnumerable<Upgrade> _upgradesInStock;

        public CarBuilder(IEnumerable<Upgrade> upgradesInStock)
        {
            ResetBuilder();
            _upgradesInStock = upgradesInStock;
        }

        public void ResetBuilder()
        {
            _car = new Car();
        }

        public ICarBuilder WithMake(Brand brand)
        {
            _car.SetBrand(brand);
            return this;
        }

        public ICarBuilder WithModel(string model)
        {
            _car.SetModel(model);
            return this;
        }

        public ICarBuilder WithNumberOfDoors(int numberOfDoors)
        {
            _car.SetNumberOfDoors(numberOfDoors);
            return this;
        }

        public ICarBuilder WithColour(Colour colour)
        {
            _car.SetColour(colour);
            return this;
        }

        // By using the Builder Pattern, we separate
        // the construction logic of the Car object
        // which is based on whether an upgrade is in stock
        // or not, from the internal representation of the Car.
        public ICarBuilder WithUpgrade(Upgrade upgrade)
        {
            if (!_upgradesInStock.Contains(upgrade)) return this;
            _car.AddUpgrade(upgrade);
            return this;
        }

        public Car Build()
        {
            var builtCar = _car;
            ResetBuilder();
            return builtCar;
        }
    }
}
