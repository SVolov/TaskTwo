using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer in decimal:");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
        }

        Console.WriteLine("Enter the base of the new number system (from 2 to 20):");
        byte baseNumber;
        while (!byte.TryParse(Console.ReadLine(), out baseNumber) || baseNumber < 2 || baseNumber > 20)
        {
            Console.WriteLine("Invalid input. Please enter a valid base (from 2 to 20):");
        }

        string convertedNumber = ConvertToBase(number, baseNumber);
        Console.WriteLine($"Conversion result: {convertedNumber}");
    }

    static string ConvertToBase(int number, byte baseNumber)
    {
        const string digits = "0123456789ABCDEFGHIJ";

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