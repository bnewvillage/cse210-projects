using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

public class Menu{
    public int GetSelection(){
    
    Console.Write($"Menu Options:\n{"1.",3} Start Breathing Activity\n{"2.",3} Start Reflection Activity\n{"3.",3} Start Listing Activity\n{"4.",3} Quit\n\n> ");
    int selection = int.Parse(Console.ReadLine());
    return selection;
    }
}