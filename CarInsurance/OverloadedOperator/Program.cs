namespace OperatorOverload;

class Program
{
    static void Main(string[] args)
    {

        Employee a = new Employee(); // Creates first employee and assigns values
        a.Id = 1;
        a.FirstName = "Sample";
        a.LastName = "Student";
        
        Employee b = new Employee(); // Creates second employee and assigns values
        b.Id = 2;
        b.FirstName = "John";
        b.LastName = "Doe";

        Console.WriteLine(a == b); // Compare using " == " and display result 
        Console.WriteLine(a != b); // Compare using " != " and display result
    }
}