using System;
using System.IO;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        PromptGenerator generator = new PromptGenerator();
        Selection select = new Selection();
        Console.WriteLine("Welcome to you journal!");
        
        int selection = 0;

        Journal journal = new Journal();
        while (selection != 5)
        {
            selection = select.ShowOptions();

            if (selection == 1)
            {
                Entry entry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                entry._date = dateText;
                string prompt = generator.GetRandomPrompt();
                entry._promptText = prompt;
                Console.Write($"{prompt}\n> ");
                entry._entryText = Console.ReadLine();
                journal.AddEntry(entry);
            }
            else if (selection == 2)
            {
                journal.DisplayAll();
            }
            else if (selection == 3)
            {
                Console.Write("Filename:\n> ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (selection == 4)
            {
                Console.Write("Filename:\n> ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
        }

        
    }
}