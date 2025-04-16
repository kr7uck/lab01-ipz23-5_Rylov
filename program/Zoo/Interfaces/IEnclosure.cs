public interface IEnclosure
{
    string Name { get; }
    List<IAnimal> Animals { get; }
    void AddAnimal(IAnimal animal);
}