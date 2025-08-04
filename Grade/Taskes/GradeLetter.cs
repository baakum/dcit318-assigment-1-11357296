using System;

class GradeLetter
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade (0-100): ");
        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            switch (grade)
            {
                case int g when (g >= 90 && g <= 100):
                    Console.WriteLine("Grade: A");
                    break;
                case int g when (g >= 80):
                    Console.WriteLine("Grade: B");
                    break;
                case int g when (g >= 70):
                    Console.WriteLine("Grade: C");
                    break;
                case int g when (g >= 60):
                    Console.WriteLine("Grade: D");
                    break;
                case int g when (g >= 0):
                    Console.WriteLine("Grade: F");
                    break;
                default:
                    Console.WriteLine("Invalid grade. Must be 0–100.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
        Console.WriteLine("Press any key to exit...");
        char c = Console.ReadKey().KeyChar;
    }
}
