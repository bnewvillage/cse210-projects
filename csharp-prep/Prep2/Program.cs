using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int userGrade = int.Parse(Console.ReadLine());

        string letterGrade;
        if (userGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (userGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (userGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (userGrade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        bool passed;
        if (letterGrade == "A")     
        {
            passed = true;
        }          
        else if (letterGrade == "B")
        {
            passed = true;
        }
        else if (letterGrade == "C")
        {
            passed = true;
        }
        else
        {
            passed = false;
        }

        Console.WriteLine($"Your Grade is {letterGrade}");
        if (passed)
        {
            Console.WriteLine("You Passed!");
        }
        else
        {
            Console.WriteLine("You Failed.");
        }
    }
}