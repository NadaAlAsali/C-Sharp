using System;

namespace ConsoleApp
{
    class MathOperations
    {
        // This is a method named 'PerformOperation' that takes two integer parameters
        public void PerformOperation(int number1, int number2)
        {
            // Perform a simple math operation on the first number
            int result = number1 * 3;

            // Display the result of the operation
            Console.WriteLine("Result of the operation on first number (number1 * 3): " + result);

            // Display the second number as requested
            Console.WriteLine("Second number (number2): " + number2);
        }
    }

    // Main class where the program starts execution
    class Program
    {
        // Main method: entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate (create an object of) the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the PerformOperation method using positional arguments
            // Pass 5 as number1 and 10 as number2
            mathOps.PerformOperation(6, 12);

            // Call the PerformOperation method again, but this time using named parameters
            // This improves readability and is helpful when method has many parameters
            mathOps.PerformOperation(number1: 4, number2: 12);

            // Keep the console window open until user presses a key
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
