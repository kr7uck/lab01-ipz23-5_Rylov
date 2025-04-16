public abstract class Employee : IEmployee
{
    public string Name { get; protected set; }

    public Employee(string name)
    {
        Name = name;
    }

    public abstract void PerformDuties();
}