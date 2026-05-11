namespace MethodAssignment;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        MathOperations math = new MathOperations();
        
        Console.WriteLine(math.Double(number));
        Console.WriteLine(math.AddNumber(number));
        Console.WriteLine(math.TripleInt(number));
    }
}