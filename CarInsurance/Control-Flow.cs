using System;

namespace DriverApp;

class Program
{
    static void Main(string[] args)
    {
        // simple while loop.
        bool isRaining = true;

        while (isRaining == true)
        {
            // This will run once and stop the loop
            Console.WriteLine("Bring an umbrella!");
            isRaining = false; 
        }

        Console.WriteLine("Done.");
        
        // Simple do/while loop.
        bool isHungry = true;

        do
        {
            Console.WriteLine("Go eat some food!");
            isHungry = false;

        } while (isHungry == true);
    }
}