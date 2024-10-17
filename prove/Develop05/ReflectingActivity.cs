using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    Random random = new Random();
    public ReflectingActivity(string name, string description) : base(name, description){
    }

    public void AddPrompts(string prompt){
        _prompts.Add(prompt);
    }

    public void AddQuestions(string question){
        _questions.Add(question);
    }
    public void Run(){
        DisplayStartingMessage();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(GetDuration());

        while (futureTime > currentTime){
            Console.Write($"\n\n> {GetRandomPrompt()}");Spinner(2);
            Console.WriteLine();
            Console.Write($"> {GetRandomQuestion()}");Spinner(2);
        
            currentTime = DateTime.Now;
            Console.Clear();
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt(){
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public string GetRandomQuestion(){
        int index = random.Next(_questions.Count);
        string question = _questions[index];
        return question;
    }

    


}