namespace Facade_Pattern.BigBallOfMud
{
    public class BigBallOfMudFacade
    {
        private readonly Facade_Pattern.BigBallOfMud.BigBallOfMud _bigBallOfMud;

        public BigBallOfMudFacade(int startingValue)
        {
            _bigBallOfMud = new Facade_Pattern.BigBallOfMud.BigBallOfMud();
            _bigBallOfMud.SetValue(startingValue);
        }

        public int IncrementValue(int numberToAdd)
        {
            for (var i = 0; i < numberToAdd; i++)
            {
                _bigBallOfMud.Increment();
            }

            return _bigBallOfMud.GetValue();
        }
    }
}
