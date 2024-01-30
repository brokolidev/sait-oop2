namespace lab2;

public class Wages : Employee
{
    private double rate;
    private double hours;

    public Wages()
    {
    }

    public Wages(string id, string name, string address, string phone, long sin, 
        string dob, string dept, double rate, double hours) : base(id, name, address, phone, sin, dob, dept)
    {
        this.rate = rate;
        this.hours = hours;
    }

    public double Rate
    {
        get => rate;
        set => rate = value;
    }

    public double Hours
    {
        get => hours;
        set => hours = value;
    }

    public double GetPay()
    {
        return 0.0;
    }

    public override string ToString()
    {
        return $"This is wages";
    }
}