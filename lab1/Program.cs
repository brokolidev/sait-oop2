namespace lab1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Shape shape1 = new Shape();
        Rectangle rectangle1 = new Rectangle(20, 10);

        Console.WriteLine(rectangle1.Area());
        
        rectangle1.ShapeDetails();
    }
}