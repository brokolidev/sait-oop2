namespace lab1;

public class Rectangle : Shape
{
    public Rectangle()
    {
        Console.WriteLine("Creating a default Rectangle Object");
    }

    public Rectangle(int w, int h) : base(w, h)
    {
    }

    public string Area()
    {
        return $"The Area of the Shape is: {this.Width * this.Height}";
    }
    
    public void ShapeDetails()
    {
        Console.WriteLine($"This is a Rectangle detail");
    }
}