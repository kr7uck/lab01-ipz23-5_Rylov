public class ZooInventory
{
    public List<IAnimal> Animals = new();
    public List<IEmployee> Employees = new();
    public List<IEnclosure> Enclosures = new();

    public void ShowInventory()
    {
        Console.WriteLine("--- Zoo Inventory ---");
        Console.WriteLine("Animals:");
        foreach (var a in Animals)
            Console.WriteLine($"- {a.Name} the {a.Species}");

        Console.WriteLine("\nEmployees:");
        foreach (var e in Employees)
            Console.WriteLine($"- {e.Name}");

        Console.WriteLine("\nEnclosures:");
        foreach (var en in Enclosures)
            Console.WriteLine($"- {en.Name} with {en.Animals.Count} animals");
    }
}