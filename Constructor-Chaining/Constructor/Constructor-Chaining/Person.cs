namespace Constructor;


/// <summary>
///  Represents a person with a name and an age 
/// </summary>
public class Person
{
    public string Name;
    public int Age;

    // Base constructor: handles setting the name
    public Person(string name) 
    {
        Name = name;
    }

    // chains to the constructor above with : this(name)
    // so name is set there
    public Person(string name, int age) : this(name)
    {
        Age = age;
    }
}