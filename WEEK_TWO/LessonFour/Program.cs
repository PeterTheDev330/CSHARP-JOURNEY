using System;
using System.Collections.Generic;

// this lesson covers List<T>, which is basically a resizable collection 

namespace LessonFour
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();

            // adding one item at a time to the list
            tasks.Add("Buy Milk");
            tasks.Add("Study C#");
            tasks.Add("Go for a run");

            Console.WriteLine(tasks.Count);     // gives the total number of items.
            Console.WriteLine(tasks[1]);        // outputs the second item in the list

            // adding several items to  the listat once
            tasks.AddRange(new[] { "Read the Bible", "Play Chess", "Play Call Of Duty" });

            // searching through a list
            bool exists = tasks.Contains("Study C#");       // returns either true or false 
            int position = tasks.IndexOf("Study C#");

            // the following illustrates how to remove items from the list
            bool removed = tasks.Remove("Buy Milk");            // this removes the first match
            tasks.RemoveAt(2);          // removes at item at a specific position in the list
            tasks.RemoveAll(t => t.StartsWith("C"));            // removes all items that match, it is called a lambda

            // to clear theh whole list, use the following
            tasks.Clear();

        }
    }
}