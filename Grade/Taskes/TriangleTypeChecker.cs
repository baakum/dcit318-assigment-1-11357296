using System;
using System.Linq;

class TriangleTypeChecker
{
    static void Main(string[] args)
    {
        int[] sides = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter side {i + 1}: ");
            sides[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(sides);

        
        if (sides[0] + sides[1] > sides[2])
        {
            int distinctCount = sides.Distinct().Count();

            string type = distinctCount switch
            {
                1 => "Equilateral",
                2 => "Isosceles",
                3 => "Scalene",
                _ => "Unknown"
            };

            Console.WriteLine($"Triangle Type: {type}");
        }
        else
        {
            Console.WriteLine("The given sides do not form a valid triangle.");
        }
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
