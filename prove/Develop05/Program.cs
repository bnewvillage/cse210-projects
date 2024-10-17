using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Menu menu = new Menu();
        int selection = menu.GetSelection();

        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on time in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        reflectingActivity.AddPrompts("Think of a time when you stood up for someone else.");
        reflectingActivity.AddPrompts("Think of a time when you did something really difficult.");
        reflectingActivity.AddPrompts("Think of a time when you helped someone in need.");
        reflectingActivity.AddPrompts("Think of a time when you did something truly selfless.");
        reflectingActivity.AddQuestions("Why was this experience meaningful to you?");
        reflectingActivity.AddQuestions("Have you ever done anything like this before?");
        reflectingActivity.AddQuestions("How did you get started?");
        reflectingActivity.AddQuestions("How did you feel when it was complete?");
        reflectingActivity.AddQuestions("What made this time different than other times when you were not as successful?");
        reflectingActivity.AddQuestions("What is your favorite thing about this experience?");
        reflectingActivity.AddQuestions("What could you learn from this experience that applies to other situations?");
        reflectingActivity.AddQuestions("What did you learn about yourself through this experience?");
        reflectingActivity.AddQuestions("How can you keep this experience in mind in the future?");

        ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        listingActivity.AddPrompts("Who are people that you appreciate?");
        listingActivity.AddPrompts("What are personal strengths of yours?");
        listingActivity.AddPrompts("Who are people that you have helped this week?");
        listingActivity.AddPrompts("When have you felt the Holy Ghost this month?");
        listingActivity.AddPrompts("Who are some of your personal heroes?");


        while (selection != 0){
            if (selection == 1){
                breathingActivity.Run();
                selection = menu.GetSelection();
            }
            else if (selection == 2){
                reflectingActivity.Run();
                selection = menu.GetSelection();
            }
            else if (selection == 3){
                listingActivity.Run();
                selection = menu.GetSelection();
            }
            else if (selection == 4){
                Console.Clear();
                break;
            }
        }

    }
}