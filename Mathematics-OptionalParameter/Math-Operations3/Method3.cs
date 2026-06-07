using System;
using System.Net.Http.Headers;


class Method3
{
    static void Main(string[] args)
    {
        double num1 = 0;
        double num2 = 0;
        double result = 0;
        
        Console.WriteLine("------------------");
        Console.WriteLine("Calculator Program");
        Console.WriteLine("------------------");

        Console.WriteLine("Enter number 1: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter number 2: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter an option: ");
        Console.WriteLine("\t+ : Add");
        Console.WriteLine("\t- : Subtract");
        Console.WriteLine("* : Multiply");
        Console.WriteLine("/ : Divide");
        Console.Write("Enter an option: ");

        switch (Console.ReadLine())
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                break;
            case "/":
                result = num1 / num2;
                Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                break;
            default:
                Console.WriteLine("That is not a valid option");
                break;
        }

        Console.ReadKey();
    }
}