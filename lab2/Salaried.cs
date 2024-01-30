namespace lab2;

public class Salaried : Employee
{
    private double salary;

    public double Salary
    {
        get => salary;
        set => salary = value;
    }

    public Salaried()
    {
    }

    public Salaried(string id, string name, string address, string phone, 
        long sin, string dob, string dept, double salary) : base(id, name, address, phone, sin, dob, dept)
    {
        this.salary = salary;
    }

    public double GetPay()
    {
        return 0.0;
    }

    public override string ToString()
    {
        return $"This is Salaried";
    }
}