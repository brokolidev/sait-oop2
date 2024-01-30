namespace lab3;

public class Dog: Animal
{
    public Dog()
    {
    }

    public override void Eat()
    {
        Console.WriteLine($"Dogs eat meat.");
    }
}