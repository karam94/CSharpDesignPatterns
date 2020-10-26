namespace Facade_Pattern.BigBallOfMud
{
    public class BigBallOfMud
    {
        private int _count = 0;

        public void Increment() => _count++;

        public int GetValue() => _count;

        public void SetValue(int value) => _count = value;

        public void IncrementBackDownToZero()
        {
            _count = 0;
        }
    }
}
