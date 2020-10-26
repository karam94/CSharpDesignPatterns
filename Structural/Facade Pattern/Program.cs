using System;
using Facade_Pattern.BigBallOfMud;
using Facade_Pattern.WorkerClasses;

namespace Facade_Pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Old, ugly, big ball of mud class.
            var bigBallOfMud = new BigBallOfMud.BigBallOfMud();
            bigBallOfMud.SetValue(100);
            bigBallOfMud.Increment();
            bigBallOfMud.Increment();
            bigBallOfMud.Increment();
            bigBallOfMud.Increment();
            bigBallOfMud.Increment();
            Console.WriteLine(bigBallOfMud.GetValue());

            // Facade gives us a more readable API to use on the top.
            var bigBallOfMudFacade = new BigBallOfMudFacade(100);
            var incrementedValue = bigBallOfMudFacade.IncrementValue(5);
            Console.WriteLine(incrementedValue);


            // Old, ugly, multiple worker classes.
            Console.WriteLine(new ServiceClassA().SayA + new ServiceClassB().SayB + new ServiceClassC().SayC + new ServiceClassD().SayD);

            // Facade gives us a more readable API with only one call necessary.
            Console.WriteLine(new Facade().PrintAbcd());
        }
    }
}
