namespace AbstractClasses;

public abstract class Person // Initial Abstract class
{
    public string firstName { get; set; }
    public string lastName { get; set; }

    public abstract void SayName();
}