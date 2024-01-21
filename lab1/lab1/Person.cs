namespace lab1;

public class Person
{
    private int personId { get; set; }
    public string firstName { get; set; }
    private string lastName { get; set; }
    private string favoriteColour { get; set; }
    private int age { get; set; }
    private bool isWorking { get; set; }

    protected string DisplayPersonInfo(
        int personId, string firstName, string lastName, 
        string favoriteColour, int age, bool isWorking)
    {
        return $"{personId}: {firstName} {lastName}'s favorite color is {favoriteColour}";
    }

    protected void ChangeFavoriteColour()
    {
        this.favoriteColour = "White";
    }

    protected int GetAgeInTenYears()
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