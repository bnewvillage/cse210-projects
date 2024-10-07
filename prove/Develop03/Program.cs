using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("2 Timothy",4,7,8);     
        Scripture scripture = new Scripture(reference,"I have fought the good fight, I have finished the race, I have kept the faith. Now there is in store for me the crown of righteousness, which the Lord, the righteous Judge, will award to me on that day—and not only to me, but also to all who have longed for his appearing.");
        bool cont = new bool();
        string input;
        Console.Clear();
        do {
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish.");
            
            input = Console.ReadLine();
            if (input == ""){
                cont = true;
            }
            else if (input == "quit"){
                cont = false;
            }
            scripture.HideRandomWords(3);
            Console.Clear();
        
            
        } while (cont == true);
            
    }
}