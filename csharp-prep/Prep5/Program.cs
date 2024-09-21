using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        DisplayWelcome();

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string username = Console.ReadLine();
            return username;
        }

        string name = PromptUserName();
        
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        int favoriteNumber = PromptUserNumber();

        static int SquareNumber(int favoriteNumber)
        {
            int squared = favoriteNumber * favoriteNumber;
            return squared;
        }

        int square = SquareNumber(favoriteNumber);

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
        }

        DisplayResult(name, square);
    }

}