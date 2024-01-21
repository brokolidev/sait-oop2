namespace lab1;

public class Relation
{
    protected Relationships RelationshipType { get; set; }

    public enum Relationships
    {
        Sister,
        Brother,
        Mother,
        Father
    }

    public string ShowRelationShip(Person person1, Person person2)
    {
        return $"Relationship between {person1.firstName} and {person2.firstName} is : ";
    }
}