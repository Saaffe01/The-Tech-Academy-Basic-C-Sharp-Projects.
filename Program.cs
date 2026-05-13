namespace MethodOverloading;

class Program
{
    static void Main(string[] args)
    {
        var calculations = new Calculations(); // Calling calculator and displaying result
        int result = calculations.Calculator(10);
        Console.WriteLine(result);
        
        int result2 = calculations.Calculator(1.23m); // Call calculator with a decimal and display result
        Console.WriteLine(result2);

        int result3 = calculations.Calculator("20"); // Call Calculator with string and display result
        Console.WriteLine(result3);
    }
}