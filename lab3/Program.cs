namespace lab3;

class Program
{
    static void Main(string[] args)
    {
        // Part1 for Dog
        Console.WriteLine("\nPlease enter the name of the new dog.");
        string dogName = Console.ReadLine();

        Dog newDog = new Dog();
        newDog.SetName(dogName);
        newDog.SetColour("Brown");
        newDog.SetAge(5);

        Console.WriteLine($"The new dog! Name: {newDog.Name} / Age: {newDog.Age} / Colour: {newDog.Colour}");
        newDog.Eat();
        
        // Part1 for Cat
        Console.WriteLine("\nPlease enter the name of the new cat.");
        string catName = Console.ReadLine();
        
        Cat newCat = new Cat();
        newCat.SetName(catName);
        newCat.SetColour("Red");
        newCat.SetAge(7);

        Console.WriteLine($"The new cat! Name: {newCat.Name} / Age: {newCat.Age} / Colour: {newCat.Colour}");
        newCat.Eat();
        
        // Tests for part2, Dog
        Dog newDog2 = new Dog();
        
        Console.WriteLine("\nPlease enter the name of the new dog: ");
        string dogName2 = Console.ReadLine();
        newDog2.SetName(dogName2);
        
        Console.WriteLine("Please enter the colour of the new dog: ");
        string dogColour = Console.ReadLine();
        newDog2.SetColour(dogColour);
        
        Console.WriteLine("Please enter the age of the new dog: ");
        string dogAge = Console.ReadLine();
        newDog2.SetAge(Int32.Parse(dogAge));
        
        Console.WriteLine("Please enter the height of the new dog: ");
        string dogHeight = Console.ReadLine();
        newDog2.SetHeight(double.Parse(dogHeight));

        Console.WriteLine($"The new dog! Name: {newDog2.Name} / Age: {newDog2.Age} / Colour: {newDog2.Colour} / Height: {newDog2.Height}");
        newDog2.Eat();
        Console.WriteLine(newDog2.Cry());
        
        // Tests for part2, Cat
        Cat newCat2 = new Cat();
        
        Console.WriteLine("\nPlease enter the name of the new cat: ");
        string catName2 = Console.ReadLine();
        newCat2.SetName(catName2);
        
        Console.WriteLine("Please enter the colour of the new cat: ");
        string catColour = Console.ReadLine();
        newCat2.SetColour(catColour);
        
        Console.WriteLine("Please enter the age of the new cat: ");
        string catAge = Console.ReadLine();
        newCat2.SetAge(Int32.Parse(catAge));
        
        Console.WriteLine("Please enter the height of the new cat: ");
        string catHeight = Console.ReadLine();
        newCat2.SetHeight(double.Parse(catHeight));

        Console.WriteLine($"The new dog! Name: {newCat2.Name} / Age: {newCat2.Age} / Colour: {newCat2.Colour} / Height: {newCat2.Height}");
        newCat2.Eat();
        Console.WriteLine(newCat2.Cry());

        List<Animal> animals = [];
        
        animals.Add(new Cat("Happy"));
        animals.Add(new Cat("Sad"));
        animals.Add(new Cat("Blue"));
        animals.Add(new Cat("Red"));
        animals.Add(new Cat("White"));
        animals.Add(new Dog("Python"));
        animals.Add(new Dog("C++"));
        animals.Add(new Dog("C#"));
        animals.Add(new Dog("PHP"));
        animals.Add(new Dog("JavaScript"));
        animals.Add(new Dog("Flutter"));

        Console.WriteLine("\nThis is the name of all animals");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Name);
        }
    }
}