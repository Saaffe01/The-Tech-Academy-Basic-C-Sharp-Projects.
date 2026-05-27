using System.Globalization;
using System.Linq;

namespace LambdaExpressions;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee> // Created list of employees with at least 2 named joe
        {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee { Id = 2, FirstName = "Joe", LastName = "Jones" },
            new Employee { Id = 3, FirstName = "John", LastName = "Doe" },
            new Employee { Id = 4, FirstName = "Jane", LastName = "Doe" },
            new Employee { Id = 5, FirstName = "Mike", LastName = "Brown" },
            new Employee { Id = 6, FirstName = "Sarah", LastName = "Davis" },
            new Employee { Id = 7, FirstName = "Chris", LastName = "Wilson" },
            new Employee { Id = 8, FirstName = "Emily", LastName = "Taylor" },
            new Employee { Id = 9, FirstName = "James", LastName = "Moore" },
            new Employee { Id = 10, FirstName = "Anna", LastName = "White" }
        };

        List<Employee> joesForEach = new List<Employee>(); // create empty list to store employees named joe

        foreach (Employee emp in employees) // loop through all employees and add joes to new list
        {
            if (emp.FirstName == "Joe")
            {
                joesForEach.Add(emp);
            }
        }
        // Displays how many Joes were found using for each method
        Console.WriteLine("Joes found with foreach: " + joesForEach.Count);
        
        // using lambda expression to find all employees named Joe
        List<Employee> joesLambda = employees.Where(x => x.FirstName == "Joe").ToList();
        Console.WriteLine("Joes found with lambda: " + joesLambda.Count);
        
        // Using lambda expression to find all employees with ID greater than 5
        List<Employee> highIds = employees.Where(x => x.Id > 5).ToList();
        Console.WriteLine("Employees with Id > 5: " + highIds.Count); 
    }
    
}