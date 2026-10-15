using System;

// This lesson covers more on operators 

namespace LessonFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine($"{num} is an even number.");
            }
            else
            {
                Console.WriteLine($"{num} is an odd number.");
            }

            if(num > 0)
            {
                Console.WriteLine($"{num} is positive.");
            } 
            else if(num < 0)
            {
                Console.WriteLine($"{num} is negative.");
            }
            else if(num == 0)
            {
                Console.WriteLine($"{num} is zero.");
            }
            else
            {
                Console.WriteLine("That input is invalid.");
            }


            if (num > 0 && (num % 2 == 1))
            {
                Console.WriteLine($"{num} is a positive odd number.");
            }
            else if (num < 0 && (num % 2 == 1))
            {
                Console.WriteLine($"{num} is a negative odd number.");
            }
            else if (num > 0 && (num % 2 == 0))
            {
                Console.WriteLine($"{num} is a positive prime number.");
            }
            else if (num < 0 && (num % 2 == 0))
            {
                Console.WriteLine($"{num} is a negative prime number.");
            }
            else if (num == 0)
            {
                Console.WriteLine($"{num} is zero.");
            }
            else
            {
                Console.WriteLine("That input is invalid.");
            }

        }
    }
}