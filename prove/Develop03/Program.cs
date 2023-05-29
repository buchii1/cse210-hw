using System;

class Program
{
    static async Task Main(string[] args)
    {
        // Instantiate an instance of the File class
        File newFile = new File();

        // Read the scriptures.txt file to a dictionary
        newFile.ReadFile();

        // Create an instance of Scripture Class
        Scripture quote = null;

        // Create a list of prompts
        List<string> prompts = new List<string>() {
            "Memorize a Random Scripture.",
            "Memorize a Scripture from our Library.",
            "Memorize a Scripture of your choice."
        };

        Console.WriteLine("Welcome to the Scripture Memorizer Program!\n");
        Console.WriteLine("What do you want to do?");
        
        // Loop through the prompts and display to the terminal
        for (int i = 0; i < prompts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {prompts[i]}");
        }

        Console.Write("Input a number: ");
        int userChoice = int.Parse(Console.ReadLine());

        // Keep looping till a valid input is entered
        while (userChoice < 1 || userChoice > prompts.Count)
        {
            Console.Write("Input a number: ");
            userChoice = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        if (userChoice == 1)
        {
            // Call the GetRandomScripture method
            KeyValuePair<string, string> randomScripture = newFile.GetRandomScripture();

            // Create an instance of Scripture and print to the console
            quote = new Scripture(randomScripture.Key, randomScripture.Value);
            Console.WriteLine(quote.GetRenderedText());
        }
        else if (userChoice == 2)
        {   
            // Call the OutputScripture method
            List<string> scriptureList = newFile.OutputScripture();

            // Loop through the scriptureList and display to the console
            foreach (string reference in scriptureList)
            {
                Console.WriteLine(reference);
            }
            
            Console.Write("Input a number: ");
            int num = int.Parse(Console.ReadLine());

            // Keep looping till a valid input is entered
            while (num < 1 || num > scriptureList.Count)
            {
                Console.Write("Input a number: ");
                num = int.Parse(Console.ReadLine());
            }

            // Call the DisplaySelectedScripture method
            KeyValuePair<string, string> selected = newFile.DisplaySelectedScripture(num);

            // Create an instance of Scripture and print to the console
            quote = new Scripture(selected.Key, selected.Value);
            Console.WriteLine(quote.GetRenderedText());
        }
        else
        {
            // Create an instance of Reference
            Reference newRef = null;

            // Prompt the user for Reference details
            Console.Write("Enter a book, eg(John): ");
            string book = Console.ReadLine().ToLower();
            Console.Write("Enter a chapter, eg(3): ");
            string chapter = Console.ReadLine();
            Console.Write("Enter a start verse, eg(16): ");
            string startVerse = Console.ReadLine();
            Console.Write("Enter an end verse, or press 'Enter' key if not needed: ");
            string endVerse = Console.ReadLine();
            Console.WriteLine();

            // Pass the values to the Reference constructor
            if (endVerse != "")
            {
                newRef = new Reference(book, chapter, startVerse, endVerse);
            }
            else
            {
                newRef = new Reference(book, chapter, startVerse);
            }

            // Create an instance of ScriptureAPI
            ScriptureAPI search = new ScriptureAPI(newRef.GetReference());
            await search.QueryAPI();

            // Call the GetScripture method
            KeyValuePair<string, string> selected = search.GetScripture();

            // Create an instance of Scripture and print to the console
            quote = new Scripture(selected.Key, selected.Value);
            Console.WriteLine(quote.GetRenderedText());

        }

        // Declare a variable to hold user input
        string userInput;

        do
        {
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                // Clear the console
                Console.Clear();
                // Call the HideWord method
                quote.HideWords();
                // Display the scripture to the console
                Console.WriteLine(quote.GetRenderedText());
                
                // End the program if all words are hidden
                if (quote.IsCompletelyHidden() == true)
                {
                    break;
                }
            }
        }
        
        while (userInput != "quit"); // End the program if user enters "quit"
    }
}


/*
EXTRA REQUIREMENTS

1. I added a codeblock that prevents duplicate words from being hidden in the program.
2. I added a File class that read the scriptures from a txt file and adds each reference as a key, and the text as a value to a dictionary.
3. I added the ability for a user to select a random scripture or choose a scripture from a list of scriptures.
4. I added a ScriptureAPI class that gets the reference of a scripture from the user, makes an API call to an endpoint, gets the details of the
    scripture from the endpoint, and appends both the reference and endpoint to a dictionary.
*/