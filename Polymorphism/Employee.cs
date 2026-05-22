namespace Polymorphism;

public class Employee : Person, IQuitable // Employee inherits from Person and uses IQuitable
{
    public void Quit() // Uses the quit method needed for the IQuittable interface
    {
        Console.WriteLine("The employee has quit!");
    }
}
