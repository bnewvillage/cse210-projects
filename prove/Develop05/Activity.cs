using System.Runtime.InteropServices;

public class Activity{
        private string _name;
        private string _description;
        private int _duration;

        public Activity(){

        }

        public Activity(string name, string description){
            _name = name;
            _description = description;
        }

        public void DisplayStartingMessage(){
            Console.Clear();
            Console.Write($"Welcome to {_name}.\n{_description}\n\nHow long, in seconds, would you like your session? ");
            _duration = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Get Ready...");Spinner(2);
        }

        public void DisplayEndingMessage(){
            Console.Clear();
            Console.Write($"Well done!");
            Spinner(2);
            Console.Write($"\nYou have complete another {_duration} seconds of the {_name}.");
            Spinner(2);
            Console.Clear();
        }

        public void Spinner(int seconds){
            DateTime currentTime = DateTime.Now;
            DateTime futureTime = currentTime.AddSeconds(seconds);
        
            while (currentTime !< futureTime){
                Console.Write("\\");
                Thread.Sleep(300);
                Console.Write("\b \b");
                Thread.Sleep(300);
                currentTime = DateTime.Now;
                Console.Write("|");
                Thread.Sleep(300);
                Console.Write("\b \b");
                Thread.Sleep(300);
                currentTime = DateTime.Now;
                Console.Write("/");
                Thread.Sleep(300);
                Console.Write("\b \b");
                Thread.Sleep(300);
                currentTime = DateTime.Now;
                Console.Write("-");
                Thread.Sleep(300);
                Console.Write("\b \b");
                Thread.Sleep(300);
                currentTime = DateTime.Now;
            }
        }

        public void ShowCountdown(int seconds){
            while (seconds > 0){
                Console.Write($"{seconds}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                seconds = seconds-1;
            }
        }

        public int GetDuration(){
            return _duration;
        }
        
    }