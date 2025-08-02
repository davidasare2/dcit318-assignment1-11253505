using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Triangle Type Identifier ===");

            // Prompt user to enter three sides
            Console.Write("Enter side 1: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter side 2: ");
            string input2 = Console.ReadLine();
            Console.Write("Enter side 3: ");
            string input3 = Console.ReadLine();

            // Try parsing input to doubles
            if (double.TryParse(input1, out double side1) &&
                double.TryParse(input2, out double side2) &&
                double.TryParse(input3, out double side3))
            {
                // Check for triangle validity
                if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
                {
                    // Determine triangle type
                    if (side1 == side2 && side2 == side3)
                    {
                        Console.WriteLine("Triangle Type: Equilateral");
                    }
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        Console.WriteLine("Triangle Type: Isosceles");
                    }
                    else
                    {
                        Console.WriteLine("Triangle Type: Scalene");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid triangle: the side lengths do not form a triangle.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers for all three sides.");
            }

            Console.WriteLine("Thank you for using the Triangle Type Identifier.");
        }
    }
}

