using System;

namespace Simple_Factory_Pattern.Models
{
    public class VehicleOrder
    {
        private readonly Guid _id;
        private readonly Brand _brand;

        public VehicleOrder(Brand brand)
        {
            _id = Guid.NewGuid();
            _brand = brand;
        }

        public Guid GetId() => _id;
        public Brand GetBrand() => _brand;
    }
}