using System;

class Program
{
    static void Main()
    {
        // Step 1: Display welcome message
        DisplayWelcome();

        // Step 2: Get user input (name and favorite number)
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();

        // Step 3: Calculate the square of the number
        int squaredNumber = SquareNumber(favoriteNumber);

        // Step 4: Display the final result
        DisplayResult(userName, squaredNumber);
    }

    // Function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function to prompt the user for their name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt the user for their favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to square a number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}