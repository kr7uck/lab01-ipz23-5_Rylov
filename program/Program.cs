class Program
{
    static void Main()
    {
        var lion = new Lion("Simba");
        var elephant = new Elephant("Dumbo");
        var meat = new Meat("Beef");
        var grass = new Grass("Hay");

        lion.Eat(meat);
        elephant.Eat(grass);
        lion.MakeSound();
        elephant.MakeSound();

        var bigCage = new LargeEnclosure("Savannah");
        bigCage.AddAnimal(lion);
        bigCage.AddAnimal(elephant);

        var keeper = new Zookeeper("Alex");
        var vet = new Veterinarian("Dr. Smith");

        keeper.PerformDuties();
        vet.PerformDuties();

        var zoo = new ZooInventory();
        zoo.Animals.AddRange(new IAnimal[] { lion, elephant });
        zoo.Employees.AddRange(new IEmployee[] { keeper, vet });
        zoo.Enclosures.Add(bigCage);

        zoo.ShowInventory();
    }
}
