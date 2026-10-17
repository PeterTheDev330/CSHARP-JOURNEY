using System;

// This is lesson one of leaarning methods in C#

namespace LessonOne
{
    class Program
    {
        static void Greet(string name, string greeting)
        {
            Console.WriteLine($"{greeting}, {name}");
        }

        // function overloading happens when you have multiple functions with the same name, but different parameters or datatypes.
        static int Add(int a, int b) => a + b;
        static double Add(double a, double b) => a + b;
        static int Add(int a, int b, int c) => a + b + c;

        // the following is a type of function that returns more than one value
        static (int min, int max) MinMax(int a, int b)
        {
            return (Math.Min(a, b), Math.Max(a, b));
        }

        // the following is a boolean type of function 
        static bool isEven(int n)
        {
            return n % 2 == 0;
        }


        static void Main(string[] args)
        {

            // the following is when the Greet function is called with named arguments.
            // in thiscase, the order of parameter passing does not matter.
            Greet(greeting: "Good evening", name: "Mr.Simpanzye");

            // what will differentiate with overloadwd function is the type of parameters that are passed during function calls.
            int typeOne = Add(5, 5);
            double typeTwo = Add(4.5, 6.1);
            int typeThree = Add(1, 4, 7);
            Console.WriteLine($"Funciton overloadint: type one = {typeOne}, type two = {typeTwo}, type three = {typeThree} ");

            // its calling is as follows
            var result = MinMax(8, 3);
            Console.WriteLine($"{result.min} {result.max}");

            // bool function call 
            bool answer = isEven(6);
            Console.WriteLine($"Answer = {answer}");
        }
    }
}