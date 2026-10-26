using System;

// this lesson explores exception handling 

namespace LessonSix
{
    class Program
    {
        // throwing your own message 
        static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("The divisor cannot be zero.");
            }

            return a / b;
        }

        static void Main(string[] args)
        {

            // this is the try/catch block
            try
            {
                Console.Write("Enter a number: ");
                int n = int.Parse(Console.ReadLine()!);
                Console.WriteLine($"Double is {n * 2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("That wasn't a number.");
            }

            // try/catch block with details using the exception object
            try
            {
                Console.Write("Enter a number: ");
                int n = int.Parse(Console.ReadLine()!);
                Console.WriteLine($"Double is {n * 2}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Problem: {ex.Message}");
            }

            // try/catch block with multiple catches 
            try
            {
                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine()!);
                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine()!);

                int result = a / b;

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Bad number format.");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Somthing unexpected went wrong: {ex.Message}");
            }

            // try/catch block with finally 
            try
            {
                Console.WriteLine("Working...");
                // risky code comes here
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("This always runs");

                // finaly runs whether or not an exception happened, even when the try block uses return.
                // It is used for cleanup, auch as closing a file or releasing a resource. 
            }
        }
    }
}