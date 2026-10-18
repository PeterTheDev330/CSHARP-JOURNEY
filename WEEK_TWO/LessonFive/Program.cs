using System;
using System.Collections.Generic;

// more  on List<T>

namespace LessonFive
{
    class Program
    {
        // passing collections to methods
        static void PrintNumbers(List<int> numbers)
        {
            foreach(int number in numbers)
            {
                Console.Write($"{number}, ");
            }
        }

        static void Main(string[] args)
        {
            // another way of creating a list with items
            List<int> numbers = new() { 5, 3, 8, 1 };

            numbers.Sort();     // sorts the list in ascending order
            numbers.Reverse();      // this reverses the list 

            foreach(int number in numbers)
            {
                Console.Write($"{number}, ");
            }

            Console.WriteLine(" ");

            PrintNumbers(numbers);
        }
    }
}