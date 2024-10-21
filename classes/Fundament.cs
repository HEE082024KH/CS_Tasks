public class Fundament : IFundament
{
    public void CheckOddOrEven(double a)
    {
        if (a % 2 == 0)
        {
            Console.WriteLine("Number is even");
        }
        else
        {
            Console.WriteLine("Number is odd");
        }
    }

    public string GetAInterestingFact(string fact)
    {
        return fact;
    }

    public void SumTwoNumbers()
    {
        Console.WriteLine("Enter first number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Sum = {a + b}");
    }

    public double SumTwoNumbersOfGivenType(double a, double b)
    {
        // EKSTRA CODE:
        // Console.WriteLine("Enter first number");
        // double c = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter second number");
        // double d = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($"Sum = {c + d}");

        // Actual solution
        return a + b;
    }


    // Extra challenges

    public void PrintFibonnaciSeries(int n)
    {
        int a = 0, b = 1, c;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a);
            c = a + b;
            a = b;
            b = c;
        }
    }

    public string ReverseString(string str)
    {
        char[] reverseString = str.ToCharArray();
        Array.Reverse(reverseString);
        reverseString.ToArray();
        return string.Join("", reverseString);
    }

    public int RecursiveFactorial(int n)
    {
        // Todo: Implement a recursive method(a method that calls itself within its own function scope)
        // To Check the factorial of a number(norsk: Fakultet) we look at n!, where n = n * 1 * 2 * 3...
        if (n == 0)
        {
            return 1;
        }
        return n;
    }


}
