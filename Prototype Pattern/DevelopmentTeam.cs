namespace Prototype_Pattern
{
    public class DevelopmentTeam
    {
        private string Name { get; set; }

        public DevelopmentTeam(string name)
        {
            Name = name;
        }

        public string GetName() => Name;
        public void SetName(string newName) => Name = newName;
        public override string ToString() => $"{Name}.\n";
    }
}