namespace Builder_Pattern
{
    public class CarBuilderDirector
    {
        private readonly ICarBuilder _carBuilder;

        public CarBuilderDirector(ICarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }

        public Car BuildSilverHondaCivic()
        {
            _carBuilder
                .WithMake(Brand.Honda)
                .WithModel("Civic")
                .WithNumberOfDoors(4)
                .WithColour(Colour.Silver);

            return _carBuilder.Build();
        }

        public Car BuildRedToyotaYaris()
        {
            _carBuilder
                .WithMake(Brand.Toyota)
                .WithModel("Yaris")
                .WithNumberOfDoors(2)
                .WithColour(Colour.Red);

            return _carBuilder.Build();
        }
    }
}
