namespace OperatorOverload;

public class Employee // Employee class with operator overload
{
    public int Id { get; set; } // Storing int as ID 
    
    public string FirstName { get; set; } // Property to store first name
    public string LastName { get; set; } // Property to store last name 


    public static bool operator ==(Employee a, Employee b) // Overloaded operator
    {
        return a.Id == b.Id; // returns true if both employees have the same ID
    }

    public static bool operator !=(Employee a, Employee b) // Overloaded operator
    {
        return a.Id != b.Id; // returns true if the employees have different ID's
    }
}