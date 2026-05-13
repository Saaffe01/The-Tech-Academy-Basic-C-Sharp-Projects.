namespace MethodSubmission;

class Program
{
    static void Main(string[] args)
    {
        // Prompt for user to get first number
        Console.WriteLine("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        
        // Prompt for user to let them know it's optional
        Console.WriteLine("Enter the second number: ");
        string secondInput = Console.ReadLine();

        var math = new Mathematics();

        // checks if they entered a 2nd number
        if (secondInput == "")
        {
            Console.WriteLine(math.Calculate(firstNumber));
        }
        else
        {
            int secondNumber = int.Parse(secondInput);
            Console.WriteLine(math.Calculate(firstNumber, secondNumber));
        }
    }
} 