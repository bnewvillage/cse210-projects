public class ListingActivity : Activity{
    private Random random = new Random();
    private List<string> _prompts = new List<string>();
    private int _count;
    public ListingActivity(string name, string description) :base(name, description){

    }

    public void AddPrompts(string prompt){
        _prompts.Add(prompt);
    }

    public void Run(){
        DisplayStartingMessage();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(GetDuration());
        Console.WriteLine("\n");
        Console.Write(GetRandomPrompt());
        Console.Write("\nYou can begin writing in...");
        ShowCountdown(5);
        Console.WriteLine();
        while (futureTime > currentTime){
            Console.Write($"{">",3} ");
            Console.ReadLine();
            _count +=1;
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"\nYou listed {_count} items!");
        Thread.Sleep(2000);
        Console.WriteLine();
    }

    public string GetRandomPrompt(){
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }
}