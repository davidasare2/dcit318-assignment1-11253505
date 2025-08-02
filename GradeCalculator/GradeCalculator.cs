using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Grade Calculator Application ===");
            Console.Write("Enter a numerical grade (0-100): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int grade))
            {
                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Error: Grade must be between 0 and 100.");
                }
                else if (grade >= 90)
                {
                    Console.WriteLine("Letter Grade: A");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("Letter Grade: B");
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("Letter Grade: C");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("Letter Grade: D");
                }
                else
                {
                    Console.WriteLine("Letter Grade: F");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }

            Console.WriteLine("Thank you for using the Grade Calculator.");
        }
    }
}
