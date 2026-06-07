namespace AbstractClasses;

public class Employee : Person // Employee class inheriting Person class
{
    public override void SayName()
    {
        Console.WriteLine("Name: " + firstName + " " + lastName);
    }
}