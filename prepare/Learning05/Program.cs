using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("John", "Fractions", "8.3", "7-13");
        mathAssignment.GetHomeWorkList();

        WritingAssignment writingAssignment = new WritingAssignment("Alexa", "Play Despacito", "Deeees Paaaa Cito");
        writingAssignment.GetWritingInformation();
    }
}