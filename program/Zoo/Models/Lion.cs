public class Lion : Animal
{
    public override string Species => "Lion";

    public Lion(string name) : base(name) { }

    public override void Eat(IFood food)
    {
        if (food.Type == "Meat")
            Console.WriteLine($"{Name} the Lion eats {food.Name}.");
        else
            Console.WriteLine($"{Name} refuses to eat {food.Name}.");
    }

    public override void MakeSound() => Console.WriteLine("Roar!");
}