namespace lab0;

class Program
{
    static void Main(string[] args)
    {
        // Task1
        Console.WriteLine("Please enter a low number");
        int newLow = GetLowNumber();
        Console.WriteLine("Now please enter higher than " + newLow);
        int newHigh = GetHighNumber(newLow);
        int diff = newHigh - newLow;
        Console.WriteLine($"The difference is {diff}");

        // Task3
        List<double> betweenNumbers = new List<double>();
        string filePath = "/Users/brokoli/Dev/sait/oop2/lab0/lab0/numbers.txt";

        using (StreamWriter sw = new StreamWriter(filePath))
        {
            for (int i = newHigh - 1; i > newLow; i--)
            {
                betweenNumbers.Add(i);
                sw.WriteLine(i);
            }
        }

        // Additional Task
        StreamReader sr = new StreamReader(filePath);
        int sumOfBetweenNumbers = 0;
        string line = sr.ReadLine();
        while (line != null)
        {
            sumOfBetweenNumbers += int.Parse(line);
            line = sr.ReadLine();
        }
        sr.Close();

        Console.WriteLine($"The sum of all between numbers is {sumOfBetweenNumbers}");

        // Get only prime numbers from between numbers
        foreach (var num in betweenNumbers)
        {
            if (IsPrimeNumber(num))
            {
                Console.WriteLine(num);
            }
        }
        
        // I guess this is more efficient especially when the newHigh gets bigger.
        /*
        List<double> primeNumbers = GetPrimeNumbers(newHigh);
        List<double> common = betweenNumbers.Intersect(primeNumbers).ToList();
        Console.WriteLine($"The prime numbers between {newLow} and {newHigh} >>");
        foreach (var primeNumber in common)
        {
            Console.WriteLine(primeNumber);
        }
        */
    }

    // Additional Task
    // The method that determine if the number is prime number or not.
    public static bool IsPrimeNumber(double num)
    {
        double[] primaryBase = { 2, 3, 5, 7 };
        
        if (primaryBase.Contains(num))
        {
            return true;
        }

        for (int i = 0; i < primaryBase.Length; i++)
        {
            if (num % primaryBase[i] == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static List<double> GetPrimeNumbers(int maxNum)
    {
        // Getting every prime number lower than newHigh
        bool[] isPrimeArray = Enumerable.Repeat(true, maxNum + 1).ToArray();
        int[] primaryBase = { 2, 3, 5, 7 }; 
        isPrimeArray[0] = isPrimeArray[1] = false;
        
        for (int i = 2; i * i <= maxNum; i++)
        {
            if (primaryBase.Contains(i))
            {
                // Console.WriteLine($"{i} is a prime number");
                isPrimeArray[i] = true;
            }
            
            if (isPrimeArray[i])
            {
                for (int j = i * i; j <= maxNum; j+=i)
                {
                    // Console.WriteLine($"{j} is not a prime number");
                    isPrimeArray[j] = false;
                }                
            }
        }

        List<double> primeNumbers = new List<double>();

        // print all the prime number
        for (int i = 0; i < isPrimeArray.Length; i++)
        {
            if (isPrimeArray[i])
            {
                primeNumbers.Add(i);
            }
        }

        return primeNumbers;
    }

    public static int GetLowNumber()
    {
        int newLow;
        
        // Task2
        while (true)
        {
            String userInput = Console.ReadLine();
            bool t = int.TryParse(userInput, out newLow);

            if (t && newLow > 0)
            {
                return newLow;
            }
            else
            {
                Console.WriteLine("Invalid input, please re-enter a low +ve number");
            }            
        }
    }
    
    public static int GetHighNumber(int lowNum)
    {
        int newHigh;
        
        // Task2
        while (true)
        {
            String userInput = Console.ReadLine();
            bool t = int.TryParse(userInput, out newHigh);

            if (t && newHigh > lowNum)
            {
                return newHigh;
            }
            else
            {
                Console.WriteLine($"Invalid input, please re-enter a higher than {lowNum}");
            }            
        }
    }
}

