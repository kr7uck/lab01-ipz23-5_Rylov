public abstract class Enclosure : IEnclosure
{
    public string Name { get; protected set; }
    public List<IAnimal> Animals { get; private set; } = new List<IAnimal>();

    public Enclosure(string name)
    {
        Name = name;
    }

    public virtual void AddAnimal(IAnimal animal)
    {
        Animals.Add(animal);
    }
}