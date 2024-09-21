using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
        }

        float sum = 0;
        float largestNum = 0;
        foreach (int num in numbers)
        {
            if (num > largestNum)
            {
                largestNum = num;
            }
            sum = sum + num;
        }

        Console.WriteLine($"The sum is {sum}.");

        float average = 0;
        average = sum / numbers.Count;
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The largest number is {largestNum}.");


    }
}