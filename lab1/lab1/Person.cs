namespace lab1;

public class Person
{
    protected int personId { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string favoriteColour { get; set; }
    public int age { get; set; }
    public bool isWorking { get; set; }

    public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
    {
        this.personId = personId;
        this.firstName = firstName;
        this.lastName = lastName;
        this.favoriteColour = favoriteColour;
        this.age = age;
        this.isWorking = isWorking;
    }

    public void DisplayPersonInfo()
    {
        Console.WriteLine($"{this.personId}: {this.firstName} " +
                          $"{this.lastName}'s favorite colour is " +
                          $"{this.favoriteColour}");
    }

    public void ChangeFavoriteColour()
    {
        this.favoriteColour = "White";
    }

    public int GetAgeInTenYears()
    {
        return this.age + 10;
    }

    public override string ToString()
    {
        return $"PersonId: {this.personId}\n"
            + $"FirstName: {this.firstName}\n"
            + $"LastName: {this.lastName}\n"
            + $"FavoriteColour: {this.favoriteColour}\n"
            + $"Age: {this.age}\n"
            + $"isWorking: {this.isWorking}";
    }
}