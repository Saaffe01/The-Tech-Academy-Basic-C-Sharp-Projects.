namespace Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        IQuitable employee = new Employee(); // Using polymorphism, holds Employee object
        employee.Quit(); // Calling the Quit method, runs employee's version
    }
}
