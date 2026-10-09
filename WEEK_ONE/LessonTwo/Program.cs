using System;

// This covers variables, data types, and string interpolation 
namespace LessonTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // data types
            int age;
            string sex;
            string name;
            decimal salary;

            // input collection 
            Console.Write("What is your name: ");
            name = Console.ReadLine();

            Console.Write("Gender (male or female): ");
            sex = Console.ReadLine();

            Console.Write("How old are you: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("How much is your salary: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            // output display 
            Console.WriteLine($"Hello. Your name is {name}, and you are a {age} year old {sex}.");
            Console.WriteLine($"Your salary is K{salary}");


            Console.Read();
        }
    }
}