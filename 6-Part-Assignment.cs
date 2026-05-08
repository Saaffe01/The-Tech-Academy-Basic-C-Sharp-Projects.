using System;
using System.Collections.Generic;

namespace _6PartAssignment;

class Program
{
    static void Main(string[] args)
    {
        // Part 1
        
        // Single Dimension Array
        var names = new[] { "Saaffe", "Jalil", "Algarib" };
        
        // User Input for Text
        Console.WriteLine("Please enter your name: ");
        string userInput = Console.ReadLine();
    
        // Loop that iterates through each string in the array
        for (int i = 0; i < names.Length; i++)
        {
            names[i] = names[i] + userInput;
        }
        
        // 2nd loop that prints each string in the array
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        
        // Part 2
        
        // infinite loop
        int k = 0;
        while (k < 5)
        {
            Console.WriteLine(k);
        }
        
        // Corrected infinite loop
        int l = 0;
        while (l < 5)
        {
            Console.WriteLine(l); // code was fixed after iterating through the loop until condition was met
                                  // in the previous loop, the condition was always "true" so it's forever.
            l++;
        }
        // Part 3
        
        // loop where "<" is used
        int num = 0;
        while (num < 8)
        {
            Console.WriteLine(num);
            num++;
        }
        
        // loop where "<=" is used
        int num2 = 0;
        while (num2 <= 8)
        {
            Console.WriteLine(num2);
            num2++;
        }
        // Part 4
        
        // list of strings where each item is unique 
        var fruits = new List<string>() { "Apple", "Banana", "Mango", "Grape" };
        
        // Ask user input to search for in the list
        Console.WriteLine("Search for a fruit: ");
        string fruit = Console.ReadLine();
        
        // loop that iterates through the list and displays 
        // the index of the item list
        for (int i = 0; i < fruits.Count; i++)
        {
            if (fruits[i] == fruit)
            {
                Console.WriteLine(i);
            }
        }
        
        // code to check if user unput is on the list.
        bool found = false;

        for (int i = 0; i < fruits.Count; i++)
        {
            if (fruits[i] == fruit)
            {
                Console.WriteLine(i);
                found = true;
                break;
            }
        }
        
        if (!found)
        {
            Console.WriteLine(fruit + " is not on the list!");
        }
        // PART 5
        
        // list of strings that contains duplicates and has user search for it in the list
        var fruitsNew = new List<string>() { "Apple", "Banana", "Mango", "Apple", "Grape" };
        
        Console.WriteLine("Search for a fruit: ");
        string fruitNew = Console.ReadLine();
        
        // loop that iterates through the list and displays indices of the items matching the user selected text
        bool foundFruit = false;
        
        for (int i = 0; i < fruitsNew.Count; i++)
        {
            if (fruitsNew[i] == fruit)
            {
                Console.WriteLine(i);
                foundFruit = true;
            }
        }
        // added code to check if user input is on the list. and if not it lets user know 
        if (!foundFruit)
        {
            Console.WriteLine(fruitNew + " is not on the list!");
        }
        
        
        // PART 6
    
        // Create a list of strings that has 2 identical strings in the list
        var vegetables = new List<string>() { "Carrot", "Broccoli", "Carrot", "Spinach", "Broccoli" };
    
        // create a foreach() loop that evaluates each item. then displays message showing string and whether
        // it has already appeared in the list
        List<string> seenItem = new List<string>();
    
        foreach (var character in vegetables)
        {
            // Check the clipboard
            if (seenItem.Contains(character))
            {
                // Already on the clipboard — duplicate!
                Console.WriteLine(character + " - this item is a duplicate");
            }
            else
            {
                Console.WriteLine(character + " - this item is unique");
                seenItem.Add(character);
            }
        }
    }
    
   
 
}