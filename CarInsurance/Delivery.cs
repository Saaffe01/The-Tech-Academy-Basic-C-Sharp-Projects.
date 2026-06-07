using System;

namespace DriverApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
        
        Console.WriteLine("Please enter your package weight");
        int packageWeight = int.Parse(Console.ReadLine());
        
        // specifying max package weight allowable
        int maxPackageWeight = 50;

        // Comparison for the package weights
        if (packageWeight > maxPackageWeight)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        }
        
        Console.WriteLine("Please enter package width");
        int packageWidth = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Please enter package height");
        int packageHeight = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Please enter package length");
        int packageLength = int.Parse(Console.ReadLine());

        int packageDimensions = packageWidth + packageHeight + packageLength; 

        if (packageDimensions > 50) 
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
        }
        
        double shippingQuote = (packageWidth * packageHeight * packageLength) * packageWeight / 100.0;
        
        // Displaying final quote.
        Console.WriteLine("Your shipping quote is: $" + shippingQuote);
        
    }
}