using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate an instance of the File class
        File newFile = new File();

        // Read the scriptures.txt file to a dictionary
        newFile.ReadFile();
        Scripture quote = null;

        Console.WriteLine("Welcome to the Scripture Memorizer Program!\n");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1. Memorize a Random Scripture.\n2. Choose a Scripture from our Library.");
        Console.Write("Input a number: ");
        int userChoice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (userChoice == 1)
        {
            // Generate a random scripture
            KeyValuePair<string, string> randomScripture = newFile.GetRandomScripture();

            // Instantiate an instance of a Scripture class with a random scripture
            quote = new Scripture(randomScripture.Key, randomScripture.Value);
            Console.WriteLine(quote.GetRenderedText());
        }
        else
        {
            List<string> scriptureList = newFile.OutputScripture();

            foreach (string reference in scriptureList)
            {
                Console.WriteLine(reference);
            }
            
            Console.Write("Input the number: ");
            int num = int.Parse(Console.ReadLine());

            while (num < 1 || num > scriptureList.Count)
            {
                // Console.WriteLine("Invalid Selection");
                Console.Write("Input a number: ");
                num = int.Parse(Console.ReadLine());
            }

            // Generate the chosen scripture
            KeyValuePair<string, string> selected = newFile.DisplaySelectedScripture(num);

            // Instantiate an instance of a Scripture class with the chosen scripture
            quote = new Scripture(selected.Key, selected.Value);
            Console.WriteLine(quote.GetRenderedText());
        }

        string userInput;

        do
        {
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                Console.Clear();
                quote.HideWords();
                Console.WriteLine(quote.GetRenderedText());
                
                if (quote.IsCompletelyHidden() == true)
                {
                    break;
                }
            }
        }
        
        while (userInput != "quit");
    }
}