using System;

// This is a lesson on arrays 

namespace LessonTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];          // this is how you declare an array with its size
            string[] names = { "Peter", "Niza", "Simpanzye" };      // this is declaring and assigning values for an array

            scores[0] = 90;     // this assigns a value in scores, at index 0, i.e. the first position 

            Console.WriteLine(names[2]);        // this fetches the third name in the array, i.e. Simpanzye
            Console.WriteLine(names.Length);     // this gives the length of the array
            Console.WriteLine(scores[0]);       // this outputs the first value in the scores array


            // to loop through an array, you do it as follows using a loop of your choice
            // using a for loop
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i}: {names[i]}");
            }

            // using a foreach loop
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}