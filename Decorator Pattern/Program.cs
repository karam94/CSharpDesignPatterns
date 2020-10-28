using System;

namespace Decorator_Pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var simpsonsService = new SimpsonsService();
            Console.WriteLine(simpsonsService.GetSimpson("Homer").ToString());
            Console.WriteLine(string.Join(" ", simpsonsService.GetSimpsons(new[]{ "Homer", "Bart" })));
            Console.WriteLine("\n");

            var loggedSimpsonsService = new SimpsonsServiceLoggingDecorator(simpsonsService);
            Console.WriteLine(loggedSimpsonsService.GetSimpson("Homer").ToString());
            Console.WriteLine(string.Join(" ", loggedSimpsonsService.GetSimpsons(new[] { "Homer", "Bart" })));
        }
    }
}
