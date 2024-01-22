namespace lab1;

class Program
{
    static void Main(string[] args)
    {
        Person Ian = new Person(
            1, "Ian", 
            "Brooks", "Red", 
            30, true);
        
        Person Gina = new Person(
            2, "Gina", 
            "James", "Green", 
            18, false);
        
        Person Mike = new Person(
            3, "Mike", 
            "Briscoe", "Blue", 
            45, true);
        
        Person Mary = new Person(
            4, "Mary", 
            "Beals", "Yelow", 
            28, true);

        Gina.DisplayPersonInfo();
        Console.WriteLine(Mike);
        Ian.ChangeFavoriteColour();
        Ian.DisplayPersonInfo();
        Console.WriteLine($"{Mary.firstName} {Mary.lastName}'s " +
                          $"Age in 10 years is: {Mary.GetAgeInTenYears()}");

        Relation SisterRelationShip = new Relation(Relation.Relationships.Sister);
        Relation BrotherRelationShip = new Relation(Relation.Relationships.Brother);

        SisterRelationShip.ShowRelationShip(Gina, Mary);
        BrotherRelationShip.ShowRelationShip(Ian, Mike);
        
        List<Person> AllPeople = [Ian, Gina, Mike, Mary];

        double AvgOfPeople = AllPeople.Average(person => person.age);
        Console.WriteLine($"Average age is: {AvgOfPeople}");

        Person TheYoungest = AllPeople.MinBy(person => person.age);
        Console.WriteLine($"The youngest person is: {TheYoungest.firstName}");
        
        Person TheOldest = AllPeople.MaxBy(person => person.age);
        Console.WriteLine($"The oldest person is: {TheOldest.firstName}");

        foreach (var personStartWithM in AllPeople.FindAll(person => person.firstName.StartsWith("M")))
        {
            Console.WriteLine(personStartWithM);
        }
        
        foreach (var personLikesBlue in AllPeople.FindAll(person => person.favoriteColour == "Blue"))
        {
            Console.WriteLine(personLikesBlue);
        }
    }
}
