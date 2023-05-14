using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        AddPrompt newPrompt = new AddPrompt();
        TerminalServices menu = new TerminalServices();
        Journal journal = new Journal();
        File newFile = new File();
        
        int prompt;

        do
        {
            menu.DisplayMenu();
            prompt = menu._userResponse;

            if (prompt == 1)
            {
                newPrompt.AddNewPrompt();
                string addPrompt = newPrompt._prompt;
                menu._questionPrompts.Add(addPrompt);
            }

            else if (prompt == 2)
            {
               Entry entry = new Entry();
               menu.DisplayRandomQuestions();
               if (menu._promptsRemaining)
               {
                    string answer = Console.ReadLine();
                    entry._userResponse = answer;

                    string question = menu._question;
                    entry._question = question;

                    journal._journal.Add(entry);             
               }
            }

            else if (prompt == 3)
            {
                journal.DisplayJournal();
            }

            else if (prompt == 4)
            {
                string file = newFile._fileName;
                List<Entry> savedEntries =  newFile.ReadFile();
                foreach (Entry entry in savedEntries)
                {
                    journal._journal.Add(entry);
                }
            }

            else if (prompt == 5)
            {
                newFile.WriteFile(journal._journal);
                string file = newFile._fileName;
            }
            
            else
            {
                Console.WriteLine("See you next time!");
            }

        } while (prompt < 6);
    }
}


/*
EXTRA REQUIREMENTS

1. I added a codeblock that removes prompts that have been suggested from the list of prompts.
    Thereby preventing a prompt from appearing multiple times.
2. I added a new class named AddPrompt that allows the user the option of adding more prompts 
    to the list of prompts.
*/