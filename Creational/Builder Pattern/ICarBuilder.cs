namespace Builder_Pattern
{
    public interface ICarBuilder
    {
        void ResetBuilder();
        ICarBuilder WithMake(Brand brand);
        ICarBuilder WithModel(string model);
        ICarBuilder WithNumberOfDoors(int numberOfDoors);
        ICarBuilder WithColour(Colour colour);
        ICarBuilder WithUpgrade(Upgrade upgrade);
        Car Build();
    }
}