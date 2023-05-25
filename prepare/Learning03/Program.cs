using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate an instance of the obj
        Fraction fraction_3 = new Fraction();

        fraction_3.SetTop(3);
        fraction_3.SetBottom(4);

        Console.WriteLine(fraction_3.GetTop());
        Console.WriteLine(fraction_3.GetBottom());
        Console.WriteLine(fraction_3.GetFractionString());
        Console.WriteLine(fraction_3.GetDecimalValue());
    }
}