namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            Stack<string[]> personnel = new Stack<string[]>();
            while (isRunning)
            {
                Console.WriteLine("Please Enter a name of personnel.");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter salary for this personnel.");
                string salary = Console.ReadLine();
                string[] person = { name, salary };
                personnel.Push(person);
                bool choicePanel = true;
                while (choicePanel)
                {
                    Console.WriteLine("What do you want to do next?");
                    Console.WriteLine("1. Add another personnel.");
                    Console.WriteLine("2. View all personnel.");
                    Console.WriteLine("3. Exit.");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("You chose to add another personnel.");
                            choicePanel = false;
                            break;
                        case "2":
                            Console.WriteLine("You chose to view all personnel.");
                            foreach (string[] p in personnel)
                            {
                                Console.WriteLine("[ Name: " + p[0] + " | " + " Salary: " + p[1] + " SEK ]");
                            }
                            break;
                        case "3":
                            Console.WriteLine("You chose to exit.");
                            isRunning = false;
                            choicePanel = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
            }
        }
    }
}