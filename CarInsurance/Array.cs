using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // One dimensional array of strings
        string[] cars = ["Toyota", "Honda", "Ford"];
        Console.Write("Pick an index (0-2): ");
        var i = int.Parse(Console.ReadLine());
        // message for when user selects different index other than specified
        Console.WriteLine(i >= 0 && i < cars.Length ? cars[i] : "Index doesn't exist!");

        // One dimensional array of integers
        int[] nums = [10, 20, 30];
        Console.Write("Pick an index (0-2): ");
        int j = int.Parse(Console.ReadLine()); 
        Console.WriteLine(j >= 0 && j < nums.Length ? nums[j] : "Index doesn't exist!");

        // List of strings
        List<string> fruits = ["Apple", "Banana", "Mango"];
        Console.Write("Pick an index (0-2): ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(k >= 0 && k < fruits.Count ? fruits[k] : "Index doesn't exist!");
    }
}