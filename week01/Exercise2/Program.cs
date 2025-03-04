using System;

class Program
{
    static void Main()
    {
        // Ask user for grade percentage
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();

        // Convert string input to an integer
        int grade = int.Parse(input);
        string letter = "";
        string sign = "";

        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine if a "+" or "-" should be added
        int lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Handle special cases (A+ does not exist, F has no sign)
        if (letter == "A" && sign == "+")
        {
            sign = ""; // No A+
        }
        if (letter == "F")
        {
            sign = ""; // No F+ or F-
        }

        // Display the final grade
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Determine if the student passed or failed
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep working hard! You'll do better next time.");
        }
    }
}