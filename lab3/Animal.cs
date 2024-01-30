namespace lab3;

public abstract class Animal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }

    protected Animal()
    {
    }

    public void SetName(string name)
    {
        this.Name = name;
    }

    public void SetColour(string colour)
    {
        this.Colour = colour;
    }

    public void SetAge(int age)
    {
        this.Age = age;
    }

    public abstract void Eat();
}