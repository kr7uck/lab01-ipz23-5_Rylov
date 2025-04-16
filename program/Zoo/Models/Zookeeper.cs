public class Zookeeper : Employee
{
    public Zookeeper(string name) : base(name) { }

    public override void PerformDuties()
    {
        Console.WriteLine($"Zookeeper {Name} is feeding the animals.");
    }
}