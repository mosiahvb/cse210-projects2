using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator= new PromptGenerator();
        Journal journal = new Journal();
        int menuUserInput = 0;

        List<string>  menu =new List<String>
        {
            "",
            "MENU",
            "please select one of the following choices",
            "1 Write",
            "2 Display",
            "3 Load",
            "4 Save",
            "5 Quit",
            "what would you like to do?"
        };
        Console.WriteLine("welcome to the journal program");

        while(menuUserInput !=5)
        {
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserInput= int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            switch (menuUserInput)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.Date.ToString("MMM dd, yyyy");

                    Entry entry = new Entry(date, prompt, response);
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("what is the filename?");
                    string fileNameLoad = Console.ReadLine();
                    journal.LoadFromFile(fileNameLoad);
                    break;
                case 4:
                    Console.WriteLine("what is the filename?");
                    string fileNameSave = Console.ReadLine();
                    journal.SaveToFile(fileNameSave);
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.WriteLine();
                    break;
          
          }
        }
    }
}
