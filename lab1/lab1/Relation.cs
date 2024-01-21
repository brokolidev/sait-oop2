namespace lab1;

public class Relation
{
    public enum RelationshipType
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