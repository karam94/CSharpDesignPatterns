using System.Collections.Generic;

namespace Builder_Pattern
{
    public class Car
    {
        private Brand _brand;
        private string _model;
        private int _numberOfDoors;
        private Colour _colour;
        private readonly List<Upgrade> _upgrades = new List<Upgrade>();

        public void SetBrand(Brand make)
        {
            _brand = make;
        }

        public void SetModel(string model)
        {
            _model = model;
        }

        public void SetNumberOfDoors(int numberOfDoors)
        {
            _numberOfDoors = numberOfDoors;
        }

        public void SetColour(Colour colour)
        {
            _colour = colour;
        }

        public void AddUpgrade(Upgrade upgrade)
        {
            _upgrades.Add(upgrade);
        }

        public override string ToString() => $"A{(_upgrades.Count > 0 ? $" custom" : "")} {_colour} {_brand} {_model} with {_numberOfDoors} doors with {_upgrades.Count} added upgrades.";
    }
}
