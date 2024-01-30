namespace lab2;

public class PartTime : Employee
{
    private double rate;
    private double hours;

    public PartTime()
    {
    }

    public PartTime(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours) : base(id, name, address, phone, sin, dob, dept)
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
        return rate * hours;
    }

    public override string ToString()
    {
        return $"This is a part timer. \n" +
               $"ID: {base.Id} / Name: {base.Name} / Address: {base.Address} \n" +
               $"Phone: {base.Phone} / Sin: {base.Sin} / Dob: {base.Dob} / " +
               $"Department: {base.Dept} \n" +
               $"Rate: {rate} / Hours : {hours} \n";
    }
}