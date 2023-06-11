using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput;
        
        do
        {
            Menu menu = new Menu();
            menu.DisplayMenu();
            userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Breathing breath = new Breathing();
                breath.RunActivity();
            }
            else if (userInput == 2)
            {
                Reflecting reflect = new Reflecting();
                reflect.RunActivity();
            }
            else if (userInput == 3)
            {
                Listing list = new Listing();
                list.RunActivity();
            }
            else
            {
                Console.WriteLine("Thank you for participating in this exercise.");
            }
        } while (userInput < 4);
    }
}

/*
EXTRA REQUIREMENTS

1. I added a codeblock that prevents duplicate prompts from being displayed in the Reflection and Listing Activity.

*/