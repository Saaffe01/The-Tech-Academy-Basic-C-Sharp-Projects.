namespace Polymorphism;

public class Person // Base class that holds shared properties for any person
{
    public string FirstName { get; set; } // Property to store first name
    public string LastName { get; set; } // Property to store last name 

    public void SayName() // Method that prints the full name to the console
    {
        Console.WriteLine("Name: " + FirstName + " " + LastName);
    }
}
