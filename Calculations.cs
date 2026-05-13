namespace MethodOverloading;

public class Calculations 
{
    // Method that takes int and multiplies it by 5
    public int Calculator (int number)
    {
        return number * 5;
    }

    // overloaded method that takes a string, parses to int, and adds 10
    public int Calculator(string number)
    {
        var parsed = int.Parse(number);
        return parsed + 10;
    }
    
    // overloaded method that takes decimal, multiplies it by 2, and casts tom int
    public int Calculator(decimal number)
    {
        return (int)(number * 2);
    }
}
