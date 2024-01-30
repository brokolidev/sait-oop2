namespace lab3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the name of the new dog.");
        string dogName = Console.ReadLine();

        Dog newDog = new Dog();
        newDog.SetName(dogName);
        newDog.SetColour("Brown");
        newDog.SetAge(5);

        Console.WriteLine($"The new dog! Name: {newDog.Name} / Age: {newDog.Age} / Colour: {newDog.Colour}");
        newDog.Eat();
        
        Console.WriteLine("Please enter the name of the new cat.");
        string catName = Console.ReadLine();
        
        Cat newCat = new Cat();
        newCat.SetName(catName);
        newCat.SetColour("Red");
        newCat.SetAge(7);

        Console.WriteLine($"The new cat! Name: {newCat.Name} / Age: {newCat.Age} / Colour: {newCat.Colour}");
        newCat.Eat();
    }
}