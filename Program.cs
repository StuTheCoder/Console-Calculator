using System;

public class Calculator
{
    public void Run()
    {
        Console.WriteLine("Welcome to Cato Calculator");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Exit");

            Console.WriteLine("Enter your choice (1-5): ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    PerformAddition();
                    break;
                case "2":
                    PerformSubtraction();
                    break;
                case "3":
                    PerformMultiplication();
                    break;
                case "4":
                    PerformDivision();
                    break;
                case "5":
                    Console.WriteLine("Thank you for using Cato Calculator");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void PerformAddition()
    {
        Console.Write("Enter the first number: ");
        double num1 = ReadNumber();

        Console.WriteLine("Enter the second number: ");
        double num2 = ReadNumber();

        double result = num1 + num2;
        Console.WriteLine($"Result: {result}");
    }

    private void PerformSubtraction()
    {
        Console.Write("Enter the first number: ");
        double num1 = ReadNumber();

        Console.WriteLine("Enter the second number: ");
        double num2 = ReadNumber();

        double result = num1 + num2;
        Console.WriteLine($"Result: {result}");
    }

    private void PerformMultiplication()
    {
        Console.Write("Enter the first number: ");
        double num1 = ReadNumber();

        Console.WriteLine("Enter the second number: ");
        double num2 = ReadNumber();

        double result = num1 + num2;
        Console.WriteLine($"Result: {result}");
    }

    private void PerformDivision()
    {
        Console.Write("Enter the dividend: ");
        double dividend = ReadNumber();

        Console.Write("Enter the divisor: ");
        double divisor = ReadNumber();

        if (divisor == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        else
        {
            double result = dividend / divisor;
            Console.WriteLine($"Result: {result}");
        }
    }

    private double ReadNumber()
    {
        string input = Console.ReadLine();
        double number;

        while (!double.TryParse(input, out number))
        {
            Console.WriteLine("Invalid number. Please try again.");
            input = Console.ReadLine();
        }

        return number;
    }
}