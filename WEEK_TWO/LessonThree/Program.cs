using System;

// more operations on arrays

namespace LessonThree
{
    class Program
    {
        static void Main(string[] args)
        {
            // sorting an array in ascending order. strings get sorted alphabetically.
            int[] scores = { 72, 95, 60, 88 };
            Array.Sort(scores);        

            foreach (int score in scores)
            {
                Console.Write($"{score}, ");
            }

            Console.WriteLine(" ");

            // reverssing the order of items in an array
            string[] names = { "Peter", "Niza", "Simpanzye" };
            Array.Reverse(names);

            foreach (string name in names)
            {
                Console.Write($"{name}, ");
            }

            Console.WriteLine(" ");

            // getting the index of a value in an array
            // it returns the index of the first match, or -1 if the value is not in the array
            int position = Array.IndexOf(names, "Niza");            // returns 1
            int missing = Array.IndexOf(names, "Sparrow");          // return -1

            Console.WriteLine($"{position} = \"Niza\", {missing} = \"Sparrow\"");

            // copying an values in one array into another
            int[] newScores = new int[scores.Length];
            Array.Copy(scores, newScores, scores.Length);

            foreach(int newScore in newScores)
            {
                Console.Write($"{newScore}, ");
            }
        }
    }
}