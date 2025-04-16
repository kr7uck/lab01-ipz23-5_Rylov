public abstract class Animal : IAnimal
{
    public string Name { get; protected set; }
    public abstract string Species { get; }

    public Animal(string name)
    {
        Name = name;
    }

    public abstract void Eat(IFood food);
    public abstract void MakeSound();
}