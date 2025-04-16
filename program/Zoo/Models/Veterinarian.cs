public class Veterinarian : Employee
{
    public Veterinarian(string name) : base(name) { }

    public override void PerformDuties()
    {
        Console.WriteLine($"Veterinarian {Name} is checking the animals.");
    }
}