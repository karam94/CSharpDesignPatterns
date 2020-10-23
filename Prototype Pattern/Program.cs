using System;

namespace Prototype_Pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var teamDevAlot = new DevelopmentTeam("Team Dev-alot");
            var originalDeveloper = new Developer("Rob Brown", 30, "Software Developer", new[] { "C#", "JavaScript", "TypeScript" }, teamDevAlot);
            Console.WriteLine("----- ORIGINAL DEVELOPER -----");
            Console.WriteLine(originalDeveloper.ToString());

            var clonedDeveloper = (Developer)originalDeveloper.Clone();
            Console.WriteLine("----- CLONED DEVELOPER -----");
            Console.WriteLine(clonedDeveloper.ToString());

            Console.WriteLine("----- MODIFYING VALUE TYPES ON ORIGINAL, DOES NOT APPLY TO CLONE -----");
            originalDeveloper.SetName("Donald Trump");
            originalDeveloper.SetAge(74);
            Console.WriteLine("----- MODIFIED ORIGINAL DEVELOPER -----");
            Console.WriteLine(originalDeveloper.ToString());
            Console.WriteLine("----- CLONED DEVELOPER -----");
            Console.WriteLine(clonedDeveloper.ToString());

            Console.WriteLine("----- MODIFYING REFERENCE TYPE TEAM NAME ON ORIGINAL, DOES ALSO APPLY TO SOFT CLONE -----");
            teamDevAlot.SetName("Thunderbirds");
            Console.WriteLine("----- ORIGINAL DEVELOPER -----");
            Console.WriteLine(originalDeveloper.ToString());
            Console.WriteLine("----- SOFT CLONED DEVELOPER -----");
            Console.WriteLine(clonedDeveloper.ToString());

            var deepClonedDeveloper = (Developer)originalDeveloper.DeepClone();
            Console.WriteLine("----- MODIFYING TEAM NAME ON ORIGINAL, DOES NOT APPLY TO DEEP CLONE -----");
            teamDevAlot.SetName("Manchester United");
            Console.WriteLine("----- ORIGINAL DEVELOPER -----");
            Console.WriteLine(originalDeveloper.ToString());
            Console.WriteLine("----- DEEP CLONED DEVELOPER -----");
            Console.WriteLine(deepClonedDeveloper.ToString());
        }
    }
}
