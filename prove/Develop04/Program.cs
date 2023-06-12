using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        BreathingActivity breath = new BreathingActivity();
        ReflectingActivity reflect = new ReflectingActivity();
        ListingActivity list = new ListingActivity();

        int userInput;
        
        do
        {
            menu.DisplayMenu();
            userInput = int.Parse(Console.ReadLine());
            
            if (userInput == 1)
            {
                breath.RunActivity();
            }
            else if (userInput == 2)
            {
                reflect.RunActivity();
            }
            else if (userInput == 3)
            {
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

1. I added a codeblock that prevents duplicate prompts from being displayed in the Reflection and ListingActivity Activity.

*/