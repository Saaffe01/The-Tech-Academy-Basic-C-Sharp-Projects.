namespace ClassSubmission;

class Program
{
    static void Main(string[] args)
    {
        MathHelper math = new MathHelper(); // Creating instance of MathHelper
        
        Console.WriteLine("Enter a number"); 
        int number = int.Parse(Console.ReadLine());
        
        math.DivideByTwo(number);
        
        // Created a new instance of Calculator
        Calculator calc = new Calculator();

        // Declare variables for out parameters
        int sum, difference;
        calc.Calculate(10, 4, out sum, out difference);

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + difference);
        
        int threeSum;
        calc.Calculate(10, 4, 6, out threeSum); // Call Calculate with 2 numbers using out parameters
        Console.WriteLine("Three number sum: " + threeSum);
        
        Utility.DisplayMessage("Hello from a static class");
    }
}