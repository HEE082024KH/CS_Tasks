namespace CS_Tests;

class Program
{
    static void Main(string[] args)
    {
        Fundament fundament = new();

        // Check even or odd
        fundament.CheckOddOrEven(3);
        // Display fact
        fundament.GetAInterestingFact("This fact is quite interesting");
        // Sum two numbers
        fundament.SumTwoNumbers();
        // Sum two given numbers
        Console.WriteLine(fundament.SumTwoNumbersOfGivenType(1, 1));
    }
}