using System;
using System.Collections.Generic;

namespace Decorator_Pattern
{
    public class SimpsonsServiceLoggingDecorator : ISimpsonsService
    {
        private readonly ISimpsonsService _simpsonsService;

        public SimpsonsServiceLoggingDecorator(ISimpsonsService simpsonsService)
        {
            _simpsonsService = simpsonsService;
        }

        public Person GetSimpson(string name)
        {
            Console.WriteLine($"LOGGER: {DateTime.Now}: Executing GetSimpson({name}).");
            var toReturn = _simpsonsService.GetSimpson(name);
            Console.WriteLine($"LOGGER: {DateTime.Now}: Finished executing GetSimpson({name}).");
            return toReturn;
        }

        public IEnumerable<Person> GetSimpsons(string[] names)
        {
            Console.WriteLine($"LOGGER: {DateTime.Now}: Executing GetSimpsons({string.Join(", ", names)}).");
            var toReturn = _simpsonsService.GetSimpsons(names);
            Console.WriteLine($"LOGGER: {DateTime.Now}: Finished executing GetSimpsons({string.Join(", ", names)}).");
            return toReturn;
        }
    }
}
