using System;

class Program
{
    static void Main(string[] args)
    {
        // Lectures Event Details
        string lTitle = "Symposium on the Effects of Time Mismanagement";
        string lDesc = "An event that dives deeper on the dangers of wasting time.";
        string lDate = "25th July, 2023";
        string lTime = "10:00 am - 12 noon";
        string name = "Professor Eunice Angel";
        int capacity = 120;
        string lStreet = "Women Development Center";
        string lCity = "Lugbe";
        string lState = "FCT";
        string lCountry = "Nigeria";

        // Receptions Event Details
        string rTitle = "Andela House LunchOn";
        string rDesc = "Open house of the new Andela Rock House.";
        string rDate = "10th August, 2023";
        string rTime = "03:00 pm - 06:00 pm";
        string email = "Hello, kindly click on the link below to register for our upcoming open house and lunch on. Thanks!";
        string rStreet = "Senator Uche Ekwunife Events Center";
        string rCity = "Awka";
        string rState = "Anambra State";
        string rCountry = "Nigeria";

        // Outdoor Event Details
        string oTitle = "CodeIn Sports Festival";
        string oDesc = "A sporting event organized by CodeIn for developers and all tech enthusiast to meet and unwind together.";
        string oDate = "30th September, 2023";
        string oTime = "7:00 am - 12 noon";
        string weather = "According to our latest weather forecast, we expect mild showers of rain on that day. So, come prepared.";
        string oStreet = "SDG Sports Club and Arena";
        string oCity = "Lekki Phase 1";
        string oState = "Lagos State";
        string oCountry = "Nigeria";

        // Instance 3 instances of the Address class
        Address lAddress = new Address(lStreet, lCity, lState, lCountry);
        Address rAddress = new Address(rStreet, rCity, rState, rCountry);
        Address oAddress = new Address(oStreet, oCity, oState, oCountry);

        // Instantiate Lectures, Receptions and Outdoor class
        Lectures lecture = new Lectures(lTitle, lDesc, lAddress, lDate, lTime, name, capacity);
        Receptions reception = new Receptions(rTitle, rDesc, rAddress, rDate, rTime, email);
        Outdoor outdoor = new Outdoor(oTitle, oDesc, oAddress, oDate, oTime, weather);

        // Display Events
        lecture.DisplayEvent();
        Console.WriteLine("\n");
        reception.DisplayEvent();
        Console.WriteLine("\n");
        outdoor.DisplayEvent();
    }
}