namespace lab2;

public class Employee
{
    private string id;
    private string name;
    private string address;
    private string phone;
    private long sin;
    private string dob;
    private string dept;

    public Employee()
    {
    }

    public Employee(string id, string name, string address, string phone, long sin, string dob, string dept)
    {
        this.id = id;
        this.name = name;
        this.address = address;
        this.phone = phone;
        this.sin = sin;
        this.dob = dob;
        this.dept = dept;
    }

    public string Id
    {
        get => id;
        set => id = value;
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public string Address
    {
        get => address;
        set => address = value;
    }

    public string Phone
    {
        get => phone;
        set => phone = value;
    }

    public long Sin
    {
        get => sin;
        set => sin = value;
    }

    public string Dob
    {
        get => dob;
        set => dob = value;
    }

    public string Dept
    {
        get => dept;
        set => dept = value;
    }

    public override string ToString()
    {
        return $"This is an general employee. \n" +
               $"ID: {id} / Name: {name} / Address: {address} \n" +
               $"Phone: {Phone} / Sin: {sin} / Dob: {dob} / " +
               $"Department: {dept} \n";
    }
}