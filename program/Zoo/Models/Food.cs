public abstract class Food : IFood
{
    public string Name { get; protected set; }
    public abstract string Type { get; }
}