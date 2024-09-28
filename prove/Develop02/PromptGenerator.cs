public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>();
        prompts.Add("What was something interesting that happened today?");
        prompts.Add("What made you smile today?");
        prompts.Add("How would you describe your day in one word, and why?");

        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        string randomPrompt = prompts[randomIndex];

        return randomPrompt;
    }
}