using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        fraction.SetTOp(21);
        fraction.SetBottom(5);

        Console.WriteLine($"{fraction.GetFractionString()}");
        Console.Write($"{fraction.GetFractionDouble()}");


    }
}