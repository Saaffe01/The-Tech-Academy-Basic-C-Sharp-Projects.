using System;

namespace Basic_C_Programs;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The Tech Academy"); // Print School Name
        
        Console.WriteLine("Student Daily Report"); // Print Student Report
        
        Console.Write("What is your name ? "); // Student enters name
        string studentName = Console.ReadLine();
        
        Console.Write("What course are you on ?"); // Student notes what
        string courseName = Console.ReadLine();    // course they are on.
        
        Console.Write("What page number ? "); // Define page number
        int pageNumber = int.Parse(Console.ReadLine());
        
        // This will ask if the user needs help 
        Console.Write("Do you need help with anything? Please answer \"true\" or \"false\": ");
        bool help = bool.Parse(Console.ReadLine());
        
        // Let's user note any/all positive experiences
        Console.Write("Were there any positive experiences you'd like to share? Please give specifics: ");
        string experiences = Console.ReadLine();
        
        // Let's user input number of hours studied
        Console.Write("How many hours did you study ? "); 
        double hours = double.Parse(Console.ReadLine());
        
        // Prints the closing message 
        Console.Write("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
    }
}