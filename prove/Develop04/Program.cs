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
                BreathingActivity breath = new BreathingActivity();
                breath.RunActivity();
            }
            else if (userInput == 2)
            {
                ReflectingActivity reflect = new ReflectingActivity();
                reflect.RunActivity();
            }
            else if (userInput == 3)
            {
                ListingActivity list = new ListingActivity();
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