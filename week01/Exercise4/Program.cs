using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                if (number == 0)
                    break;
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }

        if (numbers.Count > 0)
        {
            // Calculate sum, average, and max value
            int sum = numbers.Sum();
            double average = numbers.Average();
            int maxNumber = numbers.Max();

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {maxNumber}");

            // Stretch Challenge: Find the smallest positive number
            int? smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty().Min();
            if (smallestPositive > 0)
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");

            // Stretch Challenge: Sort the list and display
            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}