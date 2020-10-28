using System.Collections.Generic;

namespace Decorator_Pattern
{
    public interface ISimpsonsService
    {
        Person GetSimpson(string name);
        IEnumerable<Person> GetSimpsons(string[] names);
    }
}