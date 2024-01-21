namespace lab1;

public class Shape
{
    protected int Width { get; set; }
    protected int Height { get; set; }

    protected Shape()
    {
        Console.WriteLine("Creating a default Shape Object");
    }

    protected Shape(int w, int h)
    {
        this.Width = w;
        this.Height = h;
    }

    public void ShapeDetails()
    {
        Console.WriteLine($"This is a shape detail");
    }
}