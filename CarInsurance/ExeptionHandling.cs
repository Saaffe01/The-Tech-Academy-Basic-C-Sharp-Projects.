using System;

class Program
{
    static void Main(string[] args)
    {
        // STRINGS AND INTEGERS SUBMISSION ASSIGNMENT
        // List of integers. Also asking the user to divide each number in the list by.
        var numbers = new List<int>() { 10, 25, 50, 100, 200 };
        
        Console.WriteLine("Pick a number to divide from the list");


        try
        {
            int numbersDivided = Convert.ToInt32(Console.ReadLine());
            
            foreach (var number in numbers)
            {
                Console.WriteLine(number / numbersDivided); // divides the number from user input
            }
        } // catching first exception when divided by Zero 
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message + " Please do not divide by zero"); // Lets user know that input cannot be 0 
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message + " Please do not divide by string"); // Lets user know input cannot be a string
        }
        Console.WriteLine("Program has continued after the try/catch block!");
    }
}
