using System;

namespace DriverApp;

class Program
{
    static void Main(string[] args)
    {
        // Ask for drivers age
        Console.WriteLine("What is your age?");
        int driverAge = int.Parse(Console.ReadLine());

        // Checks if driver has a DUI
        Console.WriteLine("Have you ever had a DUI?");
        bool hasDui = bool.Parse(Console.ReadLine());

        // Checks if driver has speeding tickets
        Console.WriteLine("How many speeding tickets do you have?");
        int speedingTickets = int.Parse(Console.ReadLine());

        // checks all 3 qualifications from driver 
        bool isQualified = driverAge > 15 && hasDui == false && speedingTickets <= 3;

        // Print the final result
        Console.WriteLine("Qualified?");
        Console.WriteLine(isQualified);
    }
}