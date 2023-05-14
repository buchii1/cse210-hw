using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        // Create an instance of the Person class
        Person person = new Person();
        person._givenName = "Godspower";
        person._familyName = "Okonkwo";
        person.ShowEasternName();
        person.ShowWesternName();

        // Create an instance of the Blind class
        Blind kitchen = new Blind();
        kitchen._width = 60;
        kitchen._height = 48;
        kitchen._color = "white";

        double materialAmount = kitchen.GerArea();
        Console.WriteLine($"\nHeight: {kitchen._height}\nWidth: {kitchen._width}\nColor: {kitchen._color}");
    
        House myHome = new House();
        myHome._owner = "Buchii";
        // myHome._kitchen._width = 120;
        // myHome._kitchen._height = 90;
        // myHome._kitchen._color = "Ash";
        myHome._blinds.Add(kitchen);
        double amount = myHome._blinds[0].GerArea();
        string color = myHome._blinds[0]._color;
        Console.WriteLine($"Amount: {amount}, Color: {color}");
    }

    public class Person
    {
        public string _givenName = "";
        public string _familyName  = "";

        // Initialize class constructor
        public Person()
        {
        }

        // Method 1
        public void ShowEasternName()
        {
            Console.WriteLine($"{_familyName}, {_givenName}");
        }

        // Method 2
        public void ShowWesternName()
        {
            Console.WriteLine($"{_givenName} {_familyName}");
        }
    }

    public class Blind
    {
        public double _width;
        public double _height;
        public string _color;

        public double GerArea()
        {
            return _width * _height;
        }
    }

    public class House
    {
        public string _owner = "";
        // public Blind _kitchen = new Blind();
        // public Blind _livingRoom = new Blind();
        public List<Blind> _blinds = new List<Blind>();
    }
}