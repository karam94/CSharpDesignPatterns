using System;
using static System.String;

namespace Prototype_Pattern
{
    public class Developer : ICloneable
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private string Role { get; }
        private string[] Languages { get; }
        private DevelopmentTeam Team { get; set; }

        public Developer(string name, int age, string role, string[] languages, DevelopmentTeam team)
        {
            Name = name;
            Age = age;
            Role = role;
            Languages = languages;
            Team = team;
        }

        // Shallow Copy
        // All value types are copied to the clone.
        // However reference types (except string) are copied as references.
        // This means changes made to reference types on the original, also affect the clone.
        public object Clone()
        {
            return MemberwiseClone();
        }

        // Deep Copy
        // All value types are copied to the clone.
        // All reference types have brand new matching instances created on the clone.
        public object DeepClone()
        {
            var clonedDeveloper = (Developer)MemberwiseClone();
            clonedDeveloper.SetTeam(new DevelopmentTeam(Team.GetName()));
            return clonedDeveloper;
        }

        public void SetName(string newName) => Name = newName;
        public void SetAge(int newAge) => Age = newAge;
        public void SetTeam(DevelopmentTeam newTeam) => Team = newTeam;
        public override string ToString() => $"{Name}, {Age}.\n{Role}.\n{Join(", ", Languages)}.\n{Team.ToString()}";
    }
}
