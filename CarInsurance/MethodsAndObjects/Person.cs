namespace MethodsAndObjects;

public class Person // Abstract class that serves as a base for the other classes
{
    public string FirstName { get; set; } // Property to store the first name
    public string LastName { get; set; } // Property to store the last name

    public void SayName() // Abstract method that must be implemented by any class that inherits Person
    {
        Console.WriteLine("Name: " + FirstName + " " + LastName);
    }
}
