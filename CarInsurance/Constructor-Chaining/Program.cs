namespace Constructor;

public class Program
{
    static void Main(string[] args)
    {
        const int Courses = 20;
        // Input values for the person we're about to build
        var Age = 29;
        var Name = "Saaffe";

        // Creating the object, fires the constructor chain
        // Constructor sets Age, then chains to set Name
        var person = new Person(Name, Age);
        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);
        
    }
}
