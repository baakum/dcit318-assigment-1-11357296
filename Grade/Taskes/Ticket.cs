using System;

class Ticket
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        if (int.TryParse(Console.ReadLine(), out int age) && age >= 0)
        {
            Console.WriteLine($"Ticket price: GHC{GetTicketPrice(age)}");
        }
        else
        {
            Console.WriteLine("Invalid input. Age must be a non-negative number.");
        }
    }

    static int GetTicketPrice(int age) => (age <= 12 || age >= 65) ? 7 : 10;
}
