using System.Runtime.InteropServices.JavaScript;

namespace DateTime;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(System.DateTime.Now); // Print current time

        Console.WriteLine("Enter a number of hours: ");
        // Parse users input as an integer
        int hours = int.Parse(Console.ReadLine());
        
        // Add the entered hours to current datetime and print it
        Console.WriteLine(System.DateTime.Now.AddHours(hours));
    }
}