namespace Decorator_Pattern
{
    public class Person
    {
        private readonly string _name;
        private readonly int _age;

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string GetName() => _name;
        public int GetAge() => _age;
        public override string ToString() => $"{_name}, {_age}.";
    }
}