namespace ClassSubmission;

public class Calculator
{
    public void Calculate(int a, int b, out int sum, out int difference) // Method with output parameters
    {
        sum = a + b;
        difference = a - b;
    }
    
    public void Calculate(int a, int b, int c, out int sum) // Overloaded method 
    {
        sum = a + b + c;
    }
}