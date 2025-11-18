using System;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks: ");
            bool validMarks = int.TryParse(Console.ReadLine(), out int marks);

            Console.Write("Enter total: ");
            bool validTotal = int.TryParse(Console.ReadLine(), out int total);

            if (!validMarks || !validTotal)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            // I put my FIRST BREAKPOINT on the next line
            // When program stops here → I check marks and total values
            // Example: I entered 45 and 50 → both values are correct
            double percentage = marks / total * 100;   // ← BUG IS HERE

            // I put my SECOND BREAKPOINT on the next line
            // After I press F10 → I see percentage became 0.0 (wrong!)
            // I understood the problem: integer division (45/50 = 0)
            Console.WriteLine($"Percentage = {percentage}");
        }
    }
}