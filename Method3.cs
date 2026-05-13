using System;


class MathOperations3
{
    public void PerformMath(int firstNumber, int secondNumber)
    {
        // Perform a math operation on the first integer and multiply by 2
        int result = firstNumber * 2;

        // Display result
        Console.WriteLine("Result of math operation on first number: " + result);

        // Display the second int
        Console.WriteLine("Second number is: " + secondNumber);
    }
}


class Program
{
    static void Main(string[] args)
    {
        var mathObject = new MathOperations3();

        mathObject.PerformMath(10, 25);

        mathObject.PerformMath(firstNumber: 7, secondNumber: 50);

        // Pause the console window so the user can read the output
        Console.ReadLine();
    }
}