using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Ticket Price Calculator ===");

            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                int price;

                if (age <= 12 || age >= 65)
                {
                    price = 7;
                }
                else
                {
                    price = 10;
                }

                Console.WriteLine($"Ticket Price: GHC{price}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric age.");
            }

            Console.WriteLine("Thank you for using the Ticket Price Calculator.");
        }
    }
}
