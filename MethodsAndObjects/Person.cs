namespace MethodsAndObjects;

public class Person // Person class
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void SayName()
    {
        Console.WriteLine("Name: " + FirstName + " " + LastName);
    }
}