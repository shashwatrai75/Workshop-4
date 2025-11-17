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

            // BREAKPOINT 1 — click here on the left margin
            double percentage = marks / total * 100; // <-- wrong on purpose

            // BREAKPOINT 2 — click here on the left margin
            Console.WriteLine($"Percentage = {percentage}");
        }
    }
}
