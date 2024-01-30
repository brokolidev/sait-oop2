namespace lab3;

public class Cat: Animal, IAnimal
{
    public Cat()
    {
    }
    
    public Cat(string name)
    {
        this.Name = name;
    }

    public override void Eat()
    {
        Console.WriteLine("Cats eat mice.");
    }

    public string Cry()
    {
        return "Meow!";
    }

    public double Height { get; set; }
    
    public void SetHeight(double height)
    {
        this.Height = height;
    }
}