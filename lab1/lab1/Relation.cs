namespace lab1;

public class Relation
{
    public Relationships RelationshipType { get; set; }

    public enum Relationships
    {
        Sister,
        Brother,
        Mother,
        Father
    }

    public Relation(Relationships relationship)
    {
        this.RelationshipType = relationship;
    }

    public void ShowRelationShip(Person person1, Person person2)
    {
        Console.WriteLine($"Relationship between " +
                          $"{person1.firstName} and " +
                          $"{person2.firstName} is: " +
                          $"{this.RelationshipType}");
        
    }
}