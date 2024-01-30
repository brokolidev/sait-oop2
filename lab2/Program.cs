using System.Resources;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace lab2;

class Program
{
    static void Main(string[] args)
    {

        String line = "start";
        List<Employee> employeesList = [];
        List<Wages> wagesList = [];
        List<Salaried> salariedList = [];
        List<PartTime> partTimesList = [];
        int i = 0;
        
        foreach (string data in File.ReadLines("/Users/brokoli/Dev/sait/oop2/labs/lab2/res/employees.txt"))
        {
            i++;
            string[] parts = data.Split(":");
            
            string startLetter = parts[0][0].ToString().Trim();
            int startNumber = Int32.Parse(startLetter);
            
            string id = parts[0];
            string name = parts[1];
            string address = parts[2];
            string phone = parts[3];
            long sin = long.Parse(parts[4]);
            string dob = parts[5];
            string dept = parts[6];
            
            if (startNumber is > 0 and <= 4  )
            {
                double salary = double.Parse(parts[7]);
                Salaried newEmp = new Salaried(id, name, address, phone, sin, dob, dept, salary);
                salariedList.Add(newEmp);
                employeesList.Add(newEmp);
            } else if (startNumber is >= 5 and <= 7)
            {
                double rate = double.Parse(parts[7]);
                double hours = double.Parse(parts[8]);
                Wages newEmp = new Wages(id, name, address, phone, sin, dob, dept, rate, hours);
                wagesList.Add(newEmp);
                employeesList.Add(newEmp);
            } else if (startNumber is 8 or 9)
            {
                double rate = double.Parse(parts[7]);
                double hours = double.Parse(parts[8]);
                PartTime newEmp = new PartTime(id, name, address, phone, sin, dob, dept, rate, hours);
                partTimesList.Add(newEmp);
                employeesList.Add(newEmp);
            }
        }

        double totalPayment = 0.0;
        Wages highestWageEmployee = new Wages();
        Salaried lowestSalariedEmp = new Salaried();
        
        foreach (var employee in wagesList)
        {
            totalPayment += employee.GetPay();

            if (highestWageEmployee.GetPay() < employee.GetPay())
            {
                highestWageEmployee = employee;
            }
            
        }
        
        foreach (var employee in salariedList)
        {
            totalPayment += employee.GetPay();
            if (lowestSalariedEmp.GetPay() == 0 || lowestSalariedEmp.GetPay() > employee.GetPay())
            {
                lowestSalariedEmp = employee;
            }
        }
        
        foreach (var employee in partTimesList)
        {
            totalPayment += employee.GetPay();
        }

        Console.WriteLine($"Average weekly pay for employees : {totalPayment / employeesList.Count}\n");

        Console.WriteLine($"The highest weelky pay for the wage employees : \n" +
                          $"{highestWageEmployee}\n");

        Console.WriteLine($"The lowest salary for the salaried employees : \n" +
                          $"{lowestSalariedEmp}\n");
        
        double percentageOfWage = (double)wagesList.Count / employeesList.Count;
        Console.WriteLine($"Percentage of wage employee : {percentageOfWage * 100}%");
        
        double percentageOfPartTimer = (double)partTimesList.Count / employeesList.Count;
        Console.WriteLine($"Percentage of wage employee : {percentageOfPartTimer * 100}%");
        
        double percentageOfSalaried = (double)salariedList.Count / employeesList.Count;
        Console.WriteLine($"Percentage of wage employee : {percentageOfSalaried * 100}%");

    }
}