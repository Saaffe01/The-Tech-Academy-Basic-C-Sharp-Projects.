using System.Data;

namespace ParsingEnums;

// Enum representing the days of the week
enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main(string[] args)
    {
        // Prompting the user to enter day of the week
        Console.WriteLine("Enter the current day of the week: ");
        
        // Store users input
        string input = Console.ReadLine();

        try // try to parse the string input into dayofweek enum
        {
            DayOfWeek day = Enum.Parse<DayOfWeek>(input);
            Console.WriteLine("You entered: " + day);
        }
        catch 
        {
            // if parsing fails, inform user input was invalid
            Console.WriteLine("Please enter an actual day of the week.");
        }

        
    }
}