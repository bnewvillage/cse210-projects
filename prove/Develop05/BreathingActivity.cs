public class BreathingActivity : Activity{
    
    public BreathingActivity(){

    }
    public BreathingActivity(string name, string description) : base(name, description){

    }

    public void Run(){
        DisplayStartingMessage();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(GetDuration());

        while (futureTime > currentTime){
            Console.Write("\nBreathe in...");ShowCountdown(4);
            Console.WriteLine();
            Console.Write("Breathe out...");ShowCountdown(6);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
        DisplayEndingMessage();

    }
}