public class Elephant : Animal
{
    public override string Species => "Elephant";

    public Elephant(string name) : base(name) { }

    public override void Eat(IFood food)
    {
        if (food.Type == "Grass")
            Console.WriteLine($"{Name} the Elephant eats {food.Name}.");
        else
            Console.WriteLine($"{Name} refuses to eat {food.Name}.");
    }

    public override void MakeSound() => Console.WriteLine("Trumpet!");
}