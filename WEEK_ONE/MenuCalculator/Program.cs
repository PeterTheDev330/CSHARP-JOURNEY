using System;
using System.ComponentModel;
using System.Transactions;

// This is a menu driven calculator, using switch expressions and methods, where it makes sense.

namespace MenuCalculator
{
    class Program
    {

        static int Validate(int lower, int upper, string promt)
        {
            int value;

            Console.Write(promt);

            while(!int.TryParse(Console.ReadLine(), out value) || value < lower || value > upper)
            {
                Console.WriteLine($"Enter whole number between {lower} and {upper}");
                Console.Write("Try Again: ");
            }

            return value;

        }
        

        static int Menu()
        {
            Console.WriteLine("OPTION: ");
            Console.WriteLine("1. Add \n2. Subtract \n3. Multiply \n4. Divide \n5. Get Remainder \n6. Exit ");

            int option = Validate(1, 6, "Your Option: ");

            return option;
        }

        static double Add(double firstValue, double secondValue)
        {
            double answer = firstValue + secondValue;

            return answer;
        }

        static double Subtract(double firstValue, double secondValue)
        {
            double answer = firstValue - secondValue;

            return answer;
        }

        static double Multiply(double firstValue, double secondValue)
        {
            double answer = firstValue * secondValue;

            return answer;
        }

        static double Divide(double firstValue, double secondValue)
        {
            double answer = firstValue / secondValue;

            return answer;
        }

        static double Remainder(double firstValue, double secondValue)
        {
            double answer = firstValue % secondValue;

            return answer;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("============================================================================");
            Console.WriteLine("\t\t\t\t MENU CALCULATOR");
            Console.WriteLine("============================================================================");

            double numOne, numTwo;
            double answer;

            Console.Write("Enter first number: ");
            numOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            numTwo = Convert.ToInt32(Console.ReadLine());

            int menuChoice = Menu();

            switch (menuChoice)
            {
                case 1:
                    // add function 
                    answer = Add(numOne, numTwo);
                    Console.WriteLine($"Answer = {answer}");

                    break;
                case 2:
                    // subtarct function 
                    answer = Subtract(numOne, numTwo);
                    Console.WriteLine($"Answer = {answer}");

                    break;
                case 3:
                    // multiply function 
                    answer = Multiply(numOne, numTwo);
                    Console.WriteLine($"Answer = {answer}");

                    break;
                case 4:
                    // divide function 
                    answer = Divide(numOne, numTwo);
                    Console.WriteLine($"Answer = {answer}");

                    break;
                case 5:
                    // get remainder function 
                    answer = Remainder(numOne, numTwo);
                    Console.WriteLine($"Answer = {answer}");

                    break;
                case 6:
                    // exititing the calculator 
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    // default option 
                    break;
            }

        }
    }
}