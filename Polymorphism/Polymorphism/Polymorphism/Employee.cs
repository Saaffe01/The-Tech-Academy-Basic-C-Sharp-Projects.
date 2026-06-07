namespace Polymorphism;

public class Employee : Person, IQuitable
{
    public void Quit()
    {
        Console.WriteLine("The employee has quit!");
    }
}