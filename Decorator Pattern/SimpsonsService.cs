using System.Collections.Generic;
using System.Linq;

namespace Decorator_Pattern
{
    public class SimpsonsService : ISimpsonsService
    {
        private readonly List<Person> _simpsons;

        public SimpsonsService()
        {
            _simpsons = new List<Person>
            {
                new Person("Homer", 39),
                new Person("Marge", 36),
                new Person("Bart", 10)
            };
        }
        public Person GetSimpson(string name)
        {
            return _simpsons.FirstOrDefault(p => p.GetName() == name);
        }

        public IEnumerable<Person> GetSimpsons(string[] names)
        {
            return _simpsons.Where(p => names.Contains(p.GetName()));
        }
    }
}
