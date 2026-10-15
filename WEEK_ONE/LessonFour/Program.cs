using System;

// This lesson has to do with operators, and conditional statements 

namespace LessonFour
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal numOne;
            decimal numTwo;
            decimal answer;
            string sign;
            int dayOfOperation;

            Console.Write("Enter first number: ");
            numOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            numTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Choose an operator (+, -, /, *): ");
            sign = Console.ReadLine();

            if(sign == "+")
            {
                answer = numOne + numTwo;
                Console.WriteLine($"Final answer = {answer}");

            }
            else if(sign == "-")
            {
                answer = numOne - numTwo;
                Console.WriteLine($"Final answer = {answer}");

            }
            else if(sign == "/")
            {
                answer = numOne / numTwo;
                Console.WriteLine($"Final answer = {answer}");

            }
            else if(sign == "*")
            {
                answer = numOne * numTwo;
                Console.WriteLine($"Final answer = {answer}");

            }

            //Console.WriteLine($"Final answer = {answer}");

            Console.WriteLine("On which day have you done this operation: ");
            Console.Write("Enter number according to day of the week: ");
            dayOfOperation = Convert.ToInt32(Console.ReadLine());

            switch (dayOfOperation)
            {
                case 1:
                    Console.WriteLine("You did this operation on a Sunday.");
                    break;
                case 2:
                    Console.WriteLine("You did this operation on a Monday.");
                    break;
                case 3:
                    Console.WriteLine("You did this operation on a Tuesday.");
                    break;
                case 4:
                    Console.WriteLine("You did this operation on a Wednesday.");
                    break;
                case 5:
                    Console.WriteLine("You did this operation on a Thursday.");
                    break;
                case 6:
                    Console.WriteLine("You did this operation on a Friday.");
                    break;
                case 7:
                    Console.WriteLine("You did this operation on a Saturday.");
                    break;
                default:
                    Console.WriteLine("Sorry. That day does not exist.");
                    break;
            }
        }
    }
}