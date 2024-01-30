namespace lab3;

public class Dog: Animal, IAnimal
{
    public Dog()
    {
    }
    
    public Dog(string name)
    {
        this.Name = name;
    }

    public override void Eat()
    {
        Console.WriteLine($"Dogs eat meat.");
    }

    public string Cry()
    {
        return "Woof!";
    }

    public double Height { get; set; }

    public void SetHeight(double height)
    {
        this.Height = height;
    }
}