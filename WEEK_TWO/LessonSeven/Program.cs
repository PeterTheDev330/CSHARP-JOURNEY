using System;

namespace LessonSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string? name = Console.ReadLine()!;

            string user = name ?? "Guest";

            Console.WriteLine($"Name : {user}");

            int? age = null;
            Console.WriteLine(age.HasValue);
            age = 25;
            Console.WriteLine(age.Value);
            Console.WriteLine(age ?? 0);

            string sentance;
            Console.Write("Enter sentence: ");
            sentance = Console.ReadLine()!;

            string[] words = sentance.Split(" ");

            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}