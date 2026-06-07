namespace AbstractClasses;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee(); // instantiated object with sample student  
        employee.firstName = "Sample";
        employee.lastName = "Student";
        employee.SayName();
    }
}