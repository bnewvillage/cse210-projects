        public class Selection
        {
            public int ShowOptions()
            {
                Console.WriteLine("");
                Console.WriteLine("1. Add Journal Entry");
                Console.WriteLine("2. Display All Entries");
                Console.WriteLine("3. Save Journal");
                Console.WriteLine("4. Load Journal");
                Console.Write("5. Quit\n> ");
                int selection = int.Parse(Console.ReadLine());
                return selection;
            }
        }