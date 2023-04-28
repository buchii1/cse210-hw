using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int favNum = PromptUserNumber();

        int sqrRoot = SquareNumber(favNum);

        DisplayResult(userName, sqrRoot);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNum = int.Parse(Console.ReadLine());

        return favNum;
    }

    static int SquareNumber(int num)
    {
        int square = num * num;

        return square;
    }

    static void DisplayResult(string userName, int sqrNum)
    {
        Console.WriteLine($"{userName}, the square of your number is {sqrNum}");
    }
}