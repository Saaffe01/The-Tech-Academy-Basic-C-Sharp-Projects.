namespace Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        IQuitable employee = new Employee();
        employee.Quit();
    }
}