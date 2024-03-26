using System;

public class Calculator
{
    // Add method
    public static double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    // Subtract method
    public static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    // Multiply method
    public static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    // Divide method
    public static double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new ArgumentException("Cannot divide by zero.");
        }

        return num1 / num2;
    }

    // Main method for testing
    public static void Main()
    {
        // Example usage
        double resultAdd = Add(5, 3);
        Console.WriteLine("Addition: " + resultAdd);

        double resultSubtract = Subtract(8, 3);
        Console.WriteLine("Subtraction: " + resultSubtract);

        double resultMultiply = Multiply(4, 6);
        Console.WriteLine("Multiplication: " + resultMultiply);

        double resultDivide = Divide(9, 3);
        Console.WriteLine("Division: " + resultDivide);
    }
}
