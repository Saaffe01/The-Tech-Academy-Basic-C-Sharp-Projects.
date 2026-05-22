namespace MethodsAndObjects;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee(); // Instantiate a new Employee object
        employee.FirstName = "Sample"; // sets the first name property 
        employee.LastName = "Student"; // sets the last name property
        
        employee.SayName(); // call the SayName method inherited from Person
    }
}
