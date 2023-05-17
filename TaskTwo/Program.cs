using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer in decimal:");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the base of the new number system (from 2 to 20):");
        int baseNumber = Convert.ToInt32(Console.ReadLine());

        string convertedNumber = ConvertToBase(number, baseNumber);
        Console.WriteLine($"Conversion result: {convertedNumber}");
    }

    static string ConvertToBase(int number, int baseNumber)
    {
        const string digits = "0123456789ABCDEFGHIJ";

        if (baseNumber < 2 || baseNumber > 20)
        {
            Console.WriteLine("The base of the number system must be between 2 and 20.");
            return string.Empty;
        }

        if (number == 0)
        {
            return "0";
        }

        string result = string.Empty;

        while (number > 0)
        {
            int remainder = number % baseNumber;
            result = digits[remainder] + result;
            number /= baseNumber;
        }

        return result;
    }
}